namespace Galactic.VIew
{
    partial class FormComponent
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameComponent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelLavel = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonUpgrate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameComponent
            // 
            this.labelNameComponent.AutoSize = true;
            this.labelNameComponent.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameComponent.Location = new System.Drawing.Point(4, 182);
            this.labelNameComponent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameComponent.Name = "labelNameComponent";
            this.labelNameComponent.Size = new System.Drawing.Size(106, 28);
            this.labelNameComponent.TabIndex = 0;
            this.labelNameComponent.Text = "Компонент";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelLavel
            // 
            this.labelLavel.AutoSize = true;
            this.labelLavel.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLavel.Location = new System.Drawing.Point(83, 223);
            this.labelLavel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLavel.Name = "labelLavel";
            this.labelLavel.Size = new System.Drawing.Size(23, 28);
            this.labelLavel.TabIndex = 3;
            this.labelLavel.Text = "0";
            this.labelLavel.Click += new System.EventHandler(this.labelLavel_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBuy.Location = new System.Drawing.Point(4, 254);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(222, 43);
            this.buttonBuy.TabIndex = 4;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonUpgrate
            // 
            this.buttonUpgrate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonUpgrate.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpgrate.Location = new System.Drawing.Point(0, 300);
            this.buttonUpgrate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpgrate.Name = "buttonUpgrate";
            this.buttonUpgrate.Size = new System.Drawing.Size(229, 42);
            this.buttonUpgrate.TabIndex = 5;
            this.buttonUpgrate.Text = "Улучшить";
            this.buttonUpgrate.UseVisualStyleBackColor = true;
            this.buttonUpgrate.Click += new System.EventHandler(this.buttonUpgrate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Уровень:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Sitka Heading", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(169, 182);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 28);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Цена";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // FormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpgrate);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.labelLavel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNameComponent);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormComponent";
            this.Size = new System.Drawing.Size(229, 342);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameComponent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelLavel;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonUpgrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrice;
    }
}
