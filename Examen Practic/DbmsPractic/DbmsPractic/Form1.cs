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

namespace PracticalExamModel
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter daCustomer, daDelivery;
        SqlCommandBuilder cbDelivery;
        DataSet ds;
        BindingSource bsCustomer, bsDelivery;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = DESKTOP-B5IS4HU; Initial Catalog = " +
                "ExamenPractic; Integrated Security = SSPI");

            daCustomer = new SqlDataAdapter("SELECT * FROM Customer", conn);
            daDelivery = new SqlDataAdapter("SELECT * FROM Delivery", conn);

            cbDelivery = new SqlCommandBuilder(daDelivery);
            daDelivery.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();
            daCustomer.Fill(ds, "Customer");
            daDelivery.Fill(ds, "Delivery");

            DataRelation dr = new DataRelation("FK_Delivery_Customer", ds.Tables["Customer"].Columns["CustomerID"],
                ds.Tables["Delivery"].Columns["CustomerID"]);
            ds.Relations.Add(dr);

            bsCustomer = new BindingSource();
            bsCustomer.DataSource = ds;
            bsCustomer.DataMember = "Customer";

            bsDelivery = new BindingSource();
            bsDelivery.DataSource = bsCustomer;
            bsDelivery.DataMember = "FK_Delivery_Customer";

            dvgCustomers.DataSource = bsCustomer;
            dvgDeliveries.DataSource = bsDelivery;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ds.Tables["Delivery"].Clear();
            daDelivery.Fill(ds, "Delivery");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePosts_Click(object sender, EventArgs e)
        {
            daDelivery.Update(ds, "Delivery");
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
