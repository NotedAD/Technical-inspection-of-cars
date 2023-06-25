namespace Техничесикй_осмотр_автомобилей.Forms
{
    partial class TechinspectionForm
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
            this.label31 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.timeSpendingTxt = new System.Windows.Forms.TextBox();
            this.CostTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.White;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(12, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(160, 21);
            this.label31.TabIndex = 49;
            this.label31.Text = "Время проведения";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.White;
            this.label45.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label45.Location = new System.Drawing.Point(12, 60);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(49, 21);
            this.label45.TabIndex = 46;
            this.label45.Text = "Цена";
            // 
            // timeSpendingTxt
            // 
            this.timeSpendingTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeSpendingTxt.Location = new System.Drawing.Point(178, 12);
            this.timeSpendingTxt.Name = "timeSpendingTxt";
            this.timeSpendingTxt.Size = new System.Drawing.Size(172, 29);
            this.timeSpendingTxt.TabIndex = 50;
            // 
            // CostTxt
            // 
            this.CostTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostTxt.Location = new System.Drawing.Point(75, 56);
            this.CostTxt.Name = "CostTxt";
            this.CostTxt.Size = new System.Drawing.Size(275, 29);
            this.CostTxt.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(63, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 48);
            this.button1.TabIndex = 52;
            this.button1.Text = "Отправить на тех. осмотр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TechinspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Техничесикй_осмотр_автомобилей.Properties.Resources._1619668935_11_phonoteka_org_p_smeshariki_zadnii_fon_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CostTxt);
            this.Controls.Add(this.timeSpendingTxt);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label45);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TechinspectionForm";
            this.Text = "Технический осмотр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox timeSpendingTxt;
        private System.Windows.Forms.TextBox CostTxt;
        private System.Windows.Forms.Button button1;
    }
}