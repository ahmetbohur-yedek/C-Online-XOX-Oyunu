namespace TicTacToe_Online_Server___UrhobA
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
            this.hostIP = new System.Windows.Forms.TextBox();
            this.hostPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ciktilar = new System.Windows.Forms.RichTextBox();
            this.baslat_durdur_button = new System.Windows.Forms.Button();
            this.urhoba = new System.Windows.Forms.Button();
            this.clientler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // hostIP
            // 
            this.hostIP.Location = new System.Drawing.Point(85, 9);
            this.hostIP.Name = "hostIP";
            this.hostIP.Size = new System.Drawing.Size(163, 22);
            this.hostIP.TabIndex = 0;
            this.hostIP.Text = "127.0.0.1";
            // 
            // hostPort
            // 
            this.hostPort.Location = new System.Drawing.Point(85, 36);
            this.hostPort.Name = "hostPort";
            this.hostPort.Size = new System.Drawing.Size(163, 22);
            this.hostPort.TabIndex = 1;
            this.hostPort.Text = "8910";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.MaximumSize = new System.Drawing.Size(67, 17);
            this.label2.MinimumSize = new System.Drawing.Size(67, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Host Port";
            // 
            // ciktilar
            // 
            this.ciktilar.Location = new System.Drawing.Point(15, 64);
            this.ciktilar.Name = "ciktilar";
            this.ciktilar.Size = new System.Drawing.Size(513, 374);
            this.ciktilar.TabIndex = 4;
            this.ciktilar.Text = "";
            // 
            // baslat_durdur_button
            // 
            this.baslat_durdur_button.Location = new System.Drawing.Point(264, 8);
            this.baslat_durdur_button.Name = "baslat_durdur_button";
            this.baslat_durdur_button.Size = new System.Drawing.Size(129, 50);
            this.baslat_durdur_button.TabIndex = 5;
            this.baslat_durdur_button.Text = "Başlat";
            this.baslat_durdur_button.UseVisualStyleBackColor = true;
            this.baslat_durdur_button.Click += new System.EventHandler(this.baslat_durdur_button_Click);
            // 
            // urhoba
            // 
            this.urhoba.Location = new System.Drawing.Point(399, 8);
            this.urhoba.Name = "urhoba";
            this.urhoba.Size = new System.Drawing.Size(129, 50);
            this.urhoba.TabIndex = 6;
            this.urhoba.Text = "UrhobA";
            this.urhoba.UseVisualStyleBackColor = true;
            this.urhoba.Click += new System.EventHandler(this.urhoba_Click);
            // 
            // clientler
            // 
            this.clientler.FormattingEnabled = true;
            this.clientler.ItemHeight = 16;
            this.clientler.Location = new System.Drawing.Point(536, 18);
            this.clientler.Name = "clientler";
            this.clientler.Size = new System.Drawing.Size(278, 420);
            this.clientler.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.ControlBox = false;
            this.Controls.Add(this.clientler);
            this.Controls.Add(this.urhoba);
            this.Controls.Add(this.baslat_durdur_button);
            this.Controls.Add(this.ciktilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostPort);
            this.Controls.Add(this.hostIP);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(843, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(843, 497);
            this.Name = "Form1";
            this.Text = "TicTacToe Server - UrhobA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hostIP;
        private System.Windows.Forms.TextBox hostPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ciktilar;
        private System.Windows.Forms.Button baslat_durdur_button;
        private System.Windows.Forms.Button urhoba;
        private System.Windows.Forms.ListBox clientler;
    }
}

