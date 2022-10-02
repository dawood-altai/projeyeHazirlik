using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeErtev
{
    public partial class eekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool gelen;
            Egitim egitim = new Egitim();
            egitim.Tur = TextBox1.Text;
            egitim.Adi = TextBox2.Text;
            egitim.Tarih =  TextBox3.Text;
            egitim.Ogrsayisi=Convert.ToInt32((TextBox4.Text).ToString());
            egitim.Icerik = TextBox5.Text;
            egitim.Kod=TextBox6.Text;

            EgitimCRUD islem= new EgitimCRUD();
            gelen = islem.kaydet(egitim);
            if(gelen==true)
            {

                basarili.Visible = true;
                basarisiz.Visible = false;
            }
            else
            {
                basarili.Visible = false;
                basarisiz.Visible = true;
            }
        }
    }
}