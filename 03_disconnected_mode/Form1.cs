using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _03_disconnected_mode
{
    public partial class Form1 : Form
    {
        string connectionString = null;
        SqlConnection connection = null;
        SqlDataAdapter adapter = null;
        DataSet set = new DataSet();

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["HospitalDb"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = "select * from Doctors";
            adapter = new SqlDataAdapter(cmd, connection);

            // generate INSERT, UPDATE, DELETE commands
            new SqlCommandBuilder(adapter);

            set.Clear();

            // Fill() - open connection -> load data from database -> close connection
            adapter.Fill(set);

            // set data to GridView
            dataGridView1.DataSource = set.Tables[0];

            //MessageBox.Show(set.Tables[0].Rows[0]["Name"].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update() - submit changes to database (run INSERT, UPDATE, DELETE commands)
            adapter.Update(set);
        }
    }
}