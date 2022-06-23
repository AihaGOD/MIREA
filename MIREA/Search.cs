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
    public partial class Search : Form
    {
        DB dataBase = new DB();
        public Search()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var surname = textBox_surname.Text;
            var name = textBox_name.Text;
            var patron = textBox_patron.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $@"SELECT        Основная_информация.*, Адрес.Город_область, Адрес.Улица, Адрес.Дом, Адрес.Корпус, Адрес.Квартира, Родители.Вид_родства, Родители.ФИО_родителя, Родители.Рабочий_телефон, 
                         Родители.Мобильный_телефон, Родители.Место_работы, Родители.Должность, Поступление.Название_специальности, Поступление.Код_специальности, Поступление.Вид_обучения, ЕГЭ_ГИА.Предмет_ЕГЭ_ГИА, 
                         ЕГЭ_ГИА.Балл_ЕГЭ_ГИА, ЕГЭ_ГИА.Номер_свидетельства_ЕГЭ_ГИА, ЕГЭ_ГИА.Дата_получения_свидетельства, ЕГЭ_ГИА.Место_выдачи_ЕГЭ_ГИА, Паспортные_данные.Серия, Паспортные_данные.Номер, 
                         Паспортные_данные.Место_рождения, Паспортные_данные.Гражданство, Паспортные_данные.Место_выдачи, Паспортные_данные.Дата_выдачи
                         FROM            Родители INNER JOIN
                         Адрес ON Родители.ID_абитуриента = Адрес.ID_абитуриента INNER JOIN
                         Поступление ON Родители.ID_абитуриента = Поступление.ID_абитуриента INNER JOIN
                         ЕГЭ_ГИА ON Родители.ID_абитуриента = ЕГЭ_ГИА.ID_абитуриента INNER JOIN
                         Паспортные_данные ON Родители.ID_абитуриента = Паспортные_данные.ID_абитуриента CROSS JOIN
                         Основная_информация where Основная_информация.Фамилия = '{surname}' and Основная_информация.Имя = '{name}' and Основная_информация.Отчество = '{patron}'";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            мИРЭАDataSet1BindingSource.DataSource = table;
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
    }
}
