using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card
{
    public partial class MainForm : Form
    {
        string loginSuccess="";
        string connectionString;

        public MainForm(string str)
        {
            InitializeComponent();
           // loginSuccess = "success";
            loginSuccess = str;
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\My Doc\C# Project\Card\Card\Database1.mdf;Integrated Security=True";
        }

        // Form Load
        private void MainForm_Load(object sender, EventArgs e)
        {
            tabMain.TabPages.Remove(tabAdd);
            tabMain.TabPages.Remove(tabDelete);
            tabMain.TabPages.Remove(tabSearch);
            if (loginSuccess == "success")
            {
                tabMain.TabPages.Add(tabAdd);
                tabMain.TabPages.Add(tabDelete);
                tabMain.TabPages.Add(tabSearch);
                datagridview1.Rows.Clear();
                Read();
                login.Enabled = false;
            }
        }

        // Close Application
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // login in menuStrip
        private void login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        // signout in menuStrip
        private void signout_Click(object sender, EventArgs e)
        {
            loginSuccess = "";
            tabMain.TabPages.Remove(tabAdd);
            tabMain.TabPages.Remove(tabDelete);
            tabMain.TabPages.Remove(tabSearch);
            login.Enabled = true;
        }

        #region /* Scan */

        // TabScan Enter
        private void tabScan_Enter(object sender, EventArgs e)
        {
            txtScanCardId.Focus();
        }

        // TabScan Leave
        private void tabScan_Leave(object sender, EventArgs e)
        {
            txtScanAmount.Text = "";
            txtScanCardId.Text = "";
        }

        // Clear Button in tabScan
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScanAmount.Text = "";
            txtScanCardId.Text = "";
            txtScanCardId.Focus();
        }

        // Scan Button in tabScan
        private void btnScan_Click(object sender, EventArgs e)
        {
            if (txtScanCardId.Text != "")
            {
                Scan();
            }
            else
                MessageBox.Show("Put card on reader");
        }

        #endregion

        #region /* Add */

        // TabAdd Click
        private void tabAdd_Click(object sender, EventArgs e)
        {
            txtAddCardId.Focus();
        }

        // TabAdd Leave
        private void tabAdd_Leave(object sender, EventArgs e)
        {
            txtAddCardId.Text = "";
            cboAddAmount.SelectedIndex = -1;
        }

        // New Button in tabAdd
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtAddCardId.Text = "";
            cboAddAmount.SelectedIndex = -1;
            txtAddCardId.Focus();
        }

        // Add Button in tabAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddCardId.Text != "" && cboAddAmount.Text != "")
            {
                Add();
                txtAddCardId.Text = "";
                cboAddAmount.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Input All Fill","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        #endregion

        #region /* Delete */

        // TabDelete Click
        private void tabDelete_Click(object sender, EventArgs e)
        {
            txtDeleteCardId.Focus();
        }

        // TabDelete Leave
        private void tabDelete_Leave(object sender, EventArgs e)
        {
            txtDeleteCardId.Text = "";
            txtDeleteAmount.Text = "";
        }

        // Clear Button in Delete
        private void btnDeleteClear_Click(object sender, EventArgs e)
        {
            txtDeleteCardId.Text = "";
            txtDeleteAmount.Text = "";
            txtDeleteCardId.Focus();
        }

        // Delete Button in tabDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteCardId.Text != "")
            {
                Delete();
                txtDeleteCardId.Text = "";
                txtDeleteAmount.Text = "";
            }
            else
                MessageBox.Show("Enter Card ID to Delete","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region /* Search */

        // Clear Button in tabSearch
        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all scan record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Clear();
                MessageBox.Show("Finish clear all scan card records");
                datagridview1.Rows.Clear();
                Read();
            }
        }

        #endregion

        





        #region /* Methods */

        // Add Function
        void Add()
        {
            string sql = "INSERT INTO tbCard VALUES(@cardId,@amount)";
            using(SqlConnection cnn =new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@cardId", txtAddCardId.Text.Trim());
                    cmd.Parameters.AddWithValue("@amount", cboAddAmount.Text.Trim());
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Card Add");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Card Already Add","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Delete Function
        void Delete()
        {
            string str = Search(txtDeleteCardId.Text.Trim());
            if (str!="")
            {
                txtDeleteAmount.Text = str;
                DialogResult result = MessageBox.Show("Do you really want to delete this card","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM tbCard WHERE CardId=@cardId";
                    using(SqlConnection cnn=new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        using(SqlCommand cmd=new SqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("@cardId", txtDeleteCardId.Text.Trim());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Card Deleted");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Card Not Found","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        // Search Function
        string Search(string str)
        {
            string sql = "SELECT * FROM tbCard WHERE CardId=@cardId";
            using(SqlConnection cnn=new SqlConnection(connectionString))
            {
                cnn.Open();
                using(SqlCommand cmd=new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@cardId",str);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return reader[1].ToString();
                        else
                            return "";
                    }
                }
            }
        }

        // Scan Function
        void Scan()
        {
            string str = Search(txtScanCardId.Text.Trim());
            if (str != "")
            {
                txtScanAmount.Text = str;
                if (loginSuccess!="success")
                    Update();
            }
            else
                MessageBox.Show("Invalid Card","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        // Update Function
        void Update()
        {
            bool found = false;
           // string sql = "SELECT * FROM tbCardScan";
            string sql = "SELECT * FROM tbCardScanDemo";
            using(SqlConnection cnn=new SqlConnection(connectionString))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        foreach(DataRow dr in dt.Rows)
                        {
                            if (dr[1].ToString() == txtScanCardId.Text.Trim())
                            {
                                dr[2] = (Convert.ToInt32(dr[2]) + 1);
                                found = true;
                            }
                        }
                        if (found == false)
                        {
                            DataRow dr = dt.NewRow();
                            dr[1] = txtScanCardId.Text.Trim();
                            dr[2] = 1;
                            dt.Rows.Add(dr);
                        }
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                        adapter.Update(dt);
                    }
                }
            }
        }

        // Read Function
        void Read()
        {
            string sql = "SELECT tbCard.CardId,tbCard.Amount,tbCardScan.ScanTimes FROM tbCard INNER JOIN tbCardScan ON tbCard.CardId=tbCardScan.CardId";
          //  string sql = "SELECT tbCard.CardId,tbCard.Amount,tbCardScanDemo.ScanTimes FROM tbCard INNER JOIN tbCardScanDemo ON tbCard.CardId=tbCardScanDemo.CardId";
            using(SqlConnection cnn=new SqlConnection(connectionString))
            {
                cnn.Open();
                using(SqlCommand cmd=new SqlCommand(sql, cnn))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datagridview1.Rows.Add(reader[0], reader[1], reader[2]);
                        }
                    }
                }
            }
        }

        // Clear Function
        void Clear()
        {
            string sql = "UPDATE tbCardScan SET ScanTimes=0";
            using(SqlConnection cnn=new SqlConnection(connectionString))
            {
                cnn.Open();
                using(SqlCommand cmd=new SqlCommand(sql, cnn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        
    }
}
