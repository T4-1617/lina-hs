namespace CarRental0915_01
{
    partial class CarRental
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
            this.lblNumAvailableCars = new System.Windows.Forms.Label();
            this.btnShowRentPanel = new System.Windows.Forms.Button();
            this.btnShowAddPanel = new System.Windows.Forms.Button();
            this.btnShowReturnPanel = new System.Windows.Forms.Button();
            this.pnlRent = new System.Windows.Forms.Panel();
            this.lblRentCars = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.lstAvailableCars = new System.Windows.Forms.ListBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddColor = new System.Windows.Forms.TextBox();
            this.tbxAddModel = new System.Windows.Forms.TextBox();
            this.lblAddColor = new System.Windows.Forms.Label();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.lblAddMake = new System.Windows.Forms.Label();
            this.tbxAddMake = new System.Windows.Forms.TextBox();
            this.pnlReturn = new System.Windows.Forms.Panel();
            this.lblReturnCars = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstRentedCars = new System.Windows.Forms.ListBox();
            this.pnlRentThank = new System.Windows.Forms.Panel();
            this.lblRentThank = new System.Windows.Forms.Label();
            this.pnlReturnThank = new System.Windows.Forms.Panel();
            this.lblReturnThank = new System.Windows.Forms.Label();
            this.lblRentFName = new System.Windows.Forms.Label();
            this.tbxRentFName = new System.Windows.Forms.TextBox();
            this.tbxRentLName = new System.Windows.Forms.TextBox();
            this.lblRentLName = new System.Windows.Forms.Label();
            this.pnlRent.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlReturn.SuspendLayout();
            this.pnlRentThank.SuspendLayout();
            this.pnlReturnThank.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumAvailableCars
            // 
            this.lblNumAvailableCars.AutoSize = true;
            this.lblNumAvailableCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumAvailableCars.Location = new System.Drawing.Point(12, 28);
            this.lblNumAvailableCars.Name = "lblNumAvailableCars";
            this.lblNumAvailableCars.Size = new System.Drawing.Size(275, 26);
            this.lblNumAvailableCars.TabIndex = 0;
            this.lblNumAvailableCars.Text = "We have {0} cars available.";
            // 
            // btnShowRentPanel
            // 
            this.btnShowRentPanel.Location = new System.Drawing.Point(17, 73);
            this.btnShowRentPanel.Name = "btnShowRentPanel";
            this.btnShowRentPanel.Size = new System.Drawing.Size(123, 54);
            this.btnShowRentPanel.TabIndex = 1;
            this.btnShowRentPanel.Text = "Rent Car";
            this.btnShowRentPanel.UseVisualStyleBackColor = true;
            this.btnShowRentPanel.Click += new System.EventHandler(this.btnShowRentPanel_Click);
            // 
            // btnShowAddPanel
            // 
            this.btnShowAddPanel.Location = new System.Drawing.Point(164, 73);
            this.btnShowAddPanel.Name = "btnShowAddPanel";
            this.btnShowAddPanel.Size = new System.Drawing.Size(123, 54);
            this.btnShowAddPanel.TabIndex = 2;
            this.btnShowAddPanel.Text = "Add Car";
            this.btnShowAddPanel.UseVisualStyleBackColor = true;
            this.btnShowAddPanel.Click += new System.EventHandler(this.btnShowAddPanel_Click);
            // 
            // btnShowReturnPanel
            // 
            this.btnShowReturnPanel.Location = new System.Drawing.Point(321, 73);
            this.btnShowReturnPanel.Name = "btnShowReturnPanel";
            this.btnShowReturnPanel.Size = new System.Drawing.Size(123, 54);
            this.btnShowReturnPanel.TabIndex = 3;
            this.btnShowReturnPanel.Text = "Return Car";
            this.btnShowReturnPanel.UseVisualStyleBackColor = true;
            this.btnShowReturnPanel.Click += new System.EventHandler(this.btnShowReturnPanel_Click);
            // 
            // pnlRent
            // 
            this.pnlRent.Controls.Add(this.tbxRentLName);
            this.pnlRent.Controls.Add(this.lblRentLName);
            this.pnlRent.Controls.Add(this.tbxRentFName);
            this.pnlRent.Controls.Add(this.lblRentFName);
            this.pnlRent.Controls.Add(this.lblRentCars);
            this.pnlRent.Controls.Add(this.btnRent);
            this.pnlRent.Controls.Add(this.lstAvailableCars);
            this.pnlRent.Location = new System.Drawing.Point(17, 133);
            this.pnlRent.Name = "pnlRent";
            this.pnlRent.Size = new System.Drawing.Size(632, 239);
            this.pnlRent.TabIndex = 4;
            // 
            // lblRentCars
            // 
            this.lblRentCars.AutoSize = true;
            this.lblRentCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentCars.Location = new System.Drawing.Point(9, 12);
            this.lblRentCars.Name = "lblRentCars";
            this.lblRentCars.Size = new System.Drawing.Size(97, 20);
            this.lblRentCars.TabIndex = 3;
            this.lblRentCars.Text = "Cars for rent";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(450, 166);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(167, 58);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lstAvailableCars
            // 
            this.lstAvailableCars.FormattingEnabled = true;
            this.lstAvailableCars.Location = new System.Drawing.Point(13, 38);
            this.lstAvailableCars.Name = "lstAvailableCars";
            this.lstAvailableCars.Size = new System.Drawing.Size(414, 186);
            this.lstAvailableCars.TabIndex = 0;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Controls.Add(this.tbxAddColor);
            this.pnlAdd.Controls.Add(this.tbxAddModel);
            this.pnlAdd.Controls.Add(this.lblAddColor);
            this.pnlAdd.Controls.Add(this.lblAddModel);
            this.pnlAdd.Controls.Add(this.lblAddMake);
            this.pnlAdd.Controls.Add(this.tbxAddMake);
            this.pnlAdd.Location = new System.Drawing.Point(17, 133);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(632, 239);
            this.pnlAdd.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddColor
            // 
            this.tbxAddColor.Location = new System.Drawing.Point(283, 102);
            this.tbxAddColor.Name = "tbxAddColor";
            this.tbxAddColor.Size = new System.Drawing.Size(100, 20);
            this.tbxAddColor.TabIndex = 5;
            // 
            // tbxAddModel
            // 
            this.tbxAddModel.Location = new System.Drawing.Point(283, 69);
            this.tbxAddModel.Name = "tbxAddModel";
            this.tbxAddModel.Size = new System.Drawing.Size(100, 20);
            this.tbxAddModel.TabIndex = 4;
            // 
            // lblAddColor
            // 
            this.lblAddColor.AutoSize = true;
            this.lblAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddColor.Location = new System.Drawing.Point(221, 102);
            this.lblAddColor.Name = "lblAddColor";
            this.lblAddColor.Size = new System.Drawing.Size(45, 17);
            this.lblAddColor.TabIndex = 3;
            this.lblAddColor.Text = "Color:";
            // 
            // lblAddModel
            // 
            this.lblAddModel.AutoSize = true;
            this.lblAddModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModel.Location = new System.Drawing.Point(221, 69);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(50, 17);
            this.lblAddModel.TabIndex = 2;
            this.lblAddModel.Text = "Model:";
            // 
            // lblAddMake
            // 
            this.lblAddMake.AutoSize = true;
            this.lblAddMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMake.Location = new System.Drawing.Point(221, 33);
            this.lblAddMake.Name = "lblAddMake";
            this.lblAddMake.Size = new System.Drawing.Size(46, 17);
            this.lblAddMake.TabIndex = 1;
            this.lblAddMake.Text = "Make:";
            // 
            // tbxAddMake
            // 
            this.tbxAddMake.Location = new System.Drawing.Point(283, 30);
            this.tbxAddMake.Name = "tbxAddMake";
            this.tbxAddMake.Size = new System.Drawing.Size(100, 20);
            this.tbxAddMake.TabIndex = 0;
            // 
            // pnlReturn
            // 
            this.pnlReturn.Controls.Add(this.lblReturnCars);
            this.pnlReturn.Controls.Add(this.btnReturn);
            this.pnlReturn.Controls.Add(this.lstRentedCars);
            this.pnlReturn.Location = new System.Drawing.Point(17, 133);
            this.pnlReturn.Name = "pnlReturn";
            this.pnlReturn.Size = new System.Drawing.Size(632, 239);
            this.pnlReturn.TabIndex = 5;
            // 
            // lblReturnCars
            // 
            this.lblReturnCars.AutoSize = true;
            this.lblReturnCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnCars.Location = new System.Drawing.Point(9, 12);
            this.lblReturnCars.Name = "lblReturnCars";
            this.lblReturnCars.Size = new System.Drawing.Size(211, 20);
            this.lblReturnCars.TabIndex = 2;
            this.lblReturnCars.Text = "Which car are you returning?";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(450, 166);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(167, 58);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstRentedCars
            // 
            this.lstRentedCars.FormattingEnabled = true;
            this.lstRentedCars.Location = new System.Drawing.Point(13, 38);
            this.lstRentedCars.Name = "lstRentedCars";
            this.lstRentedCars.Size = new System.Drawing.Size(414, 186);
            this.lstRentedCars.TabIndex = 0;
            // 
            // pnlRentThank
            // 
            this.pnlRentThank.Controls.Add(this.lblRentThank);
            this.pnlRentThank.Location = new System.Drawing.Point(17, 133);
            this.pnlRentThank.Name = "pnlRentThank";
            this.pnlRentThank.Size = new System.Drawing.Size(632, 239);
            this.pnlRentThank.TabIndex = 5;
            // 
            // lblRentThank
            // 
            this.lblRentThank.AutoSize = true;
            this.lblRentThank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentThank.Location = new System.Drawing.Point(219, 66);
            this.lblRentThank.Name = "lblRentThank";
            this.lblRentThank.Size = new System.Drawing.Size(162, 20);
            this.lblRentThank.TabIndex = 3;
            this.lblRentThank.Text = "Thank you for renting!";
            // 
            // pnlReturnThank
            // 
            this.pnlReturnThank.Controls.Add(this.lblReturnThank);
            this.pnlReturnThank.Location = new System.Drawing.Point(17, 133);
            this.pnlReturnThank.Name = "pnlReturnThank";
            this.pnlReturnThank.Size = new System.Drawing.Size(632, 239);
            this.pnlReturnThank.TabIndex = 6;
            // 
            // lblReturnThank
            // 
            this.lblReturnThank.AutoSize = true;
            this.lblReturnThank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnThank.Location = new System.Drawing.Point(173, 59);
            this.lblReturnThank.Name = "lblReturnThank";
            this.lblReturnThank.Size = new System.Drawing.Size(271, 20);
            this.lblReturnThank.TabIndex = 3;
            this.lblReturnThank.Text = "Thank you for using ACME car rental!";
            // 
            // lblRentFName
            // 
            this.lblRentFName.AutoSize = true;
            this.lblRentFName.Location = new System.Drawing.Point(441, 44);
            this.lblRentFName.Name = "lblRentFName";
            this.lblRentFName.Size = new System.Drawing.Size(44, 13);
            this.lblRentFName.TabIndex = 4;
            this.lblRentFName.Text = "FName:";
            // 
            // tbxRentFName
            // 
            this.tbxRentFName.Location = new System.Drawing.Point(491, 39);
            this.tbxRentFName.Name = "tbxRentFName";
            this.tbxRentFName.Size = new System.Drawing.Size(100, 20);
            this.tbxRentFName.TabIndex = 5;
            // 
            // tbxRentLName
            // 
            this.tbxRentLName.Location = new System.Drawing.Point(491, 69);
            this.tbxRentLName.Name = "tbxRentLName";
            this.tbxRentLName.Size = new System.Drawing.Size(100, 20);
            this.tbxRentLName.TabIndex = 7;
            // 
            // lblRentLName
            // 
            this.lblRentLName.AutoSize = true;
            this.lblRentLName.Location = new System.Drawing.Point(441, 72);
            this.lblRentLName.Name = "lblRentLName";
            this.lblRentLName.Size = new System.Drawing.Size(44, 13);
            this.lblRentLName.TabIndex = 6;
            this.lblRentLName.Text = "LName:";
            // 
            // CarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 388);
            this.Controls.Add(this.pnlReturnThank);
            this.Controls.Add(this.pnlReturn);
            this.Controls.Add(this.pnlRentThank);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlRent);
            this.Controls.Add(this.btnShowReturnPanel);
            this.Controls.Add(this.btnShowAddPanel);
            this.Controls.Add(this.btnShowRentPanel);
            this.Controls.Add(this.lblNumAvailableCars);
            this.Name = "CarRental";
            this.Text = "ACME Cars";
            this.pnlRent.ResumeLayout(false);
            this.pnlRent.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlReturn.ResumeLayout(false);
            this.pnlReturn.PerformLayout();
            this.pnlRentThank.ResumeLayout(false);
            this.pnlRentThank.PerformLayout();
            this.pnlReturnThank.ResumeLayout(false);
            this.pnlReturnThank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumAvailableCars;
        private System.Windows.Forms.Button btnShowRentPanel;
        private System.Windows.Forms.Button btnShowAddPanel;
        private System.Windows.Forms.Button btnShowReturnPanel;
        private System.Windows.Forms.Panel pnlRent;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.ListBox lstAvailableCars;
        private System.Windows.Forms.Label lblRentCars;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxAddColor;
        private System.Windows.Forms.TextBox tbxAddModel;
        private System.Windows.Forms.Label lblAddColor;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.Label lblAddMake;
        private System.Windows.Forms.TextBox tbxAddMake;
        private System.Windows.Forms.Panel pnlReturn;
        private System.Windows.Forms.Label lblReturnCars;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstRentedCars;
        private System.Windows.Forms.Panel pnlRentThank;
        private System.Windows.Forms.Label lblRentThank;
        private System.Windows.Forms.Panel pnlReturnThank;
        private System.Windows.Forms.Label lblReturnThank;
        private System.Windows.Forms.TextBox tbxRentLName;
        private System.Windows.Forms.Label lblRentLName;
        private System.Windows.Forms.TextBox tbxRentFName;
        private System.Windows.Forms.Label lblRentFName;
    }
}

