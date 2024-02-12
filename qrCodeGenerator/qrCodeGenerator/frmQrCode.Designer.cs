namespace qrCodeGenerator
{
    partial class frmQrCode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAppExit = new System.Windows.Forms.Button();
            this.picbQrCode = new System.Windows.Forms.PictureBox();
            this.txtbQrCodeData = new System.Windows.Forms.TextBox();
            this.btnQrCodeGenerate = new System.Windows.Forms.Button();
            this.btnQrSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbQrCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnAppExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnAppExit
            // 
            this.btnAppExit.FlatAppearance.BorderSize = 0;
            this.btnAppExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAppExit.ForeColor = System.Drawing.Color.White;
            this.btnAppExit.Location = new System.Drawing.Point(629, 3);
            this.btnAppExit.Name = "btnAppExit";
            this.btnAppExit.Size = new System.Drawing.Size(50, 44);
            this.btnAppExit.TabIndex = 0;
            this.btnAppExit.Text = "X";
            this.btnAppExit.UseVisualStyleBackColor = true;
            this.btnAppExit.Click += new System.EventHandler(this.btnAppExit_Click);
            // 
            // picbQrCode
            // 
            this.picbQrCode.Location = new System.Drawing.Point(12, 56);
            this.picbQrCode.Name = "picbQrCode";
            this.picbQrCode.Size = new System.Drawing.Size(658, 277);
            this.picbQrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbQrCode.TabIndex = 1;
            this.picbQrCode.TabStop = false;
            // 
            // txtbQrCodeData
            // 
            this.txtbQrCodeData.Location = new System.Drawing.Point(12, 339);
            this.txtbQrCodeData.Multiline = true;
            this.txtbQrCodeData.Name = "txtbQrCodeData";
            this.txtbQrCodeData.Size = new System.Drawing.Size(658, 33);
            this.txtbQrCodeData.TabIndex = 2;
            // 
            // btnQrCodeGenerate
            // 
            this.btnQrCodeGenerate.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQrCodeGenerate.FlatAppearance.BorderSize = 0;
            this.btnQrCodeGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrCodeGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQrCodeGenerate.ForeColor = System.Drawing.Color.White;
            this.btnQrCodeGenerate.Location = new System.Drawing.Point(135, 378);
            this.btnQrCodeGenerate.Name = "btnQrCodeGenerate";
            this.btnQrCodeGenerate.Size = new System.Drawing.Size(152, 63);
            this.btnQrCodeGenerate.TabIndex = 3;
            this.btnQrCodeGenerate.Text = "GENERATE";
            this.btnQrCodeGenerate.UseVisualStyleBackColor = false;
            this.btnQrCodeGenerate.Click += new System.EventHandler(this.btnQrCodeGenerate_Click);
            // 
            // btnQrSave
            // 
            this.btnQrSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnQrSave.FlatAppearance.BorderSize = 0;
            this.btnQrSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQrSave.ForeColor = System.Drawing.Color.White;
            this.btnQrSave.Location = new System.Drawing.Point(363, 378);
            this.btnQrSave.Name = "btnQrSave";
            this.btnQrSave.Size = new System.Drawing.Size(152, 63);
            this.btnQrSave.TabIndex = 4;
            this.btnQrSave.Text = "SAVE";
            this.btnQrSave.UseVisualStyleBackColor = false;
            this.btnQrSave.Click += new System.EventHandler(this.btnQrSave_Click);
            // 
            // frmQrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btnQrSave);
            this.Controls.Add(this.btnQrCodeGenerate);
            this.Controls.Add(this.txtbQrCodeData);
            this.Controls.Add(this.picbQrCode);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQrCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR CODE GENERATOR";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbQrCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAppExit;
        private System.Windows.Forms.PictureBox picbQrCode;
        private System.Windows.Forms.TextBox txtbQrCodeData;
        private System.Windows.Forms.Button btnQrCodeGenerate;
        private System.Windows.Forms.Button btnQrSave;
    }
}

