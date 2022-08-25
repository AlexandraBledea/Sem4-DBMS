namespace Lab1
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
            this.insertButton = new System.Windows.Forms.Button();
            this.ParentTable = new System.Windows.Forms.DataGridView();
            this.ChildTable = new System.Windows.Forms.DataGridView();
            this.cnpBox = new System.Windows.Forms.TextBox();
            this.telBox = new System.Windows.Forms.TextBox();
            this.libraryIDBox = new System.Windows.Forms.TextBox();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.telLabel = new System.Windows.Forms.Label();
            this.libraryIDLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ParentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildTable)).BeginInit();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.Location = new System.Drawing.Point(34, 424);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(221, 41);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // ParentTable
            // 
            this.ParentTable.AllowUserToAddRows = false;
            this.ParentTable.AllowUserToDeleteRows = false;
            this.ParentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParentTable.Location = new System.Drawing.Point(34, 12);
            this.ParentTable.Name = "ParentTable";
            this.ParentTable.ReadOnly = true;
            this.ParentTable.Size = new System.Drawing.Size(535, 335);
            this.ParentTable.TabIndex = 1;
            this.ParentTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ParentTable_CellClick);
            // 
            // ChildTable
            // 
            this.ChildTable.AllowUserToAddRows = false;
            this.ChildTable.AllowUserToDeleteRows = false;
            this.ChildTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChildTable.Location = new System.Drawing.Point(587, 12);
            this.ChildTable.Name = "ChildTable";
            this.ChildTable.ReadOnly = true;
            this.ChildTable.Size = new System.Drawing.Size(551, 335);
            this.ChildTable.TabIndex = 2;
            this.ChildTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChildTable_CellClick);
            // 
            // cnpBox
            // 
            this.cnpBox.Location = new System.Drawing.Point(21, 384);
            this.cnpBox.Name = "cnpBox";
            this.cnpBox.Size = new System.Drawing.Size(147, 20);
            this.cnpBox.TabIndex = 3;
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(613, 384);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(154, 20);
            this.telBox.TabIndex = 4;
            // 
            // libraryIDBox
            // 
            this.libraryIDBox.Location = new System.Drawing.Point(823, 384);
            this.libraryIDBox.Name = "libraryIDBox";
            this.libraryIDBox.Size = new System.Drawing.Size(143, 20);
            this.libraryIDBox.TabIndex = 5;
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(1018, 385);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(138, 20);
            this.salaryBox.TabIndex = 6;
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(75, 368);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(29, 13);
            this.cnpLabel.TabIndex = 7;
            this.cnpLabel.Text = "CNP";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(660, 366);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(58, 13);
            this.telLabel.TabIndex = 8;
            this.telLabel.Text = "Telephone";
            // 
            // libraryIDLabel
            // 
            this.libraryIDLabel.AutoSize = true;
            this.libraryIDLabel.Location = new System.Drawing.Point(866, 366);
            this.libraryIDLabel.Name = "libraryIDLabel";
            this.libraryIDLabel.Size = new System.Drawing.Size(55, 13);
            this.libraryIDLabel.TabIndex = 9;
            this.libraryIDLabel.Text = "Library_ID";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(1055, 366);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 10;
            this.salaryLabel.Text = "Salary";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(328, 424);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(221, 41);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(613, 424);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(223, 41);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(211, 384);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(143, 20);
            this.nameBox.TabIndex = 13;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(407, 385);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(151, 20);
            this.ageBox.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(263, 366);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(461, 368);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 16;
            this.ageLabel.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 494);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.libraryIDLabel);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.cnpLabel);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.libraryIDBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.cnpBox);
            this.Controls.Add(this.ChildTable);
            this.Controls.Add(this.ParentTable);
            this.Controls.Add(this.insertButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ParentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.DataGridView ParentTable;
        private System.Windows.Forms.DataGridView ChildTable;
        private System.Windows.Forms.TextBox cnpBox;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox libraryIDBox;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label libraryIDLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ageLabel;
    }
}

