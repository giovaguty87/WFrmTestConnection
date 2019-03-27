
using System;
using System.Windows.Forms;
using WFrmTestConnection.Dao;

namespace WFrmTestConnection
{
    public partial class FrmShowData : Form
    {
        public FrmShowData()
        {
            InitializeComponent();
        }

        private void FrmShowData_Load(object sender, EventArgs e)
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
    }
}
