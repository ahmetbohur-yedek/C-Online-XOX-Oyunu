namespace TicTacToe_Online_Client___UrhobA
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.urhoba = new System.Windows.Forms.Button();
            this.baglan_button = new System.Windows.Forms.Button();
            this.ciktilar = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.hostIP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urhoba
            // 
            this.urhoba.Location = new System.Drawing.Point(413, 8);
            this.urhoba.Name = "urhoba";
            this.urhoba.Size = new System.Drawing.Size(129, 50);
            this.urhoba.TabIndex = 13;
            this.urhoba.Text = "UrhobA";
            this.urhoba.UseVisualStyleBackColor = true;
            this.urhoba.Click += new System.EventHandler(this.urhoba_Click);
            // 
            // baglan_button
            // 
            this.baglan_button.Location = new System.Drawing.Point(278, 8);
            this.baglan_button.Name = "baglan_button";
            this.baglan_button.Size = new System.Drawing.Size(129, 50);
            this.baglan_button.TabIndex = 12;
            this.baglan_button.Text = "Bağlan";
            this.baglan_button.UseVisualStyleBackColor = true;
            this.baglan_button.Click += new System.EventHandler(this.baslat_durdur_button_Click);
            // 
            // ciktilar
            // 
            this.ciktilar.Location = new System.Drawing.Point(12, 389);
            this.ciktilar.Name = "ciktilar";
            this.ciktilar.Size = new System.Drawing.Size(530, 132);
            this.ciktilar.TabIndex = 11;
            this.ciktilar.Text = "";
            this.ciktilar.TextChanged += new System.EventHandler(this.ciktilar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.MaximumSize = new System.Drawing.Size(67, 17);
            this.label2.MinimumSize = new System.Drawing.Size(67, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Host Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Host IP";
            // 
            // hostPort
            // 
            this.hostPort.Location = new System.Drawing.Point(99, 36);
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(163, 22);
            this.hostPort.TabIndex = 8;
            this.hostPort.Text = "8910";
            // 
            // hostIP
            // 
            this.hostIP.Location = new System.Drawing.Point(99, 9);
            this.hostIP.Name = "hostIP";
            this.hostIP.Size = new System.Drawing.Size(163, 22);
            this.hostIP.TabIndex = 7;
            this.hostIP.Text = "127.0.0.1";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(139, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 85);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(225, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 85);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(311, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 85);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(139, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 85);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(225, 193);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 85);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(311, 193);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 85);
            this.button6.TabIndex = 22;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(139, 284);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 85);
            this.button7.TabIndex = 23;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(225, 284);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 85);
            this.button8.TabIndex = 24;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(311, 284);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 85);
            this.button9.TabIndex = 25;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 533);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urhoba);
            this.Controls.Add(this.baglan_button);
            this.Controls.Add(this.ciktilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostPort);
            this.Controls.Add(this.hostIP);
            this.MaximumSize = new System.Drawing.Size(571, 580);
            this.MinimumSize = new System.Drawing.Size(571, 580);
            this.Name = "Form1";
            this.Text = "TicTacToe Client - UrhobA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urhoba;
        private System.Windows.Forms.Button baglan_button;
        private System.Windows.Forms.RichTextBox ciktilar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostPort;
        private System.Windows.Forms.TextBox hostIP;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
    }
}

