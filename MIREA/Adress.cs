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
    public partial class Adress : Form
    {
        DB dataBase = new DB();
        public Adress()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Adress_Load(object sender, EventArgs e)
        {
            textBox_City.MaxLength = 255;
            textBox_Town.MaxLength = 255;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var city = textBox_City.Text;
            var town = textBox_Town.Text;
            var house = textBox_House.Text;
            var corpus = textBox_Corpus.Text;
            var room = textBox_Room.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into Адрес (Город_область, Улица, Дом, Корпус, Квартира) values ('{town}','{city}','{house}','{corpus}','{room}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
