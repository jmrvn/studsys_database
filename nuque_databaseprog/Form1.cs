using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace databaseprog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            confirmConnect();

            Color backgroundColor = ColorTranslator.FromHtml("#B19CD9"); 
            this.BackColor = backgroundColor;

            cbCOURSE.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYEAR.DropDownStyle = ComboBoxStyle.DropDownList;

            this.lvList.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lvList_ColumnWidthChanging); // disallow user from changing column header's width
        }

        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;




        string mycon = "Server=localhost; Database=studentdb; user=root; password=";


        private void confirmConnect()
        {
            mySqlConnection = new MySqlConnection(mycon);
            mySqlConnection.Open();

            MessageBox.Show("okay na");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            txtID.Enabled = false;
            txtLN.Enabled = false;
            txtFN.Enabled = false;
            txtMN.Enabled = false;
            txtADDRESS.Enabled = false;
            cbCOURSE.Enabled = false;
            cbYEAR.Enabled = false;

            cbYEAR.Items.Add("1ST");
            cbYEAR.Items.Add("2ND");
            cbYEAR.Items.Add("3RD");
            cbYEAR.Items.Add("4TH");


            loadCourses(cbCOURSE);
            loadStudents(lvList);
            mySqlConnection.Close();
            mySqlConnection.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnNEW.Enabled = false;
            btnCANCEL.Enabled = true;
            btnSAVE.Enabled = true;
            btnEDIT.Enabled = false;

            txtFN.Enabled = true;
            txtLN.Enabled = true;
            txtMN.Enabled = true;
            txtADDRESS.Enabled = true;
            cbCOURSE.Enabled = true;
            cbYEAR.Enabled = true;
            btnSAVE.Text = "ADD";

            txtID.Text = getLastID().ToString();

        }

        private void btnUPDATE_EnabledChanged(object sender, EventArgs e)
        {
             if (btnUPDATE.Enabled)
            {
                // Change the BackColor to a hexadecimal color code
                btnUPDATE.BackColor = SystemColors.ControlLightLight; 
            }
            else
            {
                // Change the BackColor to a different color when disabled or as needed
                btnUPDATE.BackColor = SystemColors.ControlDarkDark;
            } 
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            string lname = txtLN.Text;
            string fname = txtFN.Text;
            string mname = txtMN.Text;
            string address = txtADDRESS.Text;
            string course = cbCOURSE.Text;
            string year = cbYEAR.Text;


            if (IsAnyFieldEmpty())
            {
                MessageBox.Show("Missing information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSAVE.Enabled = false;
                btnNEW.Enabled = false;
                btnCANCEL.Enabled = true;
                btnEDIT.Enabled = false;
                btnDELETE.Enabled = false;

            }

            else
            {
                string sql = "UPDATE student_tbl SET lastname = '" + lname + "', firstname = '" + fname + "', middlename = '" + mname + "', address = '" + address + "'," +
                "course = '" + course + "', year = '" + year + "' WHERE id=" + ID + "";

                mySqlConnection = new MySqlConnection(mycon);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand(sql, mySqlConnection);

                DialogResult dialog = MessageBox.Show("Do you really want to update this?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("INFORMATION UPDATED");

                    lvList.Enabled = true;

                    txtID.Text = "";
                    txtLN.Enabled = false;
                    txtLN.Text = "";
                    txtFN.Enabled = false;
                    txtFN.Text = "";
                    txtMN.Enabled = false;
                    txtMN.Text = "";
                    txtADDRESS.Enabled = false;
                    txtADDRESS.Text = "";
                    cbYEAR.Enabled = false;
                    cbYEAR.SelectedIndex = -1;
                    cbCOURSE.Enabled = false;
                    cbCOURSE.SelectedIndex = -1;
                    btnNEW.Enabled = true;
                    btnSAVE.Enabled = false;
                    btnCANCEL.Enabled = false;
                    btnEDIT.Enabled = true;
                    btnUPDATE.Enabled = false;
                    btnDELETE.Enabled = false;
                    btnEDIT.Enabled = true;
                    lvList.SelectedIndices.Clear();


                    loadStudents(lvList);
                }

                mySqlConnection.Close();
                mySqlConnection.Dispose();
                mySqlCommand.Dispose();

            }
        }

            

        private void btnDELETE_EnabledChanged(object sender, EventArgs e)
        {
            if (btnDELETE.Enabled)
            {
                // Change the BackColor to a hexadecimal color code
                btnDELETE.BackColor = SystemColors.ControlLightLight; 
            }
            else
            {
                // Change the BackColor to a different color when disabled or as needed
                btnDELETE.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void btnCANCEL_EnabledChanged(object sender, EventArgs e)
        {
            if (btnCANCEL.Enabled)
            {
                // Change the BackColor to a hexadecimal color code
                btnCANCEL.BackColor = SystemColors.ControlLightLight;
            }
            else
            {
                // Change the BackColor to a different color when disabled or as needed
                btnCANCEL.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void btnEDIT_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEDIT.Enabled)
            {
                // Change the BackColor to a hexadecimal color code
                btnEDIT.BackColor = SystemColors.ControlLightLight; 
            }
            else
            {
                // Change the BackColor to a different color when disabled or as needed
                btnEDIT.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void btnSAVE_EnabledChanged(object sender, EventArgs e)
        {
            if (btnSAVE.Enabled)
            {
                // Change the BackColor to a hexadecimal color code
                btnSAVE.BackColor = SystemColors.ControlLightLight; 
            }
            else
            {
                // Change the BackColor to a different color when disabled or as needed
                btnSAVE.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void btnNEW_EnabledChanged(object sender, EventArgs e)
        {
            if (btnNEW.Enabled)
            {
                // Change the BackColor to a hexadecimal color code
                btnNEW.BackColor = SystemColors.ControlLightLight; 
            }
            else
            {
                // Change the BackColor to a different color when disabled or as needed
                btnNEW.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            btnSAVE.Enabled = false;
            btnCANCEL.Enabled = false;
            btnNEW.Enabled = true;


            int id = Convert.ToInt32(txtID.Text);
            string lname = txtLN.Text;
            string fname = txtFN.Text;
            string mname = txtMN.Text;
            string address = txtADDRESS.Text;
            string course = cbCOURSE.Text;
            string year = cbYEAR.Text;

            if (IsAnyFieldEmpty())
            {
                MessageBox.Show("Missing information", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSAVE.Enabled = true;
                btnNEW.Enabled = false;
                btnCANCEL.Enabled = true;
            }

            else
            {
               
                string sql = "INSERT INTO student_tbl (ID, lastname, firstname, middlename, address, course, year) VALUES " +
                "('" + id + "', '" + lname + "','" + fname + "', '" + mname + "', '" + address + "', '" + course + "', '" + year + "')";

                mySqlConnection = new MySqlConnection(mycon);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand(sql, mySqlConnection);

  
                if (mySqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("RECORD ADDED");

                    lvList.Enabled = true;

                    txtID.Text = "";
                    txtLN.Enabled = false;
                    txtLN.Text = "";
                    txtFN.Enabled = false;
                    txtFN.Text = "";
                    txtMN.Enabled = false;
                    txtMN.Text = "";
                    txtADDRESS.Enabled = false;
                    txtADDRESS.Text = "";
                    cbYEAR.Enabled = false;
                    cbYEAR.SelectedIndex = -1;
                    cbCOURSE.Enabled = false;
                    cbCOURSE.SelectedIndex = -1;
                    btnNEW.Enabled = true;
                    btnSAVE.Enabled = false;
                    btnCANCEL.Enabled = false;
                    btnEDIT.Enabled = true;
                    btnUPDATE.Enabled = false;
                    btnDELETE.Enabled = false;
                    btnEDIT.Enabled = false;
                  

                    loadStudents(lvList);
                }
                else
                {
                    MessageBox.Show("Error encounter");
                }

                mySqlDataReader.Close();
                mySqlCommand.Dispose();
                mySqlConnection.Close();
                mySqlConnection.Dispose();

            }





        }

        private void loadStudents(System.Windows.Forms.ListView lvList)
        {
            string sql = "SELECT * FROM student_tbl ORDER BY id";
            mySqlConnection = new MySqlConnection(mycon);
            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlDataReader = mySqlCommand.ExecuteReader();

            lvList.Items.Clear();
            if (mySqlDataReader.HasRows)
            {
                while (mySqlDataReader.Read())
                {
                    lvList.Items.Add(mySqlDataReader[0].ToString());

                    for (int i = 1; i < mySqlDataReader.FieldCount; i++)
                    {
                        lvList.Items[lvList.Items.Count - 1].SubItems.Add(mySqlDataReader[i].ToString());
                    }
                }
            }

            mySqlConnection.Close();
            mySqlConnection.Dispose();
            mySqlDataReader.Close();
        }

        private void loadCourses(System.Windows.Forms.ComboBox cbCOURSES)
        {
            cbCOURSE.Items.Clear();
            string sql = "SELECT * FROM coursetbl";

            mySqlConnection = new MySqlConnection(mycon);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                cbCOURSES.Items.Add(mySqlDataReader[1].ToString());
            }

            mySqlConnection.Close();
            mySqlConnection.Dispose();

        }


        private void txtLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtMN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void lvList_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {

        }

        private void lvList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.lvList.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void lvList_ItemDrag(object sender, ItemDragEventArgs e)
        {
            
        }

        private void lvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvList.SelectedItems.Count == 0)
            {
                btnEDIT.Enabled = false; // Disable the button if nothing is selected
            }
            else
            {
                btnEDIT.Enabled = true; // Enable the button if something is selected
            }
        }

        private void lvList_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem listViewItem = lvList.SelectedItems[0];
            txtID.Text = listViewItem.Text;
            txtLN.Text = listViewItem.SubItems[1].Text;
            txtFN.Text = listViewItem.SubItems[2].Text;
            txtMN.Text = listViewItem.SubItems[3].Text;
            txtADDRESS.Text = listViewItem.SubItems[4].Text;
            cbCOURSE.Text = listViewItem.SubItems[5].Text;
            cbYEAR.Text = listViewItem.SubItems[6].Text;
            btnUPDATE.Enabled = false;
            btnNEW.Enabled = false;
            btnSAVE.Enabled = false;
           
            btnCANCEL.Enabled = true;
            btnDELETE.Enabled = true;
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            
  
                txtLN.Enabled = true;
                txtFN.Enabled = true;
                txtMN.Enabled = true;
                btnUPDATE.Enabled = true;
                txtADDRESS.Enabled = true;
                cbCOURSE.Enabled = true;
                cbYEAR.Enabled = true;
                lvList.Enabled = false;
                 btnEDIT.Enabled = false;
 
            
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            lvList.Enabled = true;

            txtID.Text = "";
            txtLN.Enabled = false;
            txtLN.Text = "";
            txtFN.Enabled = false;
            txtFN.Text = "";
            txtMN.Enabled = false;
            txtMN.Text = "";
            txtADDRESS.Enabled = false;
            txtADDRESS.Text = "";
            cbYEAR.Enabled = false;
            cbYEAR.SelectedIndex = -1;
            cbCOURSE.Enabled = false;
            cbCOURSE.SelectedIndex = -1;
            btnNEW.Enabled = true;
            btnSAVE.Enabled = false;
            btnCANCEL.Enabled = false;  
            btnUPDATE.Enabled = false;
            btnDELETE.Enabled = false;
            btnEDIT.Enabled = false;
            lvList.SelectedIndices.Clear();

        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
           
            string lname = txtLN.Text;
          

            DialogResult delete = MessageBox.Show("Do you really want to delete " + lname + "'s information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (delete == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtID.Text);
                string sql = "DELETE FROM student_tbl WHERE ID = " + id + "";

                mySqlConnection = new MySqlConnection(mycon);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                loadStudents(lvList);

                lvList.Enabled = true;

                txtID.Text = "";
                txtLN.Enabled = false;
                txtLN.Text = "";
                txtFN.Enabled = false;
                txtFN.Text = "";
                txtMN.Enabled = false;
                txtMN.Text = "";
                txtADDRESS.Enabled = false;
                txtADDRESS.Text = "";
                cbYEAR.Enabled = false;
                cbYEAR.SelectedIndex = -1;
                cbCOURSE.Enabled = false;
                cbCOURSE.SelectedIndex = -1;
                btnNEW.Enabled = true;
                btnSAVE.Enabled = false;
                btnCANCEL.Enabled = false;
                btnEDIT.Enabled = false;
                btnUPDATE.Enabled = false;
                btnDELETE.Enabled = false;
               
                lvList.SelectedIndices.Clear();

                mySqlConnection.Close();
                mySqlConnection.Dispose();

                mySqlCommand.Dispose();
            }
        }


        private int getLastID()
        {
            int sID = 0;
            string sql = "SELECT * FROM student_tbl ORDER BY id DESC";
            mySqlConnection = new MySqlConnection(mycon);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.HasRows)
            {
                while (mySqlDataReader.Read())
                {
                    sID = int.Parse(mySqlDataReader[0].ToString());
                    break;
                }
            }
            mySqlConnection.Close();
            mySqlConnection.Dispose();

            return sID + 1;

        }

        private void lvList_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem = lvList.SelectedItems[0];
            txtID.Text = listViewItem.Text;
            txtLN.Text = listViewItem.SubItems[1].Text;
            txtFN.Text = listViewItem.SubItems[2].Text;
            txtMN.Text = listViewItem.SubItems[3].Text;
            txtADDRESS.Text = listViewItem.SubItems[4].Text;
            cbCOURSE.Text = listViewItem.SubItems[5].Text;
            cbYEAR.Text = listViewItem.SubItems[6].Text;
            btnUPDATE.Enabled = false;
            btnNEW.Enabled = false;
            btnSAVE.Enabled = false;

            btnCANCEL.Enabled = true;
            btnDELETE.Enabled = true;
        }


        private bool IsAnyFieldEmpty()
        {
            // Check if any of the textboxes or comboboxes is empty
            if (string.IsNullOrWhiteSpace(txtLN.Text) ||
                string.IsNullOrWhiteSpace(txtFN.Text) ||
                string.IsNullOrWhiteSpace(txtMN.Text) ||
                string.IsNullOrWhiteSpace(txtADDRESS.Text) ||
                string.IsNullOrWhiteSpace(cbYEAR.Text) ||
                string.IsNullOrWhiteSpace(cbCOURSE.Text))
            {
                return true; // At least one field is empty
            }

            return false; // All fields have values
        }
    }



}
