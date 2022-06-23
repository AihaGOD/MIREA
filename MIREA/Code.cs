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
    public partial class Code : Form
    {
        DB dataBase = new DB();
        public Code()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Code_Load(object sender, EventArgs e)
        {
            textBox_Code.MaxLength = 255;
            textBox_name.MaxLength = 255;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = textBox_name.Text;
            var code = textBox_Code.Text;
            var form = comboBox_Form.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into Поступление (Название_специальности, Код_специальности, Вид_обучения) values ('{name}','{code}','{form}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
