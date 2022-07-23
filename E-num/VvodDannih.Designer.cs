
namespace E_num
{
    partial class VvodDannih
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
            this.labelNameOrIP = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelPasswordUser = new System.Windows.Forms.Label();
            this.vvodNameOrIP = new System.Windows.Forms.TextBox();
            this.vvodNameUser = new System.Windows.Forms.TextBox();
            this.vvodPasswordUser = new System.Windows.Forms.TextBox();
            this.buttonOtpravkiDannih = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameOrIP
            // 
            this.labelNameOrIP.AutoSize = true;
            this.labelNameOrIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOrIP.Location = new System.Drawing.Point(14, 15);
            this.labelNameOrIP.Name = "labelNameOrIP";
            this.labelNameOrIP.Size = new System.Drawing.Size(145, 18);
            this.labelNameOrIP.TabIndex = 0;
            this.labelNameOrIP.Text = "Имя/IP компьютера";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameUser.Location = new System.Drawing.Point(18, 45);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(141, 18);
            this.labelNameUser.TabIndex = 1;
            this.labelNameUser.Text = "Имя пользователя";
            // 
            // labelPasswordUser
            // 
            this.labelPasswordUser.AutoSize = true;
            this.labelPasswordUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordUser.Location = new System.Drawing.Point(98, 75);
            this.labelPasswordUser.Name = "labelPasswordUser";
            this.labelPasswordUser.Size = new System.Drawing.Size(61, 18);
            this.labelPasswordUser.TabIndex = 2;
            this.labelPasswordUser.Text = "Пароль";
            // 
            // vvodNameOrIP
            // 
            this.vvodNameOrIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vvodNameOrIP.Location = new System.Drawing.Point(165, 12);
            this.vvodNameOrIP.Name = "vvodNameOrIP";
            this.vvodNameOrIP.Size = new System.Drawing.Size(200, 24);
            this.vvodNameOrIP.TabIndex = 3;
            this.vvodNameOrIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vvodNameOrIP_KeyDown);
            // 
            // vvodNameUser
            // 
            this.vvodNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vvodNameUser.Location = new System.Drawing.Point(165, 42);
            this.vvodNameUser.Name = "vvodNameUser";
            this.vvodNameUser.Size = new System.Drawing.Size(200, 24);
            this.vvodNameUser.TabIndex = 4;
            this.vvodNameUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vvodNameUser_KeyDown);
            // 
            // vvodPasswordUser
            // 
            this.vvodPasswordUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vvodPasswordUser.Location = new System.Drawing.Point(165, 72);
            this.vvodPasswordUser.Name = "vvodPasswordUser";
            this.vvodPasswordUser.Size = new System.Drawing.Size(200, 24);
            this.vvodPasswordUser.TabIndex = 5;
            this.vvodPasswordUser.UseSystemPasswordChar = true;
            this.vvodPasswordUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vvodPasswordUser_KeyDown);
            // 
            // buttonOtpravkiDannih
            // 
            this.buttonOtpravkiDannih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtpravkiDannih.Location = new System.Drawing.Point(165, 115);
            this.buttonOtpravkiDannih.Name = "buttonOtpravkiDannih";
            this.buttonOtpravkiDannih.Size = new System.Drawing.Size(100, 35);
            this.buttonOtpravkiDannih.TabIndex = 6;
            this.buttonOtpravkiDannih.Text = "Отправить";
            this.buttonOtpravkiDannih.UseVisualStyleBackColor = true;
            this.buttonOtpravkiDannih.Click += new System.EventHandler(this.buttonOtpravkiDannih_Click);
            this.buttonOtpravkiDannih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonOtpravkiDannih_KeyDown);
            // 
            // VvodDannih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 164);
            this.Controls.Add(this.buttonOtpravkiDannih);
            this.Controls.Add(this.vvodPasswordUser);
            this.Controls.Add(this.vvodNameUser);
            this.Controls.Add(this.vvodNameOrIP);
            this.Controls.Add(this.labelPasswordUser);
            this.Controls.Add(this.labelNameUser);
            this.Controls.Add(this.labelNameOrIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VvodDannih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E-num 0.0.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameOrIP;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelPasswordUser;
        private System.Windows.Forms.TextBox vvodNameOrIP;
        private System.Windows.Forms.TextBox vvodNameUser;
        private System.Windows.Forms.TextBox vvodPasswordUser;
        private System.Windows.Forms.Button buttonOtpravkiDannih;
    }
}