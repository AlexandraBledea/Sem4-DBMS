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

namespace Lab1
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter da;
        private DataSet ds;

        public Form1()
        {

            this.conn = new SqlConnection(GetConnectionString());
            this.da = new SqlDataAdapter();
            this.ds = new DataSet();

            InitializeComponent();
            this.libraryIDBox.ReadOnly = true;
            this.ChildTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ParentTable_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ChildTable_Load()
        {

        }

        private void ParentTable_Load()
        {
            this.ParentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.da.SelectCommand = new SqlCommand("SELECT * FROM Library", conn);
            this.ds.Clear();
            this.da.Fill(this.ds, "Library");

            this.ParentTable.DataSource = this.ds.Tables["Library"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void clearTextBoxes()
        {
            this.cnpBox.Clear();
            this.nameBox.Clear();
            this.ageBox.Clear();
            this.telBox.Clear();
            this.libraryIDBox.Clear();
            this.salaryBox.Clear();
        }

        private void ParentTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearTextBoxes();

            // We take the current selected row
            DataGridViewRow selectedParent = this.ParentTable.SelectedRows[0];

            // We write in the text box the id of the library
            this.libraryIDBox.Text = selectedParent.Cells[0].Value.ToString();

            if (this.ParentTable.SelectedRows.Count > 0)
            {

                // We take the id of the library
                int bookCollectionId = Convert.ToInt32(selectedParent.Cells[0].Value);
                
                // We create the select command
                this.da.SelectCommand = new SqlCommand("SELECT * FROM Staff_Member WHERE Library_ID = @id", this.conn);
                this.da.SelectCommand.Parameters.AddWithValue("@id", bookCollectionId);

                // We repopulate the child table
                this.ds = new DataSet();
                this.da.Fill(this.ds, "Staff_Member");
                this.ChildTable.DataSource = this.ds.Tables["Staff_Member"];
            }
        }

        private void ChildTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // We take the index of the selected row
            int index = this.ChildTable.SelectedRows[0].Index;

            // We populate the text boxes 
            this.cnpBox.Text = this.ds.Tables["Staff_Member"].Rows[index][0].ToString();
            this.nameBox.Text = this.ds.Tables["Staff_Member"].Rows[index][1].ToString();
            this.ageBox.Text = this.ds.Tables["Staff_Member"].Rows[index][2].ToString();
            this.telBox.Text = this.ds.Tables["Staff_Member"].Rows[index][3].ToString();
            this.libraryIDBox.Text = this.ds.Tables["Staff_Member"].Rows[index][4].ToString();
            this.salaryBox.Text = this.ds.Tables["Staff_Member"].Rows[index][5].ToString();

        }

        private static String GetConnectionString()
        {
            return "Data Source = DESKTOP-B5IS4HU;" +
                   "Initial Catalog = LibraryManagement;" +
                   "Integrated Security = true;";
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // We create the insert sql command
                this.da.InsertCommand = new SqlCommand("INSERT INTO Staff_Member (CNP, Name, Age, Telephone, Library_ID, Salary) VALUES (@c, @n, @a, @t, @l, @s)", conn);

                // We add the values to each parameter from the insert command
                this.da.InsertCommand.Parameters.Add("@c", SqlDbType.Int).Value = Int32.Parse(cnpBox.Text);
                this.da.InsertCommand.Parameters.Add("@n", SqlDbType.VarChar).Value = nameBox.Text;
                this.da.InsertCommand.Parameters.Add("@a", SqlDbType.Int).Value = Int32.Parse(ageBox.Text);
                this.da.InsertCommand.Parameters.Add("@t", SqlDbType.Int).Value = Int32.Parse(telBox.Text);
                this.da.InsertCommand.Parameters.Add("@l", SqlDbType.Int).Value = Int32.Parse(libraryIDBox.Text);
                this.da.InsertCommand.Parameters.Add("@s", SqlDbType.Int).Value = Int32.Parse(salaryBox.Text);

                // We open the connection, execute the query, print a message and close the connection
                this.conn.Open();
                this.da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted Succesfull to Database");
                this.conn.Close();

                // We repopulate the table
                this.ds = new DataSet();
                this.da.Fill(this.ds, "Staff_Member");
                this.ChildTable.DataSource = this.ds.Tables["Staff_Member"];

                this.clearTextBoxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.conn.Close();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //We take the index of the currently selected row
            int index = this.ChildTable.SelectedRows[0].Index;
            DialogResult dr;
            dr = MessageBox.Show("Are you sure?\n No undo after delete!", "Confirm Deletion", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {

                // We create the delete command
                this.da.DeleteCommand = new SqlCommand("DELETE FROM Staff_Member WHERE CNP=@id", conn);
                this.da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = this.ds.Tables["Staff_Member"].Rows[index][0];

                this.conn.Open();
                this.da.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Succesfull from Database");
                this.conn.Close();

                this.libraryIDBox.Clear();

                this.ds = new DataSet();
                this.da.Fill(this.ds, "Staff_Member");
                this.ChildTable.DataSource = this.ds.Tables["Staff_Member"];

                this.clearTextBoxes();
            }
            else
            {
                MessageBox.Show("Deletion Aborted");
                this.conn.Close();
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // We take the index of the selected row
                int index = this.ChildTable.SelectedRows[0].Index;

                // We create the Update command
                this.da.UpdateCommand = new SqlCommand("Update Staff_Member set Name = @n, Age = @a, Telephone = @t, Salary = @s where CNP = @id", this.conn);

                // We add the values for each parameter from the command
                this.da.UpdateCommand.Parameters.Add("@n", SqlDbType.VarChar).Value = nameBox.Text;
                this.da.UpdateCommand.Parameters.Add("@a", SqlDbType.Int).Value = Int32.Parse(ageBox.Text);
                this.da.UpdateCommand.Parameters.Add("@t", SqlDbType.Int).Value = Int32.Parse(telBox.Text);
                this.da.UpdateCommand.Parameters.Add("@s", SqlDbType.Int).Value = Int32.Parse(salaryBox.Text);

                this.da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = this.ds.Tables["Staff_Member"].Rows[index][0];

                // We open the connection
                this.conn.Open();
                this.da.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Succesfull");
                this.conn.Close();

                // We repopulate the table
                this.ds = new DataSet();
                this.da.Fill(this.ds, "Staff_Member");
                this.ChildTable.DataSource = this.ds.Tables["Staff_Member"];

                this.clearTextBoxes();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.conn.Close();
            }
        }
    }
}



//SqlCommand command = new SqlCommand("select * from staff_member where library_id = @id", conn);
//{
//    connection = new sqlconnection(getconnectionstring());
//}