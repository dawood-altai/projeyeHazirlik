using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeErtev
{
    public partial class eliste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EgitimCRUD listislem = new EgitimCRUD();
            DataTable tbl = new DataTable();
            bool mesaj;
            if (Request.QueryString["prm"] == null)
            {
                
                tbl = listislem.listele();

                Tablo.InnerHtml = "<table class='table table-dark table-bordered table-hover'>";
                Tablo.InnerHtml += "<tr><td class='fw-bolder'>Eğitim Türü</td> <td class='fw-bolder'>Eğitim Adi</td> <td class='fw-bolder'>Eğitim Tarihi</td> <td class='fw-bolder'>Öğrenci Sayısı</td> <td class='fw-bolder'>İçerik</td> <td class='fw-bolder'>Eğitim Kodu</td> <td class='fw-bolder'>SİL</td>  </tr>";

                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    Tablo.InnerHtml += "<tr><td>" + tbl.Rows[i][0] + "</td><td>" + tbl.Rows[i][1] + "</td><td>" + Convert.ToDateTime(tbl.Rows[i][2].ToString()).ToShortDateString() + "</td><td>" + tbl.Rows[i][3] +
                        "</td><td>" + tbl.Rows[i][4] + "</td><td>" + tbl.Rows[i][5] + "</td><td><a href='eliste.aspx?prm=" + tbl.Rows[i][5] + "' onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='imges/delete.png' width='30' height='30'></a></td></tr>";
                }

                Tablo.InnerHtml += "</table>";
            }


            else
            {
                mesaj = listislem.sil(Request.QueryString["prm"]);

                if (mesaj == true)
                {
                    Response.Redirect("eliste.aspx");
                }
                else
                {
                    basarili.Visible = true;
                    basarisiz.Visible = false;
                }
            }

            
            
        }
    }
}