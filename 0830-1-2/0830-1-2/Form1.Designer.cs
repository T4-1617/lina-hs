namespace _0830_1_2
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
            this.boxLastName = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.boxFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxLastName
            // 
            this.boxLastName.Location = new System.Drawing.Point(172, 174);
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.Size = new System.Drawing.Size(166, 20);
            this.boxLastName.TabIndex = 1;
            this.boxLastName.Text = "Enter your last name";
            this.boxLastName.TextChanged += new System.EventHandler(this.boxLastName_TextChanged);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(185, 210);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(140, 61);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // boxFirstName
            // 
            this.boxFirstName.Location = new System.Drawing.Point(172, 138);
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.Size = new System.Drawing.Size(166, 20);
            this.boxFirstName.TabIndex = 3;
            this.boxFirstName.Text = "Enter your first name";
            this.boxFirstName.TextChanged += new System.EventHandler(this.boxFirstName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 402);
            this.Controls.Add(this.boxFirstName);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.boxLastName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox boxLastName;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox boxFirstName;
    }
}

