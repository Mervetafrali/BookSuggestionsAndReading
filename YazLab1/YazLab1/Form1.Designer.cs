namespace YazLab1
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
            this.user12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.enterbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newuserbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user12
            // 
            this.user12.AutoSize = true;
            this.user12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user12.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user12.Location = new System.Drawing.Point(91, 312);
            this.user12.Name = "user12";
            this.user12.Size = new System.Drawing.Size(194, 49);
            this.user12.TabIndex = 1;
            this.user12.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(91, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usertxt.Location = new System.Drawing.Point(326, 312);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(223, 45);
            this.usertxt.TabIndex = 3;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordtxt.Location = new System.Drawing.Point(326, 397);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(223, 45);
            this.passwordtxt.TabIndex = 4;
            // 
            // enterbtn
            // 
            this.enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enterbtn.Location = new System.Drawing.Point(603, 381);
            this.enterbtn.Name = "enterbtn";
            this.enterbtn.Size = new System.Drawing.Size(155, 62);
            this.enterbtn.TabIndex = 5;
            this.enterbtn.Text = "Enter";
            this.enterbtn.UseVisualStyleBackColor = true;
            this.enterbtn.Click += new System.EventHandler(this.enterbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Do not have a account?";
            // 
            // newuserbtn
            // 
            this.newuserbtn.Location = new System.Drawing.Point(117, 552);
            this.newuserbtn.Name = "newuserbtn";
            this.newuserbtn.Size = new System.Drawing.Size(94, 23);
            this.newuserbtn.TabIndex = 7;
            this.newuserbtn.Text = "New User";
            this.newuserbtn.UseVisualStyleBackColor = true;
            this.newuserbtn.Click += new System.EventHandler(this.newuserbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::YazLab1.Properties.Resources.Webp_net_resizeimage;
            this.ClientSize = new System.Drawing.Size(858, 652);
            this.Controls.Add(this.newuserbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user12);
            this.Name = "Form1";
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button enterbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newuserbtn;
    }
}

