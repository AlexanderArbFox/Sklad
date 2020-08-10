using System;
using System.Windows.Forms;

namespace RSS
{
    public partial class FormAddElement : Form
    {
        public FormAddElement()
        {
            InitializeComponent();
            ClearedTxt();
        }

        private void btnReport_Click(object sender, EventArgs e) // Кнопка добавления в бд продуктов
        {
            using (Context db = new Context())
            {
                try
                {
                    if (txtNameTov.Text.Equals("") || txtPrice.Text.Equals(""))
                      {
                      MessageBox.Show("Заполните все поля");
                      }
                    else
                    {
                    Товары tov = new Товары()
                    {
                        Наименование = txtNameTov.Text,
                        Количество = (int)UpDownAddTov.Value,
                        Стоимость = Convert.ToDecimal(txtPrice.Text)
                        };
                        db.Товары.Add(tov);
                        db.Статусы_товаров.Add(new Статусы_товаров { Id_Статус = 1, Id_товара = tov.Id_товар, Дата_изменения = DateTime.Now.Date });
                        db.SaveChanges();
                       
                    }
                }
                catch
                {

                }
            }
        }

        private void ClearedTxt()
        {
            txtNameTov.Text.Equals("");
            txtPrice.Text.Equals("");
        }
    }
}
