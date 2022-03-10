using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            sayac = 5;
            sayac = sayac - 1;
            InitializeComponent();
        }
        string [] ogrenci = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        int sayac = 5;
        
        private void button1_Click(object sender, EventArgs e)
        {
            


            ogrenci[index] = txtgiris.Text;
            notlar[index] =Convert.ToInt32(txtnot.Text);
            index++;

            lblsayac.Text = sayac.ToString();
            sayac--;
            txtnot.Clear();
            txtgiris.Clear();
            txtgiris.Focus();

            if (sayac == -1)
            {
                btnlistele.Enabled = true ;
                txtgiris.Enabled = false;
                txtnot.Enabled = false;
                button1.Enabled = false;

            }

            


        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <  ogrenci.Length; i++)
            {
                listBox1.Items.Add(ogrenci[i] +  notlar[i]);
            }


        }

        private void btnyuksek_Click(object sender, EventArgs e)
        {
            int enyuksek;
            for (int i = 1; i < ogrenci.Length; i++)
            {
                enyuksek = notlar[0];
                if(enyuksek<notlar[i])
                {
                    enyuksek = notlar[i];
                    txtyuksek.Text = enyuksek.ToString();
                }
                txtyuksek.Text = enyuksek.ToString();
            }
        }

        private void btndusuk_Click(object sender, EventArgs e)
        {
           int endüsük = notlar[0];
            for (int i = 0; i < ogrenci.Length; i++)
            {
                endüsük = notlar[0];
                if(endüsük>notlar[i])
                
                    endüsük = notlar[i];               
                
            }
            txtdusuk.Text = endüsük.ToString();
        }

       
       
        

       private void Form1_Load(object sender, EventArgs e)
        {
            txtort.Enabled = false;
            txtdusuk.Enabled = false;
            txtyuksek.Enabled = false;
            btnlistele.Enabled = false;
        }

        private void btnortalama_Click_1(object sender, EventArgs e)
        {
            {
                int toplam = 0;
                for (int i = 0; i < ogrenci.Length; i++)
                {
                    toplam += notlar[i];
                }
                txtort.Text = (toplam / ogrenci.Length).ToString();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtyuksek.Enabled = false;
            txtort.Enabled = false;
            txtdusuk.Enabled = false;
            btnlistele.Enabled = false;
        }
    }
}
