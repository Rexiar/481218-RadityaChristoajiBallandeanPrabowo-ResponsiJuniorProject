namespace Responsi
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
            nameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            insertButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            pictureBox1 = new PictureBox();
            datagrid = new DataGridView();
            deptBox = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            SuspendLayout();
            // 
            // nameBox
            // 
            nameBox.Location = new Point(170, 78);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 86);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 136);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 3;
            label3.Text = "Dep. Karyawan :";
            // 
            // insertButton
            // 
            insertButton.Location = new Point(13, 207);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(75, 23);
            insertButton.TabIndex = 4;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(215, 214);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 5;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(391, 207);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 63);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // datagrid
            // 
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Location = new Point(78, 261);
            datagrid.Name = "datagrid";
            datagrid.RowTemplate.Height = 25;
            datagrid.Size = new Size(409, 151);
            datagrid.TabIndex = 8;
            datagrid.CellClick += datagrid_CellClick;
            datagrid.CellContentClick += datagrid_CellContentClick;
            // 
            // deptBox
            // 
            deptBox.Location = new Point(170, 133);
            deptBox.Name = "deptBox";
            deptBox.Size = new Size(100, 23);
            deptBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 78);
            label4.Name = "label4";
            label4.Size = new Size(126, 90);
            label4.TabIndex = 10;
            label4.Text = "ID Departemen:\r\nHR : HR\r\nENG : Engineer\r\nDEV : Developer\r\nPM : Product Manager\r\nFIN : Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 424);
            Controls.Add(label4);
            Controls.Add(deptBox);
            Controls.Add(datagrid);
            Controls.Add(pictureBox1);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(insertButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button insertButton;
        private Button editButton;
        private Button deleteButton;
        private PictureBox pictureBox1;
        private DataGridView datagrid;
        private TextBox deptBox;
        private Label label4;
    }
}