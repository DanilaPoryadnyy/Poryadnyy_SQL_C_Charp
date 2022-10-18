using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poryadnyy_SQL_C_Charp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string HostName = textBox1.Text,
                    BaseName = textBox2.Text,
                    FirstName = textBox4.Text,
                    SecondName = textBox3.Text,
                    TableName = textBox5.Text,
                    SQLQuery = "";
            
            DataBase db = new DataBase("", "");
            db = new DataBase($"{HostName}", $"{BaseName}");

            db.openConnection();
            
            //SQL запрос
            SQLQuery = $"SELECT * FROM {TableName} WHERE first_name='{FirstName}' AND second_name='{SecondName}'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(String.Format(SQLQuery, FirstName, SecondName),
            db.GetConnection());


            adapter.SelectCommand = command;          
            try
            {
                
                if (adapter.Fill(table) == 1)
                {
                    MessageBox.Show($"Вы вошли как: {FirstName} {SecondName}", "Успешный вход",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Авторизация не прошла под данными: {FirstName} {SecondName}", "Ошибка ввода данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }
                db.closeConnection();
            }
            catch
            {
                MessageBox.Show($"Введите данные", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
