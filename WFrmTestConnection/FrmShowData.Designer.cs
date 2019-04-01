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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(570, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(489, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 329);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}