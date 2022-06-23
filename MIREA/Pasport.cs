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
    public partial class Pasport : Form
    {
        DB dataBase = new DB();
        public Pasport()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Pasport_Load(object sender, EventArgs e)
        {
            textBox_BirthPlace.MaxLength = 255;
            textBox_Citizenship.MaxLength = 255;
            textBox_IssuePlace.MaxLength = 255;
            textBox_Number.MaxLength = 255;
            textBox_Series.MaxLength = 255;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var series = textBox_Series.Text;
            var number = textBox_Number.Text;
            var birth = textBox_BirthPlace.Text;
            var citizenship = textBox_Citizenship.Text;
            var issue = textBox_IssuePlace.Text;
            var date = dateTimePicker.Value;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into Паспортные_данные (Серия, Номер, Место_рождения, Гражданство, Место_выдачи, Дата_выдачи) values ('{series}','{number}','{birth}','{citizenship}','{issue}', '{date}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
