namespace trialbd0
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
            this.test_bts = new System.Windows.Forms.Button();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.search_button = new System.Windows.Forms.Button();
            this.orderByColumnTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updatw_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // test_bts
            // 
            this.test_bts.Location = new System.Drawing.Point(55, 42);
            this.test_bts.Name = "test_bts";
            this.test_bts.Size = new System.Drawing.Size(75, 23);
            this.test_bts.TabIndex = 0;
            this.test_bts.Text = "TEST CON";
            this.test_bts.UseVisualStyleBackColor = true;
            this.test_bts.Click += new System.EventHandler(this.test_bts_Click);
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(175, 140);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.tableNameTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 370);
            this.dataGridView1.TabIndex = 3;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Location = new System.Drawing.Point(175, 92);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 24);
            this.orderComboBox.TabIndex = 4;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(55, 92);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 5;
            this.search_button.Text = "SELECT *";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // orderByColumnTextBox
            // 
            this.orderByColumnTextBox.Location = new System.Drawing.Point(175, 188);
            this.orderByColumnTextBox.Name = "orderByColumnTextBox";
            this.orderByColumnTextBox.Size = new System.Drawing.Size(100, 22);
            this.orderByColumnTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "numele tabelei:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "coloana dupa care sortez:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // updatw_btn
            // 
            this.updatw_btn.Location = new System.Drawing.Point(56, 465);
            this.updatw_btn.Name = "updatw_btn";
            this.updatw_btn.Size = new System.Drawing.Size(75, 23);
            this.updatw_btn.TabIndex = 10;
            this.updatw_btn.Text = "EDIT";
            this.updatw_btn.UseVisualStyleBackColor = true;
            this.updatw_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Join/Having";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updatw_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderByColumnTextBox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.test_bts);
            this.Name = "Form1";
            this.Text = "f";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test_bts;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox orderByColumnTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updatw_btn;
        private System.Windows.Forms.Button button1;
    }
}

