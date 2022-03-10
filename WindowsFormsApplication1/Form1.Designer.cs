namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtgiris = new System.Windows.Forms.TextBox();
            this.txtnot = new System.Windows.Forms.TextBox();
            this.lblsayac = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnyuksek = new System.Windows.Forms.Button();
            this.btnortalama = new System.Windows.Forms.Button();
            this.btndusuk = new System.Windows.Forms.Button();
            this.txtyuksek = new System.Windows.Forms.TextBox();
            this.txtort = new System.Windows.Forms.TextBox();
            this.txtdusuk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtgiris
            // 
            this.txtgiris.Location = new System.Drawing.Point(259, 37);
            this.txtgiris.Name = "txtgiris";
            this.txtgiris.Size = new System.Drawing.Size(100, 20);
            this.txtgiris.TabIndex = 1;
            // 
            // txtnot
            // 
            this.txtnot.Location = new System.Drawing.Point(259, 67);
            this.txtnot.Name = "txtnot";
            this.txtnot.Size = new System.Drawing.Size(100, 20);
            this.txtnot.TabIndex = 2;
            // 
            // lblsayac
            // 
            this.lblsayac.AutoEllipsis = true;
            this.lblsayac.AutoSize = true;
            this.lblsayac.Location = new System.Drawing.Point(77, 249);
            this.lblsayac.Name = "lblsayac";
            this.lblsayac.Size = new System.Drawing.Size(0, 13);
            this.lblsayac.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(178, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 186);
            this.listBox1.TabIndex = 5;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(97, 142);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 6;
            this.btnlistele.Text = "list";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnyuksek
            // 
            this.btnyuksek.Location = new System.Drawing.Point(284, 142);
            this.btnyuksek.Name = "btnyuksek";
            this.btnyuksek.Size = new System.Drawing.Size(75, 23);
            this.btnyuksek.TabIndex = 7;
            this.btnyuksek.Text = "En Yüksek";
            this.btnyuksek.UseVisualStyleBackColor = true;
            this.btnyuksek.Click += new System.EventHandler(this.btnyuksek_Click);
            // 
            // btnortalama
            // 
            this.btnortalama.Location = new System.Drawing.Point(284, 171);
            this.btnortalama.Name = "btnortalama";
            this.btnortalama.Size = new System.Drawing.Size(75, 23);
            this.btnortalama.TabIndex = 8;
            this.btnortalama.Text = "Ortalama";
            this.btnortalama.UseVisualStyleBackColor = true;
            this.btnortalama.Click += new System.EventHandler(this.btnortalama_Click_1);
            // 
            // btndusuk
            // 
            this.btndusuk.Location = new System.Drawing.Point(284, 200);
            this.btndusuk.Name = "btndusuk";
            this.btndusuk.Size = new System.Drawing.Size(75, 23);
            this.btndusuk.TabIndex = 9;
            this.btndusuk.Text = "En Düşük";
            this.btndusuk.UseVisualStyleBackColor = true;
            this.btndusuk.Click += new System.EventHandler(this.btndusuk_Click);
            // 
            // txtyuksek
            // 
            this.txtyuksek.Location = new System.Drawing.Point(365, 145);
            this.txtyuksek.Name = "txtyuksek";
            this.txtyuksek.Size = new System.Drawing.Size(100, 20);
            this.txtyuksek.TabIndex = 10;
            // 
            // txtort
            // 
            this.txtort.Location = new System.Drawing.Point(365, 171);
            this.txtort.Name = "txtort";
            this.txtort.Size = new System.Drawing.Size(100, 20);
            this.txtort.TabIndex = 11;
            // 
            // txtdusuk
            // 
            this.txtdusuk.Location = new System.Drawing.Point(365, 203);
            this.txtdusuk.Name = "txtdusuk";
            this.txtdusuk.Size = new System.Drawing.Size(100, 20);
            this.txtdusuk.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 365);
            this.Controls.Add(this.txtdusuk);
            this.Controls.Add(this.txtort);
            this.Controls.Add(this.txtyuksek);
            this.Controls.Add(this.btndusuk);
            this.Controls.Add(this.btnortalama);
            this.Controls.Add(this.btnyuksek);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblsayac);
            this.Controls.Add(this.txtnot);
            this.Controls.Add(this.txtgiris);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtgiris;
        private System.Windows.Forms.TextBox txtnot;
        private System.Windows.Forms.Label lblsayac;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnyuksek;
        private System.Windows.Forms.Button btnortalama;
        private System.Windows.Forms.Button btndusuk;
        private System.Windows.Forms.TextBox txtyuksek;
        private System.Windows.Forms.TextBox txtort;
        private System.Windows.Forms.TextBox txtdusuk;
    }
}

