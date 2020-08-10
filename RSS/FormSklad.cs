using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSS
{
    public partial class FormSklad : Form
    {
        public FormSklad()
        {
            InitializeComponent();
            DbSclad();
        }

        private void FormSklad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rssDbNewDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.rssDbNewDataSet.Товары);
           
        }

        private void dgvSklad_CellClick(object sender, MouseEventArgs fdf) 
        {
            int row = dgvSklad.SelectedRows[0].Index;
            
            FormSaleElement formSale = new FormSaleElement();
            if (fdf.Button == MouseButtons.Right)
            {
                formSale.ShowDialog();
            }
        }
        dynamic ExetQuerySklad(Context db)// Выбор полей из таблицы
        {
            return db.Статусы_товаров.Where(s => s.Статусы.Наименование_статуса == "На складе").Select(s => new
            {
                s.Товары.Id_товар,
                s.Товары.Наименование,
                s.Товары.Количество,
                s.Товары.Стоимость,
                s.Статусы.Наименование_статуса,
                s.Дата_изменения
            }).ToList();
        }
        private void DbSclad()
        {
            using (Context db = new Context())
            {

                dgvSklad.DataSource = ExetQuerySklad(db);
            }
        }

        private void dgvSklad_MouseDown(object sender, MouseEventArgs e) // настройка кнопки мыши (правая)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuRightMouse.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
           
        }

        private void MenuSell_Click(object sender, EventArgs e) // открытие формы 
        {
            FormSaleElement formSale = new FormSaleElement();
            formSale.ShowDialog();
        }

        private void dgvSklad_CellClick(object sender, DataGridViewCellEventArgs e) // передача данных на другую форму
        {
            int row = dgvSklad.SelectedRows[0].Index;
            ClassCurrent.Id = (int)dgvSklad[0, row].Value;
            ClassCurrent.kolvo = (int)dgvSklad[2, row].Value;
            ClassCurrent.stoimost = (decimal)dgvSklad[3, row].Value;
        }
    }
}
