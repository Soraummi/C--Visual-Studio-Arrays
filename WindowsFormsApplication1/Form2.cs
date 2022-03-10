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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int elemansayisi;      
        int sayac=0; int sayac2=0;
        int[] sayilar;
        
        private void button1_Click(object sender, EventArgs e)
        {  
                     
            Random rnd = new Random();
            sayilar = new int[elemansayisi];
            for (int i = 0; i < sayilar.Length; i++)
            {
                
                sayilar[i] = rnd.Next(0, 100);
                

            }  
                    
            foreach (int sayi in sayilar)
            {
                sayac++;

                if (lstolustur.Items.Contains(sayi) == false)
                {
                    lstolustur.Items.Add( sayac + "-" + sayi);
                    
                }
                else
                    sayac--;
            }
            


            sayac = 0;       
        }
         
        private void btncopy_Click(object sender, EventArgs e)
        {
            
            int[] sayilar2 = new int[elemansayisi];
            for (int i = 0; i < sayilar2.Length; i++)
            {
              
                sayilar2[i] = sayilar[i];
                
            }

            foreach (int copy in sayilar2)
            {
                lblmax.Text =Convert.ToString(sayilar2.Max());
                lblrank.Text = Convert.ToString(sayilar2.Rank);
                lblenght.Text = Convert.ToString(sayilar2.Length);
                lblmin.Text = Convert.ToString(sayilar2.Min());
                lblsum.Text = Convert.ToString(sayilar2.Sum());
                lblaverage.Text = Convert.ToString(sayilar2.Average());
                lblfırst.Text = Convert.ToString(sayilar2.First());
                lblast.Text = Convert.ToString(sayilar2.Last());
                
                //label2.Text = Convert.ToString(sayilar.Max());
                //label3.Text = Convert.ToString(sayilar.Rank);
                //label4.Text = Convert.ToString(sayilar.Length);
                //label5.Text = Convert.ToString(sayilar.Min());
                //label6.Text = Convert.ToString(sayilar.Sum());
                //label7.Text = Convert.ToString(sayilar.Average());
                //label8.Text = Convert.ToString(sayilar.First());
                //label9.Text = Convert.ToString(sayilar.Last());
                sayac2++;
                lstbcopy.Items.Add( sayac2 +"-"+ copy);
               
            }
            sayac2 = 0;
      }
        
        private void btnbasla_Click(object sender, EventArgs e)
        {
            elemansayisi =Convert.ToInt32(txtbeleman.Text);      
            btncopy.Enabled = true;
            btnsayi.Enabled = true;
            txtbeleman.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            btncopy.Enabled = false;
            btnsayi.Enabled = false;
        }
    }
}
