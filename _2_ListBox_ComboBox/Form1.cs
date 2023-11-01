using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_ListBox_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlceler.Items.Clear(); // Her seçimde önceki ilçeleri temizle

            if (cmbSehirler.SelectedIndex == 0)
            {
                cmbIlceler.Items.Add("Karşıyaka");
                cmbIlceler.Items.Add("Narlıdere");
                cmbIlceler.Items.Add("Güzelbahçe");
            }
            else if (cmbSehirler.SelectedIndex == 1)
            {
                cmbIlceler.Items.Add("Büyükşehir");
                cmbIlceler.Items.Add("Taksim");
                cmbIlceler.Items.Add("Büyükçekmece");
                cmbIlceler.Items.Add("Küçükçekmece");
                cmbIlceler.Items.Add("Altınboynuz");
                cmbIlceler.Items.Add("Avrupa yakası");
            }
            if (cmbSehirler.SelectedItem == "Ankara")
            {
                cmbIlceler.Items.Add("Karşıyaka");
                cmbIlceler.Items.Add("Narlıdere");
                cmbIlceler.Items.Add("Güzelbahçe");
                cmbIlceler.SelectedIndex = 0;
            }

            else if (cmbSehirler.SelectedItem == "Şırnak")
            {
                cmbIlceler.Items.Add("Cizre");
                cmbIlceler.Items.Add("Silopi");
                cmbIlceler.Items.Add("İdil");
                cmbIlceler.Items.Add("Uludere");
                cmbIlceler.Items.Add("Beytüşebap");
                cmbIlceler.Items.Add("Roma");
                cmbIlceler.SelectedIndex = 0;

            }
            else if (cmbSehirler.SelectedItem == "İstanbul")
            {
                cmbIlceler.Items.Add("BÜyükşehir");
                cmbIlceler.Items.Add("Taksim");
                cmbIlceler.Items.Add("Büyükçekmece");
                cmbIlceler.Items.Add("Küçükçekmece");
                cmbIlceler.Items.Add("Altınboynuz");
                cmbIlceler.Items.Add("Avrupa yakası");
                cmbIlceler.SelectedIndex = 0;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSehirler.Items.Add("Ankara");
            cmbSehirler.Items.Add("İstanbul");
            cmbSehirler.Items.Add("Eskişehir");
            cmbSehirler.Items.Add("Şırnak");
            cmbSehirler.Items.Add("Diyarbakır");
            cmbSehirler.Items.Add("Bingöl");
            cmbSehirler.Items.Add("Hakkari");
            cmbSehirler.SelectedIndex = 0;


        }

        
    }
}
