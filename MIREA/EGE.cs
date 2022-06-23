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
    public partial class EGE : Form
    {
        DB dataBase = new DB();
        public EGE()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void EGE_Load(object sender, EventArgs e)
        {
            textBox_Predmet.MaxLength = 255;
            textBox_Score.MaxLength = 255;
            textBox_svNumber.MaxLength = 255;
            textBox_Place.MaxLength = 255;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var predmet = textBox_Predmet.Text;
            var score = textBox_Score.Text;
            var svNumber = textBox_svNumber.Text;
            var data = dateTimePicker1.Value;
            var place = textBox_Place.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into ЕГЭ_ГИА(Предмет_ЕГЭ_ГИА, Балл_ЕГЭ_ГИА, Номер_свидетельства_ЕГЭ_ГИА, Дата_получения_свидетельства, Место_выдачи_ЕГЭ_ГИА) values ('{predmet}','{score}','{svNumber}','{data}','{place}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
