using System.Data.SqlClient;


namespace HomeworkElvin

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=localhost;Database=Store;Trusted_Connection=True;");
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
                ResultsBox.Text += $"\n{reader.GetInt32(0)}\t{reader.GetString(1)}\t{reader.GetString(2)}";
            }
            conn.Close();



        }

        private void MaximumBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new("Data Source=localhost;Database=Store;Trusted_Connection=True;");
            conn.Open();
            var command = new SqlCommand("SELECT * FROM Products", conn);
        }

        private void MinimumBtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomQueryBtn_Click(object sender, EventArgs e)
        {

        }
    }
}