using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
namespace DataLayer
{
    public class Kantar
    {
        public const string connection = "Data Source = DESKTOP-KDT1G86\\SQLEXPRESS; Initial Catalog = kantar; Integrated Security = True";
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter da;

        public SqlCommand CreateCommand()//sql ile bağlantıyı sağlaayan fonksiyon
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = connection;
            SqlCommand command = new SqlCommand();
            command.Connection = baglanti;
            return command;
        }

        public void Connection(string prc)//prosedüre bağlanma işlemi
        {
            cmd = CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = prc;
            if (cmd.Connection.State == ConnectionState.Closed) cmd.Connection.Open();
        }
        public SqlDataReader prc_giris(string kullaniciadi, string parola)
        {
            Connection("prc_giris");
            cmd.Parameters.Add("@kadi", kullaniciadi);
            cmd.Parameters.Add("@parola", parola);
            reader = cmd.ExecuteReader();
            return reader;
        }
        public SqlDataAdapter AracGoster()
        {
            SqlDataAdapter day = new SqlDataAdapter("select  aracID as Sıra , plaka as Plaka, şoför as Şoför, GirisTarihi as 'Giriş Tarihi',kullaniciAdi as 'Kullanıcı Adı', GirisAgirlik as Ağırlık from Tbl_Araclar a join Tbl_Kullanici k on a.kullaniciID=k.kullaniciID where durum=1", connection);
            return day;
        }
        public void AracGiris(string plaka,string sofor,int kullaniciID,string giristarihi,int girisagirlik, string girissaat)
        {
            Connection("prc_AracGirisKayit");
            cmd.Parameters.Add("@Plaka", plaka );
            cmd.Parameters.Add("@Şoför", sofor);
            cmd.Parameters.Add("@kullaniciID", kullaniciID);
            cmd.Parameters.Add("@GirisTarihi", giristarihi);
            cmd.Parameters.Add("@GirisAgirlik", girisagirlik);
            cmd.Parameters.Add("@GirisSaat", girissaat);
            cmd.ExecuteNonQuery();
        }
        public void AracCikis(int aracID,int cikisagirlik, int urunagirlik,  string cikistarihi, string cikissaat)
        {
            Connection("prc_AracCikis");
            cmd.Parameters.Add("@aracID", aracID);
            cmd.Parameters.Add("@CikisAgirlik", cikisagirlik);
            cmd.Parameters.Add("@UrunAgirlik", urunagirlik);
            cmd.Parameters.Add("@CikisTarih", cikistarihi);
            cmd.Parameters.Add("@CikisSaat", cikissaat);
   
            cmd.ExecuteNonQuery();
        }
        public int AracSay()
        {
            Connection("prc_AracSayisi");
            Int32 count = (Int32)cmd.ExecuteScalar();
            return count;
        }

      public SqlDataAdapter TarihSirala(string kucuktarih,string buyuktarih)
        {
            SqlDataAdapter day = new SqlDataAdapter("select   GirisTarihi as 'Giriş Tarihi' ,GirisSaat as 'Giriş Saati', Plaka, Şoför, GirisAgirlik as 'Giriş Ağırlığı', CikisTarih as 'Çıkış Tarihi', CikisSaat as 'Çıkış Saati', UrunAgirlik as 'Ürün Ağırlığı' FROM Tbl_Araclar where(GirisTarihi between '" + kucuktarih+"' and '"+buyuktarih+"')", connection);
          return day;
        }

        public SqlDataAdapter PlakaSorgu(string plaka)
        {
            SqlDataAdapter day = new SqlDataAdapter(" select  Plaka, Şoför, GirisTarihi as 'Giriş Tarihi' ,GirisSaat as 'Giriş Saati', GirisAgirlik as 'Giriş Ağırlığı', CikisTarih as 'Çıkış Tarihi', CikisSaat as 'Çıkış Saati', UrunAgirlik as 'Ürün Ağırlığı' FROM Tbl_Araclar where Plaka='" + plaka+"'", connection);
            return day;
        }
        public SqlDataAdapter SoforSorgu(string sofor)
        {
            SqlDataAdapter day = new SqlDataAdapter(" select ad as 'Ad',soyad as 'Soyad',  mail as 'Mail' ,firmaAdi as 'Firma Adı', belge1 as 'Belge1', belge2 as 'Belge2', belge3 as 'Belge3', belge4 as 'Belge4' FROM dosyagonder where durum=0", connection);
            return day;
        }

        public SqlDataReader prc_Plaka()
        {
            Connection("prc_Plaka");
            reader = cmd.ExecuteReader();
            return reader;
        }
        public SqlDataReader prc_Sofor()
        {
            Connection("prc_Sofor");
            reader = cmd.ExecuteReader();
            return reader;
        }
        public SqlDataAdapter CikisTarihSirala(string kucuktarih, string buyuktarih)
        {
            SqlDataAdapter day = new SqlDataAdapter("select  CikisTarih as 'Çıkış Tarihi', CikisSaat as 'Çıkış Saati', Plaka, Şoför, GirisTarihi as 'Giriş Tarihi' ,GirisSaat as 'Giriş Saati' , GirisAgirlik as 'Giriş Ağırlığı',  UrunAgirlik as 'Ürün Ağırlığı'  FROM Tbl_Araclar where(CikisTarih between '" + kucuktarih + "' and '" + buyuktarih + "'and durum=0);", connection);
            return day;
        }
    }
}
