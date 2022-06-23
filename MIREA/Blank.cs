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
    public partial class Blank : Form
    {
        //Для начала подключим класс базы данных к форме
        DB dataBase = new DB();
        public Blank()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Blank_Load(object sender, EventArgs e)
        {
            tBox_Surname.MaxLength = 255;
            tBox_Name.MaxLength = 255;
            tBox_Patron.MaxLength = 255;
        }

        private void btnAdres_Click(object sender, EventArgs e)
        {
            Adress adress = new Adress();
            adress.ShowDialog();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            Code code = new Code();
            code.ShowDialog();
        }

        private void btnPasport_Click(object sender, EventArgs e)
        {
            Pasport pasport = new Pasport();
            pasport.ShowDialog();
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            Parents parents = new Parents();
            parents.ShowDialog();
        }

        private void btnEGE_Click(object sender, EventArgs e)
        {
            EGE ege = new EGE();
            ege.ShowDialog();
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            Docs docs = new Docs();
            docs.ShowDialog();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var surname = tBox_Surname.Text;
            var name = tBox_Name.Text;
            var patron = tBox_Patron.Text;
            var data = dateTimePicker.Value;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"insert into Основная_информация (Фамилия, Имя, Отчество, Дата_рождения) values ('{surname}','{name}','{patron}','{data}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Данные успешно сохранены", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
