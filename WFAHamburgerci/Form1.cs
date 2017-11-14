using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public static List<Siparis> siparisler = new List<Siparis>();

		public static List<Siparis> mevcutSiparisler = new List<Siparis>();


		public static List<Menu> menuler = new List<WFAHamburgerci.Menu>() {
			new Menu() {MenuAdi = "Steak House", Fiyati = 3},
			new Menu() {MenuAdi = "Big king", Fiyati = 4},
			new Menu() {MenuAdi = "King Chicken", Fiyati = 5}
		};

		public static List<Extra> extraMalzemeler = new List<Extra>() { new Extra() { ExtraAdi = "Hardal", Fiyati = 1 },
			new Extra() { ExtraAdi = "Ketçap", Fiyati = 2  }

		};

		private void btnSiparisEkle_Click(object sender, EventArgs e)
		{
			Siparis yeniSiparis = new Siparis();
			yeniSiparis.SeciliMenusu = (Menu)cbMenuler.SelectedItem;

			if (rbKucuk.Checked)
			{
				yeniSiparis.Boyutu = Boyut.Kucuk;
			}
			else if (rbOrta.Checked)
			{
				yeniSiparis.Boyutu = Boyut.Orta;
			}
			else
			{
				yeniSiparis.Boyutu = Boyut.Buyuk;
			}

			yeniSiparis.ExtraMalzemesi = new List<Extra>();

			foreach (CheckBox item in flpExtraMalzemeler.Controls)
			{
				if (item.Checked)
				{
					yeniSiparis.ExtraMalzemesi.Add((Extra)item.Tag);
				}
			}

			yeniSiparis.Adet = (int)nmrAdet.Value;
			yeniSiparis.Hesapla();
			mevcutSiparisler.Add(yeniSiparis);
			siparisler.Add(yeniSiparis);
			lstSiparisler.Items.Add(yeniSiparis);

			TutarHesapla();
		}

		private void btmSiparisTamamla_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Toplam Sipariş Ücreti: " + TutarHesapla().ToString() + "Satın almayı tamamlamak istiyor musunuz?", "Sipariş Bilgisi", MessageBoxButtons.OKCancel);

			if (dr == DialogResult.OK)
			{
				// Mutfağa bilgi gönder...
				lstSiparisler.Items.Clear();
				mevcutSiparisler.Clear();
				TutarHesapla();
				MessageBox.Show("Siparişiniz Tamamlandı. 15 dk. içerisinde teslim edilecek.");
			}
			else if (dr == DialogResult.Cancel)
			{
				MessageBox.Show("Siparişiniz iptal edildi.");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FileHelper.MenuDosyaYarat();
			FileHelper.MenuIlkDegerleriniDoldur();

			foreach (Menu menu in menuler)
			{
				cbMenuler.Items.Add(menu);
			}

			foreach (Extra extra in extraMalzemeler)
			{
				flpExtraMalzemeler.Controls.Add(new CheckBox() { Text = extra.ExtraAdi, Tag = extra });
			}

			foreach (Siparis siparis in siparisler)
			{
				lstSiparisler.Items.Add(siparis);
			}

			TutarHesapla();

		}

		private decimal TutarHesapla()
		{
			decimal toplamTutar = 0;
			for (int i = 0; i < lstSiparisler.Items.Count; i++)
			{
				Siparis gelen = (Siparis)lstSiparisler.Items[i];
				toplamTutar += gelen.ToplamTutar;
			}
			lblToplamTutar.Text = toplamTutar.ToString() + " ₺";
			return toplamTutar;
		}
	}
}
