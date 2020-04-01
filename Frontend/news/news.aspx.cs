using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;
using System.IO;
using System.Text;

public partial class xinwen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            string strKey = TextBox3.Text;
            strKey = Server.UrlEncode(strKey);
            string strPage = TextBox1.Text;
            WebRequest request = WebRequest.Create("http://116.85.23.150:8081/?keywords=" + strKey + "&num=" + strPage);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));

            string strA = reader.ReadToEnd();

            try
            {
                Session["NewsData"] = strA;
                Response.Redirect("news5.aspx");
            }
            catch { }

            reader.Close();
            reader.Dispose();
            response.Close();
        }
        catch (Exception ex)
        {

        }
    }

    public class AboutJson
    {
        public static string DataTableToJson(DataTable dtData)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(dtData);
        }
        public static DataTable JsonToDataTable(string strJson)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(strJson);
        }
    }
}
