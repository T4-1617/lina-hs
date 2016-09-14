namespace CarRental0914_01
{
    partial class Form1
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
            this.lstCars = new System.Windows.Forms.ListBox();
            this.pnlCarInfo = new System.Windows.Forms.Panel();
            this.lblRegNO = new System.Windows.Forms.Label();
            this.lblHired = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegNO = new System.Windows.Forms.TextBox();
            this.txtHired = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.pnlCarInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.Location = new System.Drawing.Point(12, 47);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(242, 290);
            this.lstCars.TabIndex = 0;
            // 
            // pnlCarInfo
            // 
            this.pnlCarInfo.Controls.Add(this.txtMake);
            this.pnlCarInfo.Controls.Add(this.lblMake);
            this.pnlCarInfo.Controls.Add(this.txtGroup);
            this.pnlCarInfo.Controls.Add(this.txtHired);
            this.pnlCarInfo.Controls.Add(this.txtRegNO);
            this.pnlCarInfo.Controls.Add(this.label1);
            this.pnlCarInfo.Controls.Add(this.lblHired);
            this.pnlCarInfo.Controls.Add(this.lblRegNO);
            this.pnlCarInfo.Location = new System.Drawing.Point(260, 47);
            this.pnlCarInfo.Name = "pnlCarInfo";
            this.pnlCarInfo.Size = new System.Drawing.Size(567, 290);
            this.pnlCarInfo.TabIndex = 1;
            // 
            // lblRegNO
            // 
            this.lblRegNO.AutoSize = true;
            this.lblRegNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNO.Location = new System.Drawing.Point(71, 69);
            this.lblRegNO.Name = "lblRegNO";
            this.lblRegNO.Size = new System.Drawing.Size(67, 17);
            this.lblRegNO.TabIndex = 1;
            this.lblRegNO.Text = "Reg. NO:";
            // 
            // lblHired
            // 
            this.lblHired.AutoSize = true;
            this.lblHired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHired.Location = new System.Drawing.Point(71, 102);
            this.lblHired.Name = "lblHired";
            this.lblHired.Size = new System.Drawing.Size(46, 17);
            this.lblHired.TabIndex = 2;
            this.lblHired.Text = "Hired:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Group:";
            // 
            // txtRegNO
            // 
            this.txtRegNO.Location = new System.Drawing.Point(161, 69);
            this.txtRegNO.Name = "txtRegNO";
            this.txtRegNO.Size = new System.Drawing.Size(100, 20);
            this.txtRegNO.TabIndex = 4;
            // 
            // txtHired
            // 
            this.txtHired.Location = new System.Drawing.Point(161, 102);
            this.txtHired.Name = "txtHired";
            this.txtHired.Size = new System.Drawing.Size(100, 20);
            this.txtHired.TabIndex = 5;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(161, 133);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(100, 20);
            this.txtGroup.TabIndex = 6;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(71, 37);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 17);
            this.lblMake.TabIndex = 7;
            this.lblMake.Text = "Make:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(161, 34);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 357);
            this.Controls.Add(this.pnlCarInfo);
            this.Controls.Add(this.lstCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCarInfo.ResumeLayout(false);
            this.pnlCarInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Panel pnlCarInfo;
        private System.Windows.Forms.Label lblRegNO;
        private System.Windows.Forms.Label lblHired;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtHired;
        private System.Windows.Forms.TextBox txtRegNO;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMake;
    }
}

