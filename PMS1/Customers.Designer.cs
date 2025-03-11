namespace PMS1
{
    partial class Customers
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btninsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(96, 20);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 0;
            label1.Text = "Customers Record";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(361, 254);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Ivory;
            textBox1.Location = new Point(452, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Ivory;
            textBox2.Location = new Point(452, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Ivory;
            textBox3.Location = new Point(452, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Ivory;
            textBox4.Location = new Point(452, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Ivory;
            textBox5.Location = new Point(452, 168);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(108, 23);
            textBox5.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(407, 55);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 8;
            label2.Text = "N:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(410, 81);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 9;
            label3.Text = "E:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(410, 110);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 10;
            label4.Text = "A:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(410, 139);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 11;
            label5.Text = "P:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(407, 168);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 12;
            label6.Text = "C:";
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.White;
            btninsert.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(466, 217);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(75, 23);
            btninsert.TabIndex = 13;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 411);
            Controls.Add(btninsert);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Customers";
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btninsert;
    }
}