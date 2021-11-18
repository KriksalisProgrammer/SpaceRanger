namespace Galactic.VIew
{
    partial class GalacticShop
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
            this.labelMoney = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.formComponent1 = new Galactic.VIew.FormComponent();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Криптовалюта:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("PMingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.Location = new System.Drawing.Point(139, 9);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(20, 21);
            this.labelMoney.TabIndex = 1;
            this.labelMoney.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.formComponent1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1063, 645);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // formComponent1
            // 
            this.formComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formComponent1.Location = new System.Drawing.Point(3, 3);
            this.formComponent1.Name = "formComponent1";
            this.formComponent1.Size = new System.Drawing.Size(194, 296);
            this.formComponent1.TabIndex = 0;
            // 
            // GalacticShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 702);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.label1);
            this.Name = "GalacticShop";
            this.Text = "GalacticShop";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FormComponent formComponent1;
    }
}