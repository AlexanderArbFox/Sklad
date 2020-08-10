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
    public partial class FormTaken : Form
    {
        
        public FormTaken()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dgvTaken.DataSource = ExetQueryTaken(db);
            }
        }

        private void btnAddTovar_Click(object sender, EventArgs e)
        {
            FormAddElement fae = new FormAddElement();
           if(fae.ShowDialog(this) == DialogResult.OK)
            {
                btnAddTovar.Text = fae.txtNameTov.Text;
            }
        }

        
        dynamic ExetQueryTaken(Context db)
        {
            return db.Статусы_товаров.Where(s => s.Статусы.Наименование_статуса == "Принят").Select(s => new
            {
                s.Товары.Id_товар,
                s.Товары.Наименование,
                s.Товары.Количество,
                s.Товары.Стоимость,
                s.Статусы.Наименование_статуса,
                s.Дата_изменения
            }).ToList();
            
        }
       private void FormTaken_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rssDbNewDataSet.Товары". При необходимости она может быть перемещена или удалена.
            this.товарыTableAdapter.Fill(this.rssDbNewDataSet.Товары);

        }
    }
}
