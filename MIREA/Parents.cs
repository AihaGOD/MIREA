using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MIREA
{
    public partial class Parents : Form
    {
        DB dataBase = new DB();
        public Parents()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Parents_Load(object sender, EventArgs e)
        {
            textBox_Rod.MaxLength = 255;
            textBox_FIO.MaxLength = 255;
            textBox_WorkPH.MaxLength = 255;
            textBox_Phone.MaxLength = 255;
            textBox_Workplace.MaxLength = 255;
            textBox_Job.MaxLength = 255;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rod = textBox_Rod.Text;
            var FIO = textBox_FIO.Text;
            var WorkPH = textBox_WorkPH.Text;
            var phone = textBox_Phone.Text;
            var workplace = textBox_Workplace.Text;
            var job = textBox_Job.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into Родители(Вид_родства, ФИО_родителя, Рабочий_телефон, Мобильный_телефон, Место_работы, Должность) values ('{rod}','{FIO}','{WorkPH}','{phone}','{workplace}','{job}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
