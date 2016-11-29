namespace Project2
{
    partial class RegistrationForm
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
            this.creditHourLbl = new System.Windows.Forms.Label();
            this.creditHourTxt = new System.Windows.Forms.TextBox();
            this.lastNamelbl = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.calculteLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditHourLbl
            // 
            this.creditHourLbl.AutoSize = true;
            this.creditHourLbl.Location = new System.Drawing.Point(62, 26);
            this.creditHourLbl.Name = "creditHourLbl";
            this.creditHourLbl.Size = new System.Drawing.Size(128, 26);
            this.creditHourLbl.TabIndex = 5;
            this.creditHourLbl.Text = "Please Enter your number\r\nof credit hours.";
            this.creditHourLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditHourTxt
            // 
            this.creditHourTxt.Location = new System.Drawing.Point(109, 83);
            this.creditHourTxt.Name = "creditHourTxt";
            this.creditHourTxt.Size = new System.Drawing.Size(34, 20);
            this.creditHourTxt.TabIndex = 6;
            this.creditHourTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNamelbl
            // 
            this.lastNamelbl.AutoSize = true;
            this.lastNamelbl.Location = new System.Drawing.Point(209, 26);
            this.lastNamelbl.Name = "lastNamelbl";
            this.lastNamelbl.Size = new System.Drawing.Size(90, 26);
            this.lastNamelbl.TabIndex = 7;
            this.lastNamelbl.Text = "Please Enter your\r\n last name.";
            this.lastNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(205, 83);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(98, 20);
            this.lastNameTxt.TabIndex = 8;
            this.lastNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculteLbl
            // 
            this.calculteLbl.AutoSize = true;
            this.calculteLbl.Location = new System.Drawing.Point(46, 119);
            this.calculteLbl.Name = "calculteLbl";
            this.calculteLbl.Size = new System.Drawing.Size(160, 39);
            this.calculteLbl.TabIndex = 9;
            this.calculteLbl.Text = "Press the Calculate button to\r\n determine your registration date \r\nand time";
            this.calculteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(89, 176);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 10;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(217, 176);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.calculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 221);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.calculteLbl);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.lastNamelbl);
            this.Controls.Add(this.creditHourTxt);
            this.Controls.Add(this.creditHourLbl);
            this.Name = "RegistrationForm";
            this.Text = "Registration Date and Time Determination";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditHourLbl;
        private System.Windows.Forms.TextBox creditHourTxt;
        private System.Windows.Forms.Label lastNamelbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label calculteLbl;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

