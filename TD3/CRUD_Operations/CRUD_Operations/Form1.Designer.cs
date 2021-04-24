
namespace CRUD_Operations
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "S.Name :";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(136, 35);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(147, 23);
            this.txtStudentName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentRecordDataGridView
            // 
            this.StudentRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordDataGridView.Location = new System.Drawing.Point(58, 291);
            this.StudentRecordDataGridView.Name = "StudentRecordDataGridView";
            this.StudentRecordDataGridView.RowTemplate.Height = 25;
            this.StudentRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentRecordDataGridView.Size = new System.Drawing.Size(575, 150);
            this.StudentRecordDataGridView.TabIndex = 3;
            this.StudentRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordDataGridView_CellClick);
            this.StudentRecordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordDataGridView_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(517, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(453, 35);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(147, 23);
            this.txtFatherName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "F.Name :";
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.Location = new System.Drawing.Point(136, 106);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(147, 23);
            this.txtRollNumber.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Roll No.";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(453, 101);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(147, 23);
            this.txtMobile.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mobile :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(136, 174);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(147, 23);
            this.txtAddress.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Address :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRollNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StudentRecordDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView StudentRecordDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
    }
}

