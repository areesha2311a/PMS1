namespace PMS1
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnProducts = new Button();
            btncategories = new Button();
            btncustomers = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightPink;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightPink;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightPink;
            panel3.Controls.Add(btnProducts);
            panel3.Controls.Add(btncategories);
            panel3.Controls.Add(btncustomers);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 450);
            panel3.TabIndex = 1;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = SystemColors.ControlLightLight;
            btnProducts.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnProducts.Location = new Point(0, 233);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(200, 28);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btncategories
            // 
            btncategories.BackColor = SystemColors.ControlLightLight;
            btncategories.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btncategories.Location = new Point(0, 165);
            btncategories.Name = "btncategories";
            btncategories.Size = new Size(200, 27);
            btncategories.TabIndex = 1;
            btncategories.Text = "categories";
            btncategories.UseVisualStyleBackColor = false;
            btncategories.Click += btncategories_Click;
            // 
            // btncustomers
            // 
            btncustomers.BackColor = SystemColors.ControlLightLight;
            btncustomers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btncustomers.Location = new Point(0, 98);
            btncustomers.Name = "btncustomers";
            btncustomers.Size = new Size(200, 28);
            btncustomers.TabIndex = 0;
            btncustomers.Text = "Customers";
            btncustomers.UseVisualStyleBackColor = false;
            btncustomers.Click += btncustomers_Click;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ActiveCaption;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(200, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(600, 450);
            mainpanel.TabIndex = 1;
            mainpanel.Paint += panel4_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel mainpanel;
        private Button btnProducts;
        private Button btncategories;
        private Button btncustomers;
    }
}
