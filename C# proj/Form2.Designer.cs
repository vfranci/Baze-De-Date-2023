namespace trialbd0
{
    partial class Form2
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
            this.columnNameTextBox = new System.Windows.Forms.TextBox();
            this.primaryKeyColumnTextBox = new System.Windows.Forms.TextBox();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.newValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.primaryKeyValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TEST = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.DELETE = new System.Windows.Forms.Button();
            this.tableNameTextBox1 = new System.Windows.Forms.TextBox();
            this.primaryKeyColumnTextBox1 = new System.Windows.Forms.TextBox();
            this.primaryKeyValueTextBox1 = new System.Windows.Forms.TextBox();
            this.outputTextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnNameTextBox
            // 
            this.columnNameTextBox.Location = new System.Drawing.Point(152, 52);
            this.columnNameTextBox.Name = "columnNameTextBox";
            this.columnNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.columnNameTextBox.TabIndex = 0;
            this.columnNameTextBox.TextChanged += new System.EventHandler(this.columnNameTextBox_TextChanged);
            // 
            // primaryKeyColumnTextBox
            // 
            this.primaryKeyColumnTextBox.Location = new System.Drawing.Point(422, 52);
            this.primaryKeyColumnTextBox.Name = "primaryKeyColumnTextBox";
            this.primaryKeyColumnTextBox.Size = new System.Drawing.Size(100, 22);
            this.primaryKeyColumnTextBox.TabIndex = 1;
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(26, 52);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.tableNameTextBox.TabIndex = 2;
            this.tableNameTextBox.TextChanged += new System.EventHandler(this.tableNameTextBox_TextChanged);
            // 
            // newValueTextBox
            // 
            this.newValueTextBox.Location = new System.Drawing.Point(288, 52);
            this.newValueTextBox.Name = "newValueTextBox";
            this.newValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.newValueTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "nume tabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "nume coloana";
            // 
            // primaryKeyValueTextBox
            // 
            this.primaryKeyValueTextBox.Location = new System.Drawing.Point(554, 52);
            this.primaryKeyValueTextBox.Name = "primaryKeyValueTextBox";
            this.primaryKeyValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.primaryKeyValueTextBox.TabIndex = 6;
            this.primaryKeyValueTextBox.TextChanged += new System.EventHandler(this.idValueTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "valoare noua";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "cheie primara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "valoare pk";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TEST
            // 
            this.TEST.Location = new System.Drawing.Point(693, 50);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(75, 23);
            this.TEST.TabIndex = 11;
            this.TEST.Text = "TEST";
            this.TEST.UseVisualStyleBackColor = true;
            this.TEST.Click += new System.EventHandler(this.TEST_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(152, 135);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(236, 22);
            this.outputTextBox.TabIndex = 12;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(26, 369);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(100, 23);
            this.DELETE.TabIndex = 13;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // tableNameTextBox1
            // 
            this.tableNameTextBox1.Location = new System.Drawing.Point(26, 274);
            this.tableNameTextBox1.Name = "tableNameTextBox1";
            this.tableNameTextBox1.Size = new System.Drawing.Size(100, 22);
            this.tableNameTextBox1.TabIndex = 14;
            // 
            // primaryKeyColumnTextBox1
            // 
            this.primaryKeyColumnTextBox1.Location = new System.Drawing.Point(152, 274);
            this.primaryKeyColumnTextBox1.Name = "primaryKeyColumnTextBox1";
            this.primaryKeyColumnTextBox1.Size = new System.Drawing.Size(100, 22);
            this.primaryKeyColumnTextBox1.TabIndex = 15;
            // 
            // primaryKeyValueTextBox1
            // 
            this.primaryKeyValueTextBox1.Location = new System.Drawing.Point(288, 274);
            this.primaryKeyValueTextBox1.Name = "primaryKeyValueTextBox1";
            this.primaryKeyValueTextBox1.Size = new System.Drawing.Size(100, 22);
            this.primaryKeyValueTextBox1.TabIndex = 16;
            // 
            // outputTextBox1
            // 
            this.outputTextBox1.Location = new System.Drawing.Point(152, 370);
            this.outputTextBox1.Name = "outputTextBox1";
            this.outputTextBox1.Size = new System.Drawing.Size(236, 22);
            this.outputTextBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "nume tabel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "nume coloana pk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "valoare pk";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 499);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputTextBox1);
            this.Controls.Add(this.primaryKeyValueTextBox1);
            this.Controls.Add(this.primaryKeyColumnTextBox1);
            this.Controls.Add(this.tableNameTextBox1);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.TEST);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.primaryKeyValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newValueTextBox);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.primaryKeyColumnTextBox);
            this.Controls.Add(this.columnNameTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox columnNameTextBox;
        private System.Windows.Forms.TextBox primaryKeyColumnTextBox;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.TextBox newValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox primaryKeyValueTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TEST;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.TextBox tableNameTextBox1;
        private System.Windows.Forms.TextBox primaryKeyColumnTextBox1;
        private System.Windows.Forms.TextBox primaryKeyValueTextBox1;
        private System.Windows.Forms.TextBox outputTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}