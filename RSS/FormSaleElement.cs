using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
namespace RSS
{
    public partial class FormSaleElement : Form
    {
        public FormSaleElement()
        {
            InitializeComponent();
            using(Context db = new Context()) // Функция продажи
            {
                Товары tovars = db.Товары.Where(m => m.Id_товар == ClassCurrent.Id).FirstOrDefault();
                lbNameTov.Text = tovars.Наименование;
                UpDownKolvo.Value = tovars.Количество;
                lbSumma.Text = Convert.ToString(tovars.Стоимость * tovars.Количество);

            }
        }

        private void btnReport_Click(object sender, EventArgs e) // кнопка продажи
        {
            try
            {

                using (Context db = new Context())
                {
                    db.Статусы_товаров.Add(new Статусы_товаров { Id_Статус = 3, Id_товара = ClassCurrent.Id, Дата_изменения = DateTime.Now.Date });
                    db.SaveChanges();
                }
            }
            catch
            {

            }
        }

        private void UpDownKolvo_ValueChanged(object sender, EventArgs e) // выбор количества необходимых товаров
        {
            lbSumma.Text = Convert.ToString(ClassCurrent.stoimost * UpDownKolvo.Value);
        }
    }
}
