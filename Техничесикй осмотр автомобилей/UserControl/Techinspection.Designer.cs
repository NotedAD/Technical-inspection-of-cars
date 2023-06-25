
namespace Техничесикй_осмотр_автомобилей
{
    partial class Techinspection
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameEmployeeLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.timeSpendingLbl = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время проведения";
            // 
            // surnameEmployeeLbl
            // 
            this.surnameEmployeeLbl.AutoSize = true;
            this.surnameEmployeeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameEmployeeLbl.Location = new System.Drawing.Point(157, 10);
            this.surnameEmployeeLbl.Name = "surnameEmployeeLbl";
            this.surnameEmployeeLbl.Size = new System.Drawing.Size(130, 19);
            this.surnameEmployeeLbl.TabIndex = 5;
            this.surnameEmployeeLbl.Text = "Фамилия клиента";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLbl.Location = new System.Drawing.Point(157, 38);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(130, 19);
            this.costLbl.TabIndex = 6;
            this.costLbl.Text = "Фамилия клиента";
            // 
            // timeSpendingLbl
            // 
            this.timeSpendingLbl.AutoSize = true;
            this.timeSpendingLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeSpendingLbl.Location = new System.Drawing.Point(157, 68);
            this.timeSpendingLbl.Name = "timeSpendingLbl";
            this.timeSpendingLbl.Size = new System.Drawing.Size(130, 19);
            this.timeSpendingLbl.TabIndex = 7;
            this.timeSpendingLbl.Text = "Фамилия клиента";
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBtn.Location = new System.Drawing.Point(90, 111);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(197, 29);
            this.checkBtn.TabIndex = 8;
            this.checkBtn.Text = "Просмотреть";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // Techinspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.timeSpendingLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.surnameEmployeeLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Techinspection";
            this.Size = new System.Drawing.Size(362, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label surnameEmployeeLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label timeSpendingLbl;
        private System.Windows.Forms.Button checkBtn;
    }
}
