namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.lstolustur = new System.Windows.Forms.ListBox();
            this.btnsayi = new System.Windows.Forms.Button();
            this.btncopy = new System.Windows.Forms.Button();
            this.lstbcopy = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbeleman = new System.Windows.Forms.TextBox();
            this.btnbasla = new System.Windows.Forms.Button();
            this.lblmax = new System.Windows.Forms.Label();
            this.lblrank = new System.Windows.Forms.Label();
            this.lblenght = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblsum = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.lblfırst = new System.Windows.Forms.Label();
            this.lblast = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstolustur
            // 
            this.lstolustur.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstolustur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstolustur.FormattingEnabled = true;
            this.lstolustur.Location = new System.Drawing.Point(105, 99);
            this.lstolustur.Name = "lstolustur";
            this.lstolustur.Size = new System.Drawing.Size(120, 171);
            this.lstolustur.TabIndex = 0;
            // 
            // btnsayi
            // 
            this.btnsayi.Location = new System.Drawing.Point(24, 171);
            this.btnsayi.Name = "btnsayi";
            this.btnsayi.Size = new System.Drawing.Size(75, 23);
            this.btnsayi.TabIndex = 2;
            this.btnsayi.Text = "Sayı Oluştur";
            this.btnsayi.UseVisualStyleBackColor = true;
            this.btnsayi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncopy
            // 
            this.btncopy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncopy.Location = new System.Drawing.Point(240, 171);
            this.btncopy.Name = "btncopy";
            this.btncopy.Size = new System.Drawing.Size(75, 23);
            this.btncopy.TabIndex = 3;
            this.btncopy.Text = "Kopyala";
            this.btncopy.UseVisualStyleBackColor = true;
            this.btncopy.Click += new System.EventHandler(this.btncopy_Click);
            // 
            // lstbcopy
            // 
            this.lstbcopy.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstbcopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbcopy.FormattingEnabled = true;
            this.lstbcopy.Location = new System.Drawing.Point(321, 99);
            this.lstbcopy.Name = "lstbcopy";
            this.lstbcopy.Size = new System.Drawing.Size(120, 171);
            this.lstbcopy.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dizinin Eleman Sayısını Giriniz";
            // 
            // txtbeleman
            // 
            this.txtbeleman.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtbeleman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbeleman.Location = new System.Drawing.Point(232, 29);
            this.txtbeleman.Name = "txtbeleman";
            this.txtbeleman.Size = new System.Drawing.Size(52, 20);
            this.txtbeleman.TabIndex = 6;
            // 
            // btnbasla
            // 
            this.btnbasla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnbasla.Location = new System.Drawing.Point(312, 25);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(75, 23);
            this.btnbasla.TabIndex = 7;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = false;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Location = new System.Drawing.Point(521, 74);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(0, 13);
            this.lblmax.TabIndex = 8;
            // 
            // lblrank
            // 
            this.lblrank.AutoSize = true;
            this.lblrank.Location = new System.Drawing.Point(521, 112);
            this.lblrank.Name = "lblrank";
            this.lblrank.Size = new System.Drawing.Size(0, 13);
            this.lblrank.TabIndex = 9;
            // 
            // lblenght
            // 
            this.lblenght.AutoSize = true;
            this.lblenght.Location = new System.Drawing.Point(521, 143);
            this.lblenght.Name = "lblenght";
            this.lblenght.Size = new System.Drawing.Size(0, 13);
            this.lblenght.TabIndex = 10;
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Location = new System.Drawing.Point(521, 171);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(0, 13);
            this.lblmin.TabIndex = 11;
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.Location = new System.Drawing.Point(521, 203);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(0, 13);
            this.lblsum.TabIndex = 12;
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Location = new System.Drawing.Point(521, 230);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(0, 13);
            this.lblaverage.TabIndex = 13;
            // 
            // lblfırst
            // 
            this.lblfırst.AutoSize = true;
            this.lblfırst.Location = new System.Drawing.Point(521, 257);
            this.lblfırst.Name = "lblfırst";
            this.lblfırst.Size = new System.Drawing.Size(0, 13);
            this.lblfırst.TabIndex = 14;
            // 
            // lblast
            // 
            this.lblast.AutoSize = true;
            this.lblast.Location = new System.Drawing.Point(521, 282);
            this.lblast.Name = "lblast";
            this.lblast.Size = new System.Drawing.Size(0, 13);
            this.lblast.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dizi Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dizi Rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dizi Lenght";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Dizi Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dizi Sum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dizi Average";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Dizi Fırst";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dizi Last";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 350);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblast);
            this.Controls.Add(this.lblfırst);
            this.Controls.Add(this.lblaverage);
            this.Controls.Add(this.lblsum);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblenght);
            this.Controls.Add(this.lblrank);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.txtbeleman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbcopy);
            this.Controls.Add(this.btncopy);
            this.Controls.Add(this.btnsayi);
            this.Controls.Add(this.lstolustur);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstolustur;
        private System.Windows.Forms.Button btnsayi;
        private System.Windows.Forms.Button btncopy;
        private System.Windows.Forms.ListBox lstbcopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbeleman;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label lblrank;
        private System.Windows.Forms.Label lblenght;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Label lblfırst;
        private System.Windows.Forms.Label lblast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}