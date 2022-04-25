using System.Data;
using System.Data.SQLite;

namespace student_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            //!!!!!!!!!!!!! AS is used as a keyword need to change the table name
            string querry = "SELECT * FROM PB";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            string querry = "SELECT * FROM CD";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            string querry = "SELECT * FROM HG";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();
         
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            //!!!!!!!!!!!!! AS is used as a keyword need to change the table name
            string querry = "SELECT * FROM AS";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            string querry = "SELECT * FROM CR";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            string querry = "SELECT * FROM CU";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            string querry = "SELECT * FROM NI";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            string querry = "SELECT * FROM SE";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Location of the database
            SQLiteConnection con = new SQLiteConnection("Data Source=C:\\Users\\KK\\Desktop\\DATA.db");

            //SQL command to get data 
            string querry = "SELECT * FROM ZN";

            //Does the command on the given database
            SQLiteCommand cmd = new SQLiteCommand(querry, con);

            //Creates new empty datatable to store stuff
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //Fills up the datatable
            adapter.Fill(dt);

            //Sets datagridview1 source as filled up datatable
            dataGridView1.DataSource = dt;
        }
    }
}