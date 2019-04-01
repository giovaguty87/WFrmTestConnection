
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WFrmTestConnection.Dao;

namespace WFrmTestConnection
{
    public partial class FrmShowData : Form
    {
        DataGridViewCheckBoxColumn _deleteColumn = new DataGridViewCheckBoxColumn();

        public FrmShowData()
        {
            InitializeComponent();
        }

        private void FrmShowData_Load(object sender, EventArgs e)
        {
            //Column for delete
            InitializeCheckColumn();

            LoadPersonalData();
        }

        private void LoadPersonalData()
        {
            ProcessDao Process = new ProcessDao();

            try
            {
                var lstPersonalData = Process.GetPersonalData();

                if (lstPersonalData.Tables.Count != 0)
                {
                    //DataSet isn't empty
                    this.dataGridViewPersonalData.AutoGenerateColumns = true;
                    this.dataGridViewPersonalData.DataSource = lstPersonalData.Tables[0];
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void InitializeCheckColumn()
        {
            _deleteColumn.Name = "Delete";
            _deleteColumn.FalseValue = 0;
            _deleteColumn.TrueValue = 1;
            _deleteColumn.Visible = true;
            
            // add the new column to your dataGridView 
            this.dataGridViewPersonalData.Columns.Add(_deleteColumn);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int resp = 0;
            List<string> lstSelected = new List<string>();

            try
            {
                foreach (DataGridViewRow row in dataGridViewPersonalData.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["Delete"].Value);

                    if (isSelected)
                    {
                        lstSelected.Add(row.Cells["Id"].Value.ToString());
                    }
                }

                if (lstSelected == null)
                    MessageBox.Show("Please select at least one record for delete...!");
                else
                {
                    ProcessDao process = new ProcessDao();
                    resp = process.DeletePersonalData(lstSelected);
                }

                if(resp > 0)
                {
                    LoadPersonalData();
                    MessageBox.Show("The database has been updated.");
                } 
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}