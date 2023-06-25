namespace Техничесикй_осмотр_автомобилей.Forms
{
    partial class EditTechinspectionForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.CostTxt = new System.Windows.Forms.TextBox();
            this.timeSpendingTxt = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(59, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 48);
            this.button1.TabIndex = 57;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CostTxt
            // 
            this.CostTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostTxt.Location = new System.Drawing.Point(71, 55);
            this.CostTxt.Name = "CostTxt";
            this.CostTxt.Size = new System.Drawing.Size(275, 29);
            this.CostTxt.TabIndex = 56;
            // 
            // timeSpendingTxt
            // 
            this.timeSpendingTxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeSpendingTxt.Location = new System.Drawing.Point(174, 11);
            this.timeSpendingTxt.Name = "timeSpendingTxt";
            this.timeSpendingTxt.Size = new System.Drawing.Size(172, 29);
            this.timeSpendingTxt.TabIndex = 55;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.White;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(8, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(160, 21);
            this.label31.TabIndex = 54;
            this.label31.Text = "Время проведения";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.White;
            this.label45.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label45.Location = new System.Drawing.Point(8, 59);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(49, 21);
            this.label45.TabIndex = 53;
            this.label45.Text = "Цена";
            // 
            // EditTechinspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Техничесикй_осмотр_автомобилей.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 194);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CostTxt);
            this.Controls.Add(this.timeSpendingTxt);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label45);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditTechinspectionForm";
            this.Text = "Редактирование тех. осмотра";
            this.Load += new System.EventHandler(this.EditTechinspectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CostTxt;
        private System.Windows.Forms.TextBox timeSpendingTxt;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label45;
    }
}