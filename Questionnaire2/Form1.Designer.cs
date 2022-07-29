namespace Questionnaire2
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
            this.QuestionnaireGrpBx = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.birthdayMtxtb = new System.Windows.Forms.MaskedTextBox();
            this.phonenumberTxtb = new System.Windows.Forms.TextBox();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersLstBx = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.filenameTxtb = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.QuestionnaireGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionnaireGrpBx
            // 
            this.QuestionnaireGrpBx.Controls.Add(this.addBtn);
            this.QuestionnaireGrpBx.Controls.Add(this.birthdayMtxtb);
            this.QuestionnaireGrpBx.Controls.Add(this.phonenumberTxtb);
            this.QuestionnaireGrpBx.Controls.Add(this.emailTxtb);
            this.QuestionnaireGrpBx.Controls.Add(this.surnameTxtb);
            this.QuestionnaireGrpBx.Controls.Add(this.nameTxtb);
            this.QuestionnaireGrpBx.Controls.Add(this.label5);
            this.QuestionnaireGrpBx.Controls.Add(this.label4);
            this.QuestionnaireGrpBx.Controls.Add(this.label3);
            this.QuestionnaireGrpBx.Controls.Add(this.label2);
            this.QuestionnaireGrpBx.Controls.Add(this.label1);
            this.QuestionnaireGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionnaireGrpBx.Location = new System.Drawing.Point(23, 32);
            this.QuestionnaireGrpBx.Name = "QuestionnaireGrpBx";
            this.QuestionnaireGrpBx.Size = new System.Drawing.Size(521, 472);
            this.QuestionnaireGrpBx.TabIndex = 0;
            this.QuestionnaireGrpBx.TabStop = false;
            this.QuestionnaireGrpBx.Text = "Questionnaire";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.White;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(323, 363);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(123, 44);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // birthdayMtxtb
            // 
            this.birthdayMtxtb.Location = new System.Drawing.Point(146, 279);
            this.birthdayMtxtb.Mask = "00/00/0000";
            this.birthdayMtxtb.Name = "birthdayMtxtb";
            this.birthdayMtxtb.Size = new System.Drawing.Size(300, 29);
            this.birthdayMtxtb.TabIndex = 10;
            this.birthdayMtxtb.ValidatingType = typeof(System.DateTime);
            // 
            // phonenumberTxtb
            // 
            this.phonenumberTxtb.Location = new System.Drawing.Point(146, 226);
            this.phonenumberTxtb.Name = "phonenumberTxtb";
            this.phonenumberTxtb.Size = new System.Drawing.Size(300, 29);
            this.phonenumberTxtb.TabIndex = 9;
            // 
            // emailTxtb
            // 
            this.emailTxtb.Location = new System.Drawing.Point(146, 176);
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(300, 29);
            this.emailTxtb.TabIndex = 8;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.Location = new System.Drawing.Point(146, 123);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(300, 29);
            this.surnameTxtb.TabIndex = 7;
            // 
            // nameTxtb
            // 
            this.nameTxtb.Location = new System.Drawing.Point(146, 71);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(300, 29);
            this.nameTxtb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthday : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // CustomersLstBx
            // 
            this.CustomersLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLstBx.FormattingEnabled = true;
            this.CustomersLstBx.ItemHeight = 24;
            this.CustomersLstBx.Location = new System.Drawing.Point(656, 98);
            this.CustomersLstBx.Name = "CustomersLstBx";
            this.CustomersLstBx.Size = new System.Drawing.Size(279, 292);
            this.CustomersLstBx.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(656, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 40);
            this.label6.TabIndex = 2;
            this.label6.Text = "CUSTOMERS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(656, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "File name : ";
            // 
            // filenameTxtb
            // 
            this.filenameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filenameTxtb.Location = new System.Drawing.Point(759, 410);
            this.filenameTxtb.Name = "filenameTxtb";
            this.filenameTxtb.Size = new System.Drawing.Size(176, 29);
            this.filenameTxtb.TabIndex = 4;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.White;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Location = new System.Drawing.Point(670, 460);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(123, 44);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "LOAD";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.White;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(810, 460);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 44);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.BackColor = System.Drawing.Color.Transparent;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.resultLbl.Location = new System.Drawing.Point(667, 517);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 18);
            this.resultLbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 544);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.filenameTxtb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomersLstBx);
            this.Controls.Add(this.QuestionnaireGrpBx);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.QuestionnaireGrpBx.ResumeLayout(false);
            this.QuestionnaireGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox QuestionnaireGrpBx;
        private System.Windows.Forms.TextBox phonenumberTxtb;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox birthdayMtxtb;
        private System.Windows.Forms.ListBox CustomersLstBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox filenameTxtb;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

