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
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
            DataDb();
        }

        dynamic ExetQuerySale(Context db) // выбор полей из бд
        {
            return db.Статусы_товаров.Where(s => s.Статусы.Наименование_статуса == "Продан").Select(s => new
            {
                s.Товары.Id_товар,
                s.Товары.Наименование,
                s.Товары.Количество,
                s.Товары.Стоимость,
                s.Статусы.Наименование_статуса,
                s.Дата_изменения
            }).ToList();
        }
        private void DataDb() // подгрузка в таблицу бд
        {
            using (Context db = new Context())
            {
                dgvSale.DataSource = ExetQuerySale(db);
            }
        }
    }
}
