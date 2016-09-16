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
            this.lblCarNum = new System.Windows.Forms.Label();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.pnlRentCar = new System.Windows.Forms.Panel();
            this.lblAvailableCars = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.lstAvailableCars = new System.Windows.Forms.ListBox();
            this.pnlAddCar = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddColor = new System.Windows.Forms.TextBox();
            this.tbxAddModel = new System.Windows.Forms.TextBox();
            this.lblAddColor = new System.Windows.Forms.Label();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.lblAddMake = new System.Windows.Forms.Label();
            this.tbxAddMake = new System.Windows.Forms.TextBox();
            this.pnlReturnCar = new System.Windows.Forms.Panel();
            this.lblReturnCars = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lstReturnCars = new System.Windows.Forms.ListBox();
            this.pnlRentThank = new System.Windows.Forms.Panel();
            this.lblRentThank = new System.Windows.Forms.Label();
            this.pnlReturnThank = new System.Windows.Forms.Panel();
            this.lblReturnThank = new System.Windows.Forms.Label();
            this.pnlRentCar.SuspendLayout();
            this.pnlAddCar.SuspendLayout();
            this.pnlReturnCar.SuspendLayout();
            this.pnlRentThank.SuspendLayout();
            this.pnlReturnThank.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCarNum
            // 
            this.lblCarNum.AutoSize = true;
            this.lblCarNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarNum.Location = new System.Drawing.Point(12, 28);
            this.lblCarNum.Name = "lblCarNum";
            this.lblCarNum.Size = new System.Drawing.Size(275, 26);
            this.lblCarNum.TabIndex = 0;
            this.lblCarNum.Text = "We have {0} cars available.";
            // 
            // btnRentCar
            // 
            this.btnRentCar.Location = new System.Drawing.Point(17, 73);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(123, 54);
            this.btnRentCar.TabIndex = 1;
            this.btnRentCar.Text = "Rent Car";
            this.btnRentCar.UseVisualStyleBackColor = true;
            this.btnRentCar.Click += new System.EventHandler(this.btnRentCar_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(164, 73);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(123, 54);
            this.btnAddCar.TabIndex = 2;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(321, 73);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(123, 54);
            this.btnReturnCar.TabIndex = 3;
            this.btnReturnCar.Text = "Return Car";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // pnlRentCar
            // 
            this.pnlRentCar.Controls.Add(this.lblAvailableCars);
            this.pnlRentCar.Controls.Add(this.btnRent);
            this.pnlRentCar.Controls.Add(this.lstAvailableCars);
            this.pnlRentCar.Location = new System.Drawing.Point(17, 133);
            this.pnlRentCar.Name = "pnlRentCar";
            this.pnlRentCar.Size = new System.Drawing.Size(632, 239);
            this.pnlRentCar.TabIndex = 4;
            // 
            // lblAvailableCars
            // 
            this.lblAvailableCars.AutoSize = true;
            this.lblAvailableCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCars.Location = new System.Drawing.Point(9, 12);
            this.lblAvailableCars.Name = "lblAvailableCars";
            this.lblAvailableCars.Size = new System.Drawing.Size(106, 20);
            this.lblAvailableCars.TabIndex = 3;
            this.lblAvailableCars.Text = "Available cars";
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
            // pnlAddCar
            // 
            this.pnlAddCar.Controls.Add(this.btnAdd);
            this.pnlAddCar.Controls.Add(this.tbxAddColor);
            this.pnlAddCar.Controls.Add(this.tbxAddModel);
            this.pnlAddCar.Controls.Add(this.lblAddColor);
            this.pnlAddCar.Controls.Add(this.lblAddModel);
            this.pnlAddCar.Controls.Add(this.lblAddMake);
            this.pnlAddCar.Controls.Add(this.tbxAddMake);
            this.pnlAddCar.Location = new System.Drawing.Point(17, 133);
            this.pnlAddCar.Name = "pnlAddCar";
            this.pnlAddCar.Size = new System.Drawing.Size(632, 239);
            this.pnlAddCar.TabIndex = 5;
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
            // pnlReturnCar
            // 
            this.pnlReturnCar.Controls.Add(this.lblReturnCars);
            this.pnlReturnCar.Controls.Add(this.btnReturn);
            this.pnlReturnCar.Controls.Add(this.lstReturnCars);
            this.pnlReturnCar.Location = new System.Drawing.Point(17, 133);
            this.pnlReturnCar.Name = "pnlReturnCar";
            this.pnlReturnCar.Size = new System.Drawing.Size(632, 239);
            this.pnlReturnCar.TabIndex = 5;
            // 
            // lblReturnCars
            // 
            this.lblReturnCars.AutoSize = true;
            this.lblReturnCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnCars.Location = new System.Drawing.Point(9, 12);
            this.lblReturnCars.Name = "lblReturnCars";
            this.lblReturnCars.Size = new System.Drawing.Size(111, 20);
            this.lblReturnCars.TabIndex = 2;
            this.lblReturnCars.Text = "Cars for return";
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
            // lstReturnCars
            // 
            this.lstReturnCars.FormattingEnabled = true;
            this.lstReturnCars.Location = new System.Drawing.Point(13, 38);
            this.lstReturnCars.Name = "lstReturnCars";
            this.lstReturnCars.Size = new System.Drawing.Size(414, 186);
            this.lstReturnCars.TabIndex = 0;
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
            // CarRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 388);
            this.Controls.Add(this.pnlReturnThank);
            this.Controls.Add(this.pnlRentThank);
            this.Controls.Add(this.pnlReturnCar);
            this.Controls.Add(this.pnlAddCar);
            this.Controls.Add(this.pnlRentCar);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnRentCar);
            this.Controls.Add(this.lblCarNum);
            this.Name = "CarRental";
            this.Text = "ACME Cars";
            this.pnlRentCar.ResumeLayout(false);
            this.pnlRentCar.PerformLayout();
            this.pnlAddCar.ResumeLayout(false);
            this.pnlAddCar.PerformLayout();
            this.pnlReturnCar.ResumeLayout(false);
            this.pnlReturnCar.PerformLayout();
            this.pnlRentThank.ResumeLayout(false);
            this.pnlRentThank.PerformLayout();
            this.pnlReturnThank.ResumeLayout(false);
            this.pnlReturnThank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarNum;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Panel pnlRentCar;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.ListBox lstAvailableCars;
        private System.Windows.Forms.Label lblAvailableCars;
        private System.Windows.Forms.Panel pnlAddCar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxAddColor;
        private System.Windows.Forms.TextBox tbxAddModel;
        private System.Windows.Forms.Label lblAddColor;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.Label lblAddMake;
        private System.Windows.Forms.TextBox tbxAddMake;
        private System.Windows.Forms.Panel pnlReturnCar;
        private System.Windows.Forms.Label lblReturnCars;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstReturnCars;
        private System.Windows.Forms.Panel pnlRentThank;
        private System.Windows.Forms.Label lblRentThank;
        private System.Windows.Forms.Panel pnlReturnThank;
        private System.Windows.Forms.Label lblReturnThank;
    }
}

