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
    public partial class Docs : Form
    {
        DB dataBase = new DB();
        public Docs()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.SafeFileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            textBox2.Text = openFileDialog2.SafeFileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            textBox3.Text = openFileDialog3.SafeFileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
            textBox4.Text = openFileDialog4.SafeFileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog5.ShowDialog();
            textBox5.Text = openFileDialog5.SafeFileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog6.ShowDialog();
            textBox6.Text = openFileDialog6.SafeFileName;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog7.ShowDialog();
            textBox7.Text = openFileDialog7.SafeFileName;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var photo = Image.FromFile(openFileDialog1.FileName);
            var zayav = Image.FromFile(openFileDialog2.FileName);
            var spravka = Image.FromFile(openFileDialog3.FileName);
            var pasCopy = Image.FromFile(openFileDialog4.FileName);
            var propiska = Image.FromFile(openFileDialog5.FileName);
            var obrDoc = Image.FromFile(openFileDialog6.FileName);
            var lgDoc = Image.FromFile(openFileDialog7.FileName);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into Документы (Фото, Заявление, Справка_086_у, Копия_паспорта, Справка_о_прописке, Документ_об_образовании, Документ_об_льготе) values ('{photo}','{zayav}','{spravka}','{pasCopy}','{propiska}','{obrDoc}','{lgDoc}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
