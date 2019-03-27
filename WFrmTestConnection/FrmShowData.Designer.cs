namespace WFrmTestConnection
{
    partial class FrmShowData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxShowData = new System.Windows.Forms.GroupBox();
            this.dataGridViewPersonalData = new System.Windows.Forms.DataGridView();
            this.grpBoxShowData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonalData)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxShowData
            // 
            this.grpBoxShowData.Controls.Add(this.dataGridViewPersonalData);
            this.grpBoxShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxShowData.Location = new System.Drawing.Point(12, 12);
            this.grpBoxShowData.Name = "grpBoxShowData";
            this.grpBoxShowData.Size = new System.Drawing.Size(633, 284);
            this.grpBoxShowData.TabIndex = 0;
            this.grpBoxShowData.TabStop = false;
            this.grpBoxShowData.Text = "Show personal data";
            // 
            // dataGridViewPersonalData
            // 
            this.dataGridViewPersonalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonalData.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewPersonalData.Name = "dataGridViewPersonalData";
            this.dataGridViewPersonalData.Size = new System.Drawing.Size(621, 253);
            this.dataGridViewPersonalData.TabIndex = 0;
            // 
            // FrmShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 308);
            this.Controls.Add(this.grpBoxShowData);
            this.MaximizeBox = false;
            this.Name = "FrmShowData";
            this.Text = "Show data";
            this.Load += new System.EventHandler(this.FrmShowData_Load);
            this.grpBoxShowData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonalData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxShowData;
        private System.Windows.Forms.DataGridView dataGridViewPersonalData;
    }
}