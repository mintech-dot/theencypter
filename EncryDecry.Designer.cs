namespace EncryptionDecryption
{
    partial class EncryDecry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.valuetxt = new System.Windows.Forms.TextBox();
            this.encrypttxt = new System.Windows.Forms.TextBox();
            this.decrypttxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.aboutinfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aboutinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // valuetxt
            // 
            this.valuetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuetxt.Location = new System.Drawing.Point(158, 69);
            this.valuetxt.Multiline = true;
            this.valuetxt.Name = "valuetxt";
            this.valuetxt.Size = new System.Drawing.Size(265, 29);
            this.valuetxt.TabIndex = 0;
            // 
            // encrypttxt
            // 
            this.encrypttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypttxt.Location = new System.Drawing.Point(158, 121);
            this.encrypttxt.Multiline = true;
            this.encrypttxt.Name = "encrypttxt";
            this.encrypttxt.Size = new System.Drawing.Size(265, 29);
            this.encrypttxt.TabIndex = 1;
            // 
            // decrypttxt
            // 
            this.decrypttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrypttxt.Location = new System.Drawing.Point(158, 171);
            this.decrypttxt.Multiline = true;
            this.decrypttxt.Name = "decrypttxt";
            this.decrypttxt.Size = new System.Drawing.Size(265, 29);
            this.decrypttxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Value :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypt :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decrypt :";
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.ForeColor = System.Drawing.Color.White;
            this.Encrypt.Location = new System.Drawing.Point(79, 225);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(105, 33);
            this.Encrypt.TabIndex = 6;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.Color.White;
            this.Decrypt.Location = new System.Drawing.Point(273, 225);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(105, 33);
            this.Decrypt.TabIndex = 7;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // aboutinfo
            // 
            this.aboutinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutinfo.Image = ((System.Drawing.Image)(resources.GetObject("aboutinfo.Image")));
            this.aboutinfo.Location = new System.Drawing.Point(-10, 248);
            this.aboutinfo.Name = "aboutinfo";
            this.aboutinfo.Size = new System.Drawing.Size(63, 32);
            this.aboutinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aboutinfo.TabIndex = 16;
            this.aboutinfo.TabStop = false;
            this.aboutinfo.Click += new System.EventHandler(this.aboutinfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 281);
            this.Controls.Add(this.aboutinfo);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decrypttxt);
            this.Controls.Add(this.encrypttxt);
            this.Controls.Add(this.valuetxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "The Encrypter";
            ((System.ComponentModel.ISupportInitialize)(this.aboutinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valuetxt;
        private System.Windows.Forms.TextBox encrypttxt;
        private System.Windows.Forms.TextBox decrypttxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.PictureBox aboutinfo;
    }
}

