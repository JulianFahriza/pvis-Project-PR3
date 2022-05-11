namespace Project_2
{
    partial class FormHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnInputDataTas = new System.Windows.Forms.Button();
            this.btnCekData = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(334, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thrift me and You Inventory System";
            // 
            // btnInputDataTas
            // 
            this.btnInputDataTas.BackColor = System.Drawing.Color.Gold;
            this.btnInputDataTas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputDataTas.Location = new System.Drawing.Point(439, 147);
            this.btnInputDataTas.Name = "btnInputDataTas";
            this.btnInputDataTas.Size = new System.Drawing.Size(135, 39);
            this.btnInputDataTas.TabIndex = 2;
            this.btnInputDataTas.Text = "Input Data Tas";
            this.btnInputDataTas.UseVisualStyleBackColor = false;
            this.btnInputDataTas.Click += new System.EventHandler(this.btnInputDataTas_Click);
            // 
            // btnCekData
            // 
            this.btnCekData.BackColor = System.Drawing.Color.Gold;
            this.btnCekData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCekData.Location = new System.Drawing.Point(439, 222);
            this.btnCekData.Name = "btnCekData";
            this.btnCekData.Size = new System.Drawing.Size(135, 39);
            this.btnCekData.TabIndex = 3;
            this.btnCekData.Text = "Cek Data Tas";
            this.btnCekData.UseVisualStyleBackColor = false;
            this.btnCekData.Click += new System.EventHandler(this.btnCekDataTas_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Red;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(470, 338);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1064, 481);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCekData);
            this.Controls.Add(this.btnInputDataTas);
            this.Controls.Add(this.label1);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInputDataTas;
        private System.Windows.Forms.Button btnCekData;
        private System.Windows.Forms.Button btnLogOut;
    }
}