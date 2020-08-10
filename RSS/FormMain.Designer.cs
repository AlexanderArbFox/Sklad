namespace RSS
{
    partial class FormMain
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
            this.btnTaken = new System.Windows.Forms.Button();
            this.btnSklads = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMiniClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaken
            // 
            this.btnTaken.BackColor = System.Drawing.Color.Chocolate;
            this.btnTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTaken.Location = new System.Drawing.Point(64, 38);
            this.btnTaken.Name = "btnTaken";
            this.btnTaken.Size = new System.Drawing.Size(197, 129);
            this.btnTaken.TabIndex = 0;
            this.btnTaken.Text = "Принят";
            this.btnTaken.UseVisualStyleBackColor = false;
            this.btnTaken.Click += new System.EventHandler(this.btnTaken_Click);
            // 
            // btnSklads
            // 
            this.btnSklads.BackColor = System.Drawing.Color.Chocolate;
            this.btnSklads.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSklads.Location = new System.Drawing.Point(276, 38);
            this.btnSklads.Name = "btnSklads";
            this.btnSklads.Size = new System.Drawing.Size(197, 129);
            this.btnSklads.TabIndex = 1;
            this.btnSklads.Text = "Склад";
            this.btnSklads.UseVisualStyleBackColor = false;
            this.btnSklads.Click += new System.EventHandler(this.btnSklads_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.Chocolate;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(64, 199);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(197, 129);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Продан";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Chocolate;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReport.Location = new System.Drawing.Point(276, 199);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(197, 129);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Отчет";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Chocolate;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(269, 509);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(251, 54);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMiniClose
            // 
            this.btnMiniClose.BackColor = System.Drawing.Color.Chocolate;
            this.btnMiniClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMiniClose.Location = new System.Drawing.Point(12, 509);
            this.btnMiniClose.Name = "btnMiniClose";
            this.btnMiniClose.Size = new System.Drawing.Size(251, 54);
            this.btnMiniClose.TabIndex = 5;
            this.btnMiniClose.Text = "Свернуть";
            this.btnMiniClose.UseVisualStyleBackColor = false;
            this.btnMiniClose.Click += new System.EventHandler(this.btnMiniClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 575);
            this.Controls.Add(this.btnMiniClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.btnSklads);
            this.Controls.Add(this.btnTaken);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormMain";
            this.Text = "Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaken;
        private System.Windows.Forms.Button btnSklads;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMiniClose;
    }
}

