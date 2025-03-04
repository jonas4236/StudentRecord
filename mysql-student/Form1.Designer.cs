namespace mysql_student
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
            dataGridView1 = new DataGridView();
            btnViewData = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRegNo = new TextBox();
            txtAddress = new TextBox();
            txtStudentName = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            btnOpen = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1199, 305);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // btnViewData
            // 
            btnViewData.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewData.Location = new Point(21, 455);
            btnViewData.Name = "btnViewData";
            btnViewData.Size = new Size(111, 43);
            btnViewData.TabIndex = 1;
            btnViewData.Text = "View";
            btnViewData.UseVisualStyleBackColor = true;
            btnViewData.Click += btnViewData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(21, 351);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 2;
            label1.Text = "Reg No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(317, 351);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 3;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(585, 351);
            label3.Name = "label3";
            label3.Size = new Size(87, 30);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // txtRegNo
            // 
            txtRegNo.Font = new Font("Segoe UI", 15.75F);
            txtRegNo.Location = new Point(21, 386);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(206, 35);
            txtRegNo.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 15.75F);
            txtAddress.Location = new Point(585, 386);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 35);
            txtAddress.TabIndex = 6;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 15.75F);
            txtStudentName.Location = new Point(317, 386);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(206, 35);
            txtStudentName.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(156, 455);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(111, 43);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(291, 455);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(425, 455);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 43);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1100, 591);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 43);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.Location = new Point(959, 313);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 261);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.Location = new Point(849, 386);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(90, 38);
            btnOpen.TabIndex = 12;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(849, 454);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 38);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 646);
            Controls.Add(btnClear);
            Controls.Add(btnOpen);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtStudentName);
            Controls.Add(txtAddress);
            Controls.Add(txtRegNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnViewData);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "StudentRecord";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnViewData;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRegNo;
        private TextBox txtAddress;
        private TextBox txtStudentName;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Button btnOpen;
        private Button btnClear;
    }
}
