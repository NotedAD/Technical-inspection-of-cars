
namespace Техничесикй_осмотр_автомобилей
{
    partial class ActiveOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.modelCarLbl = new System.Windows.Forms.Label();
            this.colorCarLbl = new System.Windows.Forms.Label();
            this.typeCarLbl = new System.Windows.Forms.Label();
            this.idReq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель авто";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBtn.Location = new System.Drawing.Point(51, 114);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(116, 33);
            this.checkBtn.TabIndex = 3;
            this.checkBtn.Text = "Просмотреть";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // modelCarLbl
            // 
            this.modelCarLbl.AutoSize = true;
            this.modelCarLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelCarLbl.Location = new System.Drawing.Point(107, 18);
            this.modelCarLbl.Name = "modelCarLbl";
            this.modelCarLbl.Size = new System.Drawing.Size(95, 19);
            this.modelCarLbl.TabIndex = 4;
            this.modelCarLbl.Text = "Модель авто";
            // 
            // colorCarLbl
            // 
            this.colorCarLbl.AutoSize = true;
            this.colorCarLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorCarLbl.Location = new System.Drawing.Point(107, 50);
            this.colorCarLbl.Name = "colorCarLbl";
            this.colorCarLbl.Size = new System.Drawing.Size(95, 19);
            this.colorCarLbl.TabIndex = 5;
            this.colorCarLbl.Text = "Модель авто";
            // 
            // typeCarLbl
            // 
            this.typeCarLbl.AutoSize = true;
            this.typeCarLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCarLbl.Location = new System.Drawing.Point(107, 85);
            this.typeCarLbl.Name = "typeCarLbl";
            this.typeCarLbl.Size = new System.Drawing.Size(95, 19);
            this.typeCarLbl.TabIndex = 6;
            this.typeCarLbl.Text = "Модель авто";
            // 
            // idReq
            // 
            this.idReq.AutoSize = true;
            this.idReq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idReq.Location = new System.Drawing.Point(62, 66);
            this.idReq.Name = "idReq";
            this.idReq.Size = new System.Drawing.Size(95, 19);
            this.idReq.TabIndex = 7;
            this.idReq.Text = "Модель авто";
            this.idReq.Visible = false;
            // 
            // ActiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.Controls.Add(this.idReq);
            this.Controls.Add(this.typeCarLbl);
            this.Controls.Add(this.colorCarLbl);
            this.Controls.Add(this.modelCarLbl);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ActiveOrder";
            this.Size = new System.Drawing.Size(218, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label modelCarLbl;
        private System.Windows.Forms.Label colorCarLbl;
        private System.Windows.Forms.Label typeCarLbl;
        private System.Windows.Forms.Label idReq;
    }
}
