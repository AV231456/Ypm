using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Tourist
{
    public partial class PROFRAMTOURIST : Form
    {
        public PROFRAMTOURIST()
        {
            InitializeComponent();

            LoadData();
        }

        static public string EditNumLine, EditLine;

        private void LoadData()
        {
            string dbPath = "praktika.db";
            string connString = $"Data Source={dbPath};Version=3;";

            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();

                // Load Treatments table without Diagnoses column
                string query = "SELECT TreatmentID, PatientID, DoctorID, OutpatientTreatmentNeeded, DisabilityPeriod, OnDispensaryCare, TreatmentStartDate FROM Treatment";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

                DataTable table4 = new DataTable();
                adapter.Fill(table4);

                TABL4.DataSource = table4;

                // Load other tables as before
                query = "SELECT * FROM Doctor";
                cmd = new SQLiteCommand(query, conn);
                adapter = new SQLiteDataAdapter(cmd);

                DataTable table2 = new DataTable();
                adapter.Fill(table2);

                TABL2.DataSource = table2;

                query = "SELECT * FROM Patient";
                cmd = new SQLiteCommand(query, conn);
                adapter = new SQLiteDataAdapter(cmd);

                DataTable table3 = new DataTable();
                adapter.Fill(table3);

                TABL3.DataSource = table3;

                // Note: The first query was not specific, assuming you want to load all tables
                // If you need to load a specific table, adjust the query accordingly
                query = "SELECT * FROM Treatment"; // Adjusted to load only necessary columns if needed
                cmd = new SQLiteCommand(query, conn);
                adapter = new SQLiteDataAdapter(cmd);

                DataTable table1 = new DataTable();
                adapter.Fill(table1);

                TABL1.DataSource = table1;
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            string connectionString = "Data Source=praktika.db;Version=3;";
            string query = @"
                SELECT P.PatientID, P.LastName, P.FirstName
                FROM Patient P
                JOIN Treatment T ON P.PatientID = T.PatientID
                GROUP BY P.PatientID
                HAVING COUNT(DISTINCT T.Diagnosis) = (SELECT COUNT(DISTINCT Diagnosis) FROM Treatment);
            ";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            ZAPROS.DataSource = table;
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            string connectionString = "Data Source=praktika.db;Version=3;";
            string query = @"SELECT 
    P. PatientID, P.FirstName, P.LastName,
    (SUM(CASE WHEN T.Diagnosis = 'кариес' THEN 1.0 ELSE 0 END) * 100) / COUNT(T.TreatmentID) AS Percentage
FROM Treatment T
JOIN Patient P ON T.PatientID = P.PatientID 
GROUP BY P.PatientID, P.FirstName, P.LastName;";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        ZAPROS.DataSource = dataTable;
                        ZAPROS.DataMember = "";
                        ZAPROS.Refresh();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string connectionString = "Data Source=praktika.db;Version=3;";
            string query = @"
                SELECT DISTINCT D.LastName, D.FirstName
                FROM Doctor D
                WHERE NOT EXISTS (
                    SELECT 1
                    FROM Treatment T
                    JOIN Patient P ON T.PatientID = P.PatientID
                    WHERE T.DoctorID = D.DoctorID AND P.SocialStatus <> 'пенсионер'
                );
            ";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        ZAPROS.DataSource = dataTable;
                        ZAPROS.DataMember = "";
                        ZAPROS.Refresh();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PROFRAMTOURIST_Load(object sender, System.EventArgs e)
        {
            TABL1.Visible = false;
            TABL2.Visible = false;
            TABL3.Visible = false;
            TABL4.Visible = false;
        }

        private void button13_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, System.EventArgs e)
        {
            TABL1.Visible = true;
            TABL2.Visible = false;
            TABL3.Visible = false;
            TABL4.Visible = false;
        }

        private void button17_Click(object sender, System.EventArgs e)
        {
            TABL1.Visible = false;
            TABL2.Visible = true;
            TABL3.Visible = false;
            TABL4.Visible = false;
        }

        private void button18_Click(object sender, System.EventArgs e)
        {
            TABL1.Visible = false;
            TABL2.Visible = false;
            TABL3.Visible = true;
            TABL4.Visible = false;
        }

        private void control_Click(object sender, System.EventArgs e)
        {
            TABL1.Visible = false;
            TABL2.Visible = false;
            TABL3.Visible = false;
            TABL4.Visible = true;
        }

        private void ZAPROS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string connectionString = "Data Source=praktika.db;Version=3;";
            string query = @"
                SELECT T.TreatmentID, P.LastName, P.FirstName, D.LastName AS DoctorLastName, D.FirstName AS DoctorFirstName, T.Diagnosis
                FROM Treatment T
                JOIN Patient P ON T.PatientID = P.PatientID
                JOIN Doctor D ON T.DoctorID = D.DoctorID
                WHERE T.Diagnosis = 'язва желудка' AND D.Specialization = 'невропатолог';
            ";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        ZAPROS.DataSource = dataTable;
                        ZAPROS.DataMember = "";
                        ZAPROS.Refresh();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}