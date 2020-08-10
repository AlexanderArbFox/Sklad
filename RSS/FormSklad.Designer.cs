namespace RSS
{
    partial class FormSklad
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
            this.components = new System.ComponentModel.Container();
            this.dgvSklad = new System.Windows.Forms.DataGridView();
            this.idтоварDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuRightMouse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuSell = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rssDbNewDataSet = new RSS.RssDbNewDataSet();
            this.товарыTableAdapter = new RSS.RssDbNewDataSetTableAdapters.ТоварыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).BeginInit();
            this.MenuRightMouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDbNewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSklad
            // 
            this.dgvSklad.AutoGenerateColumns = false;
            this.dgvSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSklad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idтоварDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dgvSklad.ContextMenuStrip = this.MenuRightMouse;
            this.dgvSklad.DataSource = this.товарыBindingSource;
            this.dgvSklad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSklad.Location = new System.Drawing.Point(0, 0);
            this.dgvSklad.Name = "dgvSklad";
            this.dgvSklad.RowTemplate.Height = 28;
            this.dgvSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSklad.Size = new System.Drawing.Size(1565, 702);
            this.dgvSklad.TabIndex = 0;
            this.dgvSklad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSklad_CellClick);
            this.dgvSklad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSklad_MouseDown);
            // 
            // idтоварDataGridViewTextBoxColumn
            // 
            this.idтоварDataGridViewTextBoxColumn.DataPropertyName = "Id_товар";
            this.idтоварDataGridViewTextBoxColumn.HeaderText = "Id_товар";
            this.idтоварDataGridViewTextBoxColumn.Name = "idтоварDataGridViewTextBoxColumn";
            this.idтоварDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // MenuRightMouse
            // 
            this.MenuRightMouse.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuRightMouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSell});
            this.MenuRightMouse.Name = "MenuRightMouse";
            this.MenuRightMouse.Size = new System.Drawing.Size(155, 34);
            // 
            // MenuSell
            // 
            this.MenuSell.Name = "MenuSell";
            this.MenuSell.Size = new System.Drawing.Size(154, 30);
            this.MenuSell.Text = "Продать";
            this.MenuSell.Click += new System.EventHandler(this.MenuSell_Click);
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.rssDbNewDataSet;
            // 
            // rssDbNewDataSet
            // 
            this.rssDbNewDataSet.DataSetName = "RssDbNewDataSet";
            this.rssDbNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // FormSklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1565, 702);
            this.Controls.Add(this.dgvSklad);
            this.Name = "FormSklad";
            this.Text = "Склад";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSklad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).EndInit();
            this.MenuRightMouse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rssDbNewDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSklad;
        private RssDbNewDataSet rssDbNewDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private RssDbNewDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idтоварDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip MenuRightMouse;
        private System.Windows.Forms.ToolStripMenuItem MenuSell;
    }
}