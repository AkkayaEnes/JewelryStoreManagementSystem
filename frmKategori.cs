using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KuyumcuYonetimSistemiV1
{
    public partial class frmKategori : DevExpress.XtraEditors.XtraForm
    {
        public frmKategori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-MQ6MQBD\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        bool durum;
        private void kategoriengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kategori"].ToString() || textBox1.Text=="")
                {
                    durum=false;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum == true)
            {


                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                textBox1.Text = "";
                MessageBox.Show("Kategori Eklendi");

            }
            else
            {
                MessageBox.Show("Böyle bir kategori var", "Uyarı");
            }
            textBox1.Text = "";

        }
    }
}