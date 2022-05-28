
namespace Anket_2
{
    partial class Form_Aanket
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Aanket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add_change = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_number = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_surname = new System.Windows.Forms.TextBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtBox_FileName = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btn_add_change);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_dateOfBirth);
            this.groupBox1.Controls.Add(this.maskedTextBox_number);
            this.groupBox1.Controls.Add(this.txtBox_email);
            this.groupBox1.Controls.Add(this.txtBox_surname);
            this.groupBox1.Controls.Add(this.txtBox_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // btn_add_change
            // 
            this.btn_add_change.AutoSize = true;
            this.btn_add_change.BackColor = System.Drawing.Color.Green;
            this.btn_add_change.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_change.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_change.Location = new System.Drawing.Point(203, 197);
            this.btn_add_change.Name = "btn_add_change";
            this.btn_add_change.Size = new System.Drawing.Size(100, 31);
            this.btn_add_change.TabIndex = 7;
            this.btn_add_change.Text = "Add";
            this.btn_add_change.UseVisualStyleBackColor = false;
            this.btn_add_change.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_add_change_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "DateOfBirth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // dtp_dateOfBirth
            // 
            this.dtp_dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateOfBirth.Location = new System.Drawing.Point(97, 154);
            this.dtp_dateOfBirth.Name = "dtp_dateOfBirth";
            this.dtp_dateOfBirth.Size = new System.Drawing.Size(206, 23);
            this.dtp_dateOfBirth.TabIndex = 5;
            // 
            // maskedTextBox_number
            // 
            this.maskedTextBox_number.Location = new System.Drawing.Point(97, 125);
            this.maskedTextBox_number.Mask = "(999) 000-0000";
            this.maskedTextBox_number.Name = "maskedTextBox_number";
            this.maskedTextBox_number.Size = new System.Drawing.Size(206, 23);
            this.maskedTextBox_number.TabIndex = 4;
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(97, 91);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(206, 23);
            this.txtBox_email.TabIndex = 3;
            // 
            // txtBox_surname
            // 
            this.txtBox_surname.Location = new System.Drawing.Point(97, 62);
            this.txtBox_surname.Name = "txtBox_surname";
            this.txtBox_surname.Size = new System.Drawing.Size(206, 23);
            this.txtBox_surname.TabIndex = 2;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(97, 33);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(206, 23);
            this.txtBox_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(372, 59);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(180, 199);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // txtBox_FileName
            // 
            this.txtBox_FileName.Location = new System.Drawing.Point(372, 264);
            this.txtBox_FileName.Name = "txtBox_FileName";
            this.txtBox_FileName.PlaceholderText = "File Name";
            this.txtBox_FileName.Size = new System.Drawing.Size(180, 23);
            this.txtBox_FileName.TabIndex = 8;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.Green;
            this.btn_Load.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Load.Location = new System.Drawing.Point(372, 293);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 9;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(477, 293);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form_Aanket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 359);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txtBox_FileName);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Aanket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_dateOfBirth;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_number;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_surname;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_change;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtBox_FileName;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_save;
    }
}

