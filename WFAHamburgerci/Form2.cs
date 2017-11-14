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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Form1.menuler.Add(new Menu() { MenuAdi = txtMenuAdi.Text, Fiyati = nmrFiyat.Value });
            MessageBox.Show("Menu listeye eklendi. " + DateTime.Now + Environment.UserName);
        }
    }
}
