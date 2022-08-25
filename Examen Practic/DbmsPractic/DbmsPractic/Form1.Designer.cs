namespace PracticalExamModel
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
            this.dvgCustomers = new System.Windows.Forms.DataGridView();
            this.dvgDeliveries = new System.Windows.Forms.DataGridView();
            this.btnSavePosts = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCustomers
            // 
            this.dvgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCustomers.Location = new System.Drawing.Point(69, 61);
            this.dvgCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgCustomers.Name = "dvgCustomers";
            this.dvgCustomers.RowHeadersWidth = 51;
            this.dvgCustomers.RowTemplate.Height = 24;
            this.dvgCustomers.Size = new System.Drawing.Size(452, 145);
            this.dvgCustomers.TabIndex = 0;
            // 
            // dvgDeliveries
            // 
            this.dvgDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDeliveries.Location = new System.Drawing.Point(69, 297);
            this.dvgDeliveries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgDeliveries.Name = "dvgDeliveries";
            this.dvgDeliveries.RowHeadersWidth = 51;
            this.dvgDeliveries.RowTemplate.Height = 24;
            this.dvgDeliveries.Size = new System.Drawing.Size(452, 155);
            this.dvgDeliveries.TabIndex = 1;
            // 
            // btnSavePosts
            // 
            this.btnSavePosts.Location = new System.Drawing.Point(541, 115);
            this.btnSavePosts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePosts.Name = "btnSavePosts";
            this.btnSavePosts.Size = new System.Drawing.Size(100, 30);
            this.btnSavePosts.TabIndex = 2;
            this.btnSavePosts.Text = "Save posts";
            this.btnSavePosts.UseVisualStyleBackColor = true;
            this.btnSavePosts.Click += new System.EventHandler(this.btnSavePosts_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(541, 347);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 37);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Deliveries";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSavePosts);
            this.Controls.Add(this.dvgDeliveries);
            this.Controls.Add(this.dvgCustomers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCustomers;
        private System.Windows.Forms.DataGridView dvgDeliveries;
        private System.Windows.Forms.Button btnSavePosts;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

