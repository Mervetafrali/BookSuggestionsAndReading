namespace YazLab1
{
    partial class NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.locationtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordnewtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newaddedtxt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.useridlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome to new world!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "User-ID";
            // 
            // locationtxt
            // 
            this.locationtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.locationtxt.Location = new System.Drawing.Point(209, 153);
            this.locationtxt.Name = "locationtxt";
            this.locationtxt.Size = new System.Drawing.Size(130, 34);
            this.locationtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location:";
            // 
            // agetxt
            // 
            this.agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.agetxt.Location = new System.Drawing.Point(209, 203);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(130, 34);
            this.agetxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age:";
            // 
            // passwordnewtxt
            // 
            this.passwordnewtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordnewtxt.Location = new System.Drawing.Point(209, 252);
            this.passwordnewtxt.Name = "passwordnewtxt";
            this.passwordnewtxt.Size = new System.Drawing.Size(130, 34);
            this.passwordnewtxt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 38);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // newaddedtxt
            // 
            this.newaddedtxt.BackColor = System.Drawing.Color.PeachPuff;
            this.newaddedtxt.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaddedtxt.Location = new System.Drawing.Point(197, 341);
            this.newaddedtxt.Name = "newaddedtxt";
            this.newaddedtxt.Size = new System.Drawing.Size(154, 47);
            this.newaddedtxt.TabIndex = 9;
            this.newaddedtxt.Text = "Entry";
            this.newaddedtxt.UseVisualStyleBackColor = false;
            this.newaddedtxt.Click += new System.EventHandler(this.newaddedtxt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YazLab1.Properties.Resources.magic_book_png_1;
            this.pictureBox1.Location = new System.Drawing.Point(446, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // useridlbl
            // 
            this.useridlbl.AutoSize = true;
            this.useridlbl.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridlbl.Location = new System.Drawing.Point(206, 91);
            this.useridlbl.Name = "useridlbl";
            this.useridlbl.Size = new System.Drawing.Size(0, 44);
            this.useridlbl.TabIndex = 11;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 517);
            this.Controls.Add(this.useridlbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newaddedtxt);
            this.Controls.Add(this.passwordnewtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.locationtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox locationtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordnewtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newaddedtxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label useridlbl;
    }
}