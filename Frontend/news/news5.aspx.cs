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
using System.Text;

public partial class xinwen5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string strSQL2 = "select * from 人力资源部.dbo.WYH_ZY1 where 2=3";
            DataTable dtData = D_SQL_Common_DongLi.ReadDataTable(strSQL2);
            DataTable dtData2 = dtData.Copy();
            try
            {

                string strA = (string)Session["NewsData"];
                Label1.Text = strA;
                strA = strA.Replace("{", "");
                strA = strA.Replace("[", "");
                string[] strB = strA.Split('}');
                for (int i = 0; i < strB.Length - 1; i++)
                {
                    string[] strC = strB[i].Split(']');
                    string strID = "";
                    string strTitle = "";
                    string strurl = "";
                    string strimg = "";
                    string strdate = "";
                    for (int j = 0; j < strC.Length; j++)
                    {
                        string[] strD = strC[j].Split('#');
                        if (strD.Length >= 2)
                        {
                            if (strD[0].ToString().ToUpper().IndexOf("ID") > -1) { strID = strD[1]; }
                            if (strD[0].ToString().ToUpper().IndexOf("TITLE") > -1) { strTitle = strD[1]; }
                            if (strD[0].ToString().ToUpper().IndexOf("URL") > -1) { strurl = strD[1]; }
                            if (strD[0].ToString().ToUpper().IndexOf("IMG") > -1) { strimg = strD[1]; }
                            if (strD[0].ToString().ToUpper().IndexOf("DATE") > -1) { strdate = strD[1]; }
                        }
                    }

                    DataRow dr = dtData.NewRow();
                    dr["ID"] = strID;
                    dr["TITLE"] = strTitle;
                    dr["URL"] = strurl;
                    dr["IMG"] = strimg;
                    dr["DATE"] = strdate;

                    DataRow dr2 = dtData2.NewRow();
                    dr2["ID"] = strID;
                    dr2["TITLE"] = strTitle;
                    dr2["URL"] = strurl;
                    dr2["IMG"] = strimg;
                    dr2["DATE"] = strdate;

                    
                    if (strimg.Substring(0, 5) == "http:" || strimg.Substring(0, 6) == "https:") { dtData.Rows.Add(dr); }
                    else { dtData2.Rows.Add(dr2); }
                }
            }
            catch { }


            StringBuilder strHTML = new StringBuilder();
            for (int i = 0; i < dtData.Rows.Count; i++)
            {
                strHTML.Append("                    <li>");
                strHTML.Append("                        <div class=\"left\"><a  href=\"" + dtData.Rows[i]["url"].ToString() + "\"><img style=\"width:140px; height:80px;\" src=\"" + dtData.Rows[i]["img"].ToString() + "\" alt=\"\"></a></div>");
                strHTML.Append("                        <div class=\"right\"><div class=\"right_top\"><a  href=\"" + dtData.Rows[i]["url"].ToString() + "\"><h3>" + dtData.Rows[i]["title"].ToString() + "</h3><a></div>");
                if (dtData.Rows[i]["title"].ToString().Length > 70)
                {
                    strHTML.Append("                            <div class=\"right_bottom\"><div class=\"right_bottom_left\"><span></span></div></div></div>");
                }
                else
                {
                    strHTML.Append("                            <div class=\"right_bottom\"><div class=\"right_bottom_left\"><span>" + dtData.Rows[i]["date"].ToString() + "</span></div></div></div>");
                }

            }
            Label1.Text = strHTML.ToString();


            strHTML.Length = 0;
            for (int i = 0; i < dtData2.Rows.Count; i++)
            {
                strHTML.Append("                    <li>");
                strHTML.Append("<h3><a  href=\"" + dtData2.Rows[i]["url"].ToString() + "\">" + dtData2.Rows[i]["title"].ToString() + "</h3><a><br />");
                strHTML.Append("<p style=\"font-size: 12px;\">" + dtData2.Rows[i]["img"].ToString() + "</p><br />");
                strHTML.Append("<p style=\"color: blue;font-size: 12px;\">" + dtData2.Rows[i]["date"].ToString() + "</p>");
                strHTML.Append("                    </li>");
            }
            Label2.Text = strHTML.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("news.aspx");
    }
}
