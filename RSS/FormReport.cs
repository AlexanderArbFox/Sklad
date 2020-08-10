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
    public partial class FormReport : Form
    {
        int sum;
        public FormReport()
        {
            InitializeComponent();
            cmbSelect.SelectedIndex = 0; // выбирает первый элемент из combobox
        }

        #region Выбор полей из таблицы
        public dynamic ExetQueryAll( Context db)
        {
            return db.Статусы_товаров.Select(s => new
            {
                s.Товары.Id_товар,
                s.Товары.Наименование, 
                s.Товары.Количество,
                s.Товары.Стоимость,
                s.Статусы.Наименование_статуса,
                s.Дата_изменения
            }).ToList();
           
        }

        dynamic ExetQueryTaken(Context db) 
        {
            return db.Статусы_товаров.Where(s => s.Статусы.Наименование_статуса == "Принят").Select(s => new
            {
                id = s.Товары.Id_товар,
                Название = s.Товары.Наименование,
                Количество = s.Товары.Количество,
                Стоимость = s.Товары.Стоимость,
                Статус = s.Статусы.Наименование_статуса,
                Дата_Статуса = s.Дата_изменения
            }).ToList();
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

        dynamic ExetQuerySale(Context db)// Выбор полей из таблицы
        {
            return db.Статусы_товаров.Where(s => s.Статусы.Наименование_статуса == "Продан").Select(s => new
            {
                id = s.Товары.Id_товар,
                Название = s.Товары.Наименование,
                Количество = s.Товары.Количество,
                Стоимость = s.Товары.Стоимость,
                Статус = s.Статусы.Наименование_статуса,
                Дата_Статуса = s.Дата_изменения
            }).ToList();
        }

        #endregion

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e) // Выбор подгрузки необходимой таблицы
        {
            using (Context db = new Context())
            {
                switch (cmbSelect.SelectedIndex)
                {
                    case 0:dgvReport.DataSource = ExetQueryAll(db);
                        break;

                    case 1:
                        dgvReport.DataSource = ExetQueryTaken(db);
                        break;
                    case 2:
                        dgvReport.DataSource = ExetQuerySklad(db);
                        break;
                    case 3:
                        dgvReport.DataSource = ExetQuerySale(db);
                        break;
                }
                SumTovars();
            }
        }
        private void SumTovars() // подсчет суммы в столбце стоимость
        {
            sum = 0;
            for (int i = 0; i<dgvReport.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvReport.Rows[i].Cells[3].Value);
            }
            lbSum.Text = "Сумма товаров составляет: " + sum.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e) // Поиск по дате в таблице
        {
            for (int i = 0; i < dgvReport.Rows.Count; i++)
            {
                if (Convert.ToDateTime(dgvReport.Rows[i].Cells[5].Value) >= dtpOt.Value && Convert.ToDateTime(dgvReport.Rows[i].Cells[5].Value) <= dtpDo.Value)
                {
                    dgvReport.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }
    }
}
