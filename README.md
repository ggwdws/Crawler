# Crawler
A python news crawler with web interface
# Requirements

+ PhantomJS 
+ selenium
+ tornado
+ urllib
+ bs4

To install PhantomJS in Linux
```
wget https://bitbucket.org/ariya/phantomjs/downloads/phantomjs-1.9.7-linux-x86_64.tar.bz2
tar -xjvf phantomjs-1.9.7-linux-x86_64.tar.bz2
sudo ln -s ~/bin/phantomjs-1.9.7-linux-x86_64/bin/phantomjs /usr/local/bin/phantomjs
```

To install Others
```
pip install -r requirements.txt
```

# Usage

Run Backend.py in server with 8081 port open (in&out)
```
python3 Backend.py&
```
Then open the web page: [this page](http://xxdkb.f3322.org:2777/news/news.aspx)
