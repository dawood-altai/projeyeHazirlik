using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjeErtev
{
    public partial class eguncelle : System.Web.UI.Page
    {
        Egitim EG = new Egitim();
        EgitimCRUD EGislem = new EgitimCRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            string kod;
            kod = (Request.QueryString["prm"]);

            if (!IsPostBack)
            {
                EG = EGislem.getir(kod);
                TextBox1.Text = EG.Tur;
                TextBox2.Text = EG.Adi;
                TextBox3.Text = Convert.ToDateTime(EG.Tarih).ToString("yyyy-MM-dd");
                TextBox4.Text = Convert.ToInt16(EG.Ogrsayisi).ToString();
                TextBox5.Text = EG.Icerik;
                TextBox6.Text = EG.Kod;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Egitim egitim = new Egitim();
            egitim.Tur = TextBox1.Text;
            egitim.Adi = TextBox2.Text;
            egitim.Tarih = (TextBox3.Text).ToString();
            egitim.Ogrsayisi = Convert.ToInt32((TextBox4.Text).ToString());
            egitim.Icerik = TextBox5.Text;
            egitim.Kod = TextBox6.Text;


            if (EGislem.guncelle(egitim))
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