from selenium import webdriver
from bs4 import BeautifulSoup
import tornado.ioloop
import tornado.web
import requests
import urllib
import math
import time

class NewsCrawler():

    def __init__(self):
    
        self.cgtn_url = 'https://www.cgtn.com/search?keyword={}'
        self.github_url = 'https://github.com/search?q={}'

    def get_cgtn_news(self, keyword, total_num):
    
        driver = webdriver.PhantomJS(service_args=['--ignore-ssl-errors=true', '--ssl-protocol=TLSv1'])
        url = self.cgtn_url.format(keyword)
        driver.get(url)
        driver.find_element_by_class_name('date-sort-t').click()
        for i in range(int(total_num / 10)):
            driver.execute_script("window.scrollTo(0, document.body.scrollHeight);")
            time.sleep(1)
            driver.find_element_by_class_name('loader-more').click()

        driver.execute_script("window.scrollTo(0, document.body.scrollHeight);")
        time.sleep(1)

        info_img = BeautifulSoup(driver.page_source, 'html.parser').find_all('div', class_='m-content-middle-row')
        info_title = BeautifulSoup(driver.page_source, 'html.parser').find_all('div', class_='title')
        info_date = BeautifulSoup(driver.page_source, 'html.parser').find_all('div', class_='time')
        
        data = ""
        num = 0
        for img, title, date in zip(info_img, info_title, info_date):
            
            for i in img.a:
                img = i['data-original']
                break
            title = title.a
            url = title['href']
            title = title.text
            date = date.text
            
            data += "{" + "[img#{}][title#{}][url#{}][id#{}][date#{}]".format(img, title, url, (num + 1), date) + "}"
            num += 1 
            if(num >= total_num):
                break
            
        print(num)
        return data
    
    
    def get_github_news(self, keyword, total_num):

        driver = webdriver.PhantomJS(service_args=['--ignore-ssl-errors=true', '--ssl-protocol=TLSv1'])
        url = self.github_url.format(keyword)
        driver.get(url)
        
        data = ""
        num = total_num
        for i in range(math.ceil(total_num/10)):
            info_img = BeautifulSoup(driver.page_source, 'html.parser').find_all('div', class_='mt-n1')  
            info_title = BeautifulSoup(driver.page_source, 'html.parser').find_all('a', class_='v-align-middle')

            for img, title in zip(info_img, info_title):

                url = title['data-hydro-click'].split(',')[9][7: -2]
                title = title.text

                text = img.text.replace('\n', '')
                text = text.split('   ')
                text = [i.lstrip() for i in text if i != '']
                
                date = len(text) - 1
                while text[date][0] != 'U':
                    date -= 1
                date = text[date]
                
                content = text[1].lstrip()

                if len(title) < len(text[0]):
                    content = text[0][len(title):]
                elif content.isdigit():
                    content = ""

                data += "{" + "[img#{}][title#{}][url#{}][id#{}][date#{}]".format(content, title, url, (num + 1), date) + "}"
                num += 1
                
                if(num >= total_num * 2):
                    break
                    
            driver.find_element_by_class_name('next_page').click()
            print(num)
        return data
    

class MainHandler(tornado.web.RequestHandler):

    def get(self):
    
        keyword = self.get_argument('keywords', 'trump')
        pagenum = self.get_argument('num', '25')
        pagenum = pagenum.lstrip()
        pagenum = pagenum.rstrip()
        news = NewsCrawler()
        
        data = news.get_cgtn_news(keyword, int(pagenum))
        data += news.get_github_news(keyword, int(pagenum)) 
        
        self.write(data)


def make_app():

    return tornado.web.Application([
            (r"/", MainHandler),
    ])


if __name__ == "__main__":
    app = make_app()
    app.listen(8081)
    tornado.ioloop.IOLoop.current().start()
