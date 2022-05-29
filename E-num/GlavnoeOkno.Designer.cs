
namespace E_num_0._0._3
{
    partial class GlavnoeOkno
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEtotKomputer = new System.Windows.Forms.Button();
            this.buttonKomputerVseti = new System.Windows.Forms.Button();
            this.poleVivodaDannih = new System.Windows.Forms.TextBox();
            this.buttonChistka = new System.Windows.Forms.Button();
            this.buttonSohranit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEtotKomputer
            // 
            this.buttonEtotKomputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEtotKomputer.Location = new System.Drawing.Point(13, 12);
            this.buttonEtotKomputer.Name = "buttonEtotKomputer";
            this.buttonEtotKomputer.Size = new System.Drawing.Size(245, 35);
            this.buttonEtotKomputer.TabIndex = 0;
            this.buttonEtotKomputer.Text = "Этот компьютер";
            this.buttonEtotKomputer.UseVisualStyleBackColor = true;
            this.buttonEtotKomputer.Click += new System.EventHandler(this.buttonEtotKomputer_Click);
            // 
            // buttonKomputerVseti
            // 
            this.buttonKomputerVseti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKomputerVseti.Location = new System.Drawing.Point(264, 12);
            this.buttonKomputerVseti.Name = "buttonKomputerVseti";
            this.buttonKomputerVseti.Size = new System.Drawing.Size(245, 35);
            this.buttonKomputerVseti.TabIndex = 1;
            this.buttonKomputerVseti.Text = "Компьютер в сети";
            this.buttonKomputerVseti.UseVisualStyleBackColor = true;
            this.buttonKomputerVseti.Click += new System.EventHandler(this.buttonKomputerVseti_Click);
            // 
            // poleVivodaDannih
            // 
            this.poleVivodaDannih.BackColor = System.Drawing.Color.Black;
            this.poleVivodaDannih.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poleVivodaDannih.ForeColor = System.Drawing.Color.LightGray;
            this.poleVivodaDannih.Location = new System.Drawing.Point(13, 62);
            this.poleVivodaDannih.Multiline = true;
            this.poleVivodaDannih.Name = "poleVivodaDannih";
            this.poleVivodaDannih.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.poleVivodaDannih.Size = new System.Drawing.Size(775, 375);
            this.poleVivodaDannih.TabIndex = 2;
            this.poleVivodaDannih.Text = "Выберите действие...";
            // 
            // buttonChistka
            // 
            this.buttonChistka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChistka.Location = new System.Drawing.Point(553, 12);
            this.buttonChistka.Name = "buttonChistka";
            this.buttonChistka.Size = new System.Drawing.Size(100, 35);
            this.buttonChistka.TabIndex = 3;
            this.buttonChistka.Text = "Очистить";
            this.buttonChistka.UseVisualStyleBackColor = true;
            this.buttonChistka.Click += new System.EventHandler(this.buttonChistka_Click);
            // 
            // buttonSohranit
            // 
            this.buttonSohranit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSohranit.Location = new System.Drawing.Point(659, 12);
            this.buttonSohranit.Name = "buttonSohranit";
            this.buttonSohranit.Size = new System.Drawing.Size(130, 35);
            this.buttonSohranit.TabIndex = 4;
            this.buttonSohranit.Text = "Сохранить";
            this.buttonSohranit.UseVisualStyleBackColor = true;
            this.buttonSohranit.Click += new System.EventHandler(this.buttonSohranit_Click);
            // 
            // GlavnoeOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSohranit);
            this.Controls.Add(this.buttonChistka);
            this.Controls.Add(this.poleVivodaDannih);
            this.Controls.Add(this.buttonKomputerVseti);
            this.Controls.Add(this.buttonEtotKomputer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GlavnoeOkno";
            this.Text = "E-num 0.0.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEtotKomputer;
        private System.Windows.Forms.Button buttonKomputerVseti;
        private System.Windows.Forms.TextBox poleVivodaDannih;
        private System.Windows.Forms.Button buttonChistka;
        private System.Windows.Forms.Button buttonSohranit;
    }
}

