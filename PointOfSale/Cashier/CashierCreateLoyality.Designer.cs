namespace PointOfSale.Cashier
{
    partial class CashierCreateLoyality
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_create_add = new System.Windows.Forms.Button();
            this.btn_create_clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Hebrew", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New Loyalty User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(237, 107);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(341, 22);
            this.txt_id.TabIndex = 17;
            this.txt_id.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(237, 156);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(341, 22);
            this.txt_name.TabIndex = 16;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(91, 154);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Name";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(91, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "ID No";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btn_create_add
            // 
            this.btn_create_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.btn_create_add.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_create_add.FlatAppearance.BorderSize = 0;
            this.btn_create_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_add.ForeColor = System.Drawing.Color.Transparent;
            this.btn_create_add.Location = new System.Drawing.Point(472, 247);
            this.btn_create_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_create_add.Name = "btn_create_add";
            this.btn_create_add.Size = new System.Drawing.Size(106, 41);
            this.btn_create_add.TabIndex = 19;
            this.btn_create_add.Text = "ADD";
            this.btn_create_add.UseVisualStyleBackColor = false;
            this.btn_create_add.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_create_clear
            // 
            this.btn_create_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.btn_create_clear.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_create_clear.FlatAppearance.BorderSize = 0;
            this.btn_create_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_clear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_create_clear.Location = new System.Drawing.Point(95, 247);
            this.btn_create_clear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_create_clear.Name = "btn_create_clear";
            this.btn_create_clear.Size = new System.Drawing.Size(106, 41);
            this.btn_create_clear.TabIndex = 20;
            this.btn_create_clear.Text = "CLEAR";
            this.btn_create_clear.UseVisualStyleBackColor = false;
            this.btn_create_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // CashierCreateLoyality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(641, 340);
            this.Controls.Add(this.btn_create_clear);
            this.Controls.Add(this.btn_create_add);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "CashierCreateLoyality";
            this.Text = "CashierLoyality";
            this.Load += new System.EventHandler(this.CashierCreateLoyality_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_create_add;
        private System.Windows.Forms.Button btn_create_clear;
    }
}