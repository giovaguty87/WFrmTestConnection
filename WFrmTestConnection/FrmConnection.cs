
using System;
using System.Windows.Forms;
using WFrmTestConnection.Dao;

namespace WFrmTestConnection
{
    public partial class FrmConnection : Form
    {
        public FrmConnection()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtBoxAddress.Text) || string.IsNullOrEmpty(this.txtBoxName.Text) || string.IsNullOrEmpty(this.txtBoxEmail.Text) || string.IsNullOrEmpty(this.txtBoxLastName.Text) || string.IsNullOrEmpty(this.txtBoxPhone.Text))
                {
                    this.lblResponse.Text = "Error, please type mandatory information...!";
                }
                else
                {
                    this.lblResponse.Text = string.Empty;

                    ProcessDao Process = new ProcessDao();
                    var resp = Process.SavePersonalData(this.txtBoxName.Text, this.txtBoxLastName.Text, this.txtBoxAddress.Text, this.txtBoxPhone.Text, this.txtBoxEmail.Text);

                    if(resp > 0)
                    {
                        this.lblResponse.Text = "Personal data saved successfully...!";
                        ClearInformation();
                    }   
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

        private void FrmConnection_Load(object sender, EventArgs e)
        {
            this.lblResponse.Text = string.Empty;
        }

        private void ClearInformation()
        {
            this.txtBoxName.Text = string.Empty;
            this.txtBoxLastName.Text = string.Empty;
            this.txtBoxAddress.Text = string.Empty;
            this.txtBoxPhone.Text = string.Empty;
            this.txtBoxEmail.Text = string.Empty;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmShowData frmShow = new FrmShowData();
            frmShow.Show();
        }
    }
}