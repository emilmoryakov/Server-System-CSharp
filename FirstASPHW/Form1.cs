using Microsoft.Data.SqlClient;
using System.Net.NetworkInformation;

namespace FirstASPHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReturnAllBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=EMIL;Initial Catalog=Store;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            conn.Open(); 
            var command = new SqlCommand("SELECT * FROM Products", conn);

            SqlDataReader reader = command.ExecuteReader();
            var schema = reader.GetColumnSchema();

            foreach (var column in schema)
            {
                ResultsBox.Text += $"{column.ColumnName} \t";
            }

            while (reader.Read())
            {
                ResultsBox.Text += $"\n{reader.GetInt32(0)}\t{reader.GetString(1)}\t{reader.GetString(2)}\t{reader.GetDecimal(3)}";

            }

            conn.Close();
        }

        private void CustomQueryBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=EMIL;Initial Catalog=Store;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            conn.Open();
            var command = new SqlCommand(QueryTxtBox.Text, conn);

            SqlDataReader reader = command.ExecuteReader();
            var schema = reader.GetColumnSchema();

            foreach (var column in schema)
            {
                ResultsBox.Text += $"{column.ColumnName} \t";
            }

            while (reader.Read())
            {
                ResultsBox.Text += $"\n{reader.GetInt32(0)}\t{reader.GetString(1)}\t{reader.GetString(2)}\t{reader.GetDecimal(3)}";


            }

            conn.Close();
        }

        private void ReturnMaxBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=EMIL;Initial Catalog=Store;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            conn.Open();
            var command = new SqlCommand($"SELECT MAX(Price) FROM Products", conn);

            var reader = command.ExecuteScalar();
            ResultsBox.Text = reader.ToString();

            conn.Close();
        }

        private void ReturnMinBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=EMIL;Initial Catalog=Store;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            conn.Open();
            var command = new SqlCommand($"SELECT MIN(Price) FROM Products", conn);

            var reader = command.ExecuteScalar();
            ResultsBox.Text = reader.ToString();

            conn.Close();
        }

    }
}