namespace PointOfSale.Cashier
{
    partial class CashierAddLoyality
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add_point = new System.Windows.Forms.Button();
            this.txt_add_point = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Hebrew", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Loyality ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(85, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_point
            // 
            this.btn_add_point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.btn_add_point.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_add_point.FlatAppearance.BorderSize = 0;
            this.btn_add_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_point.ForeColor = System.Drawing.Color.Transparent;
            this.btn_add_point.Location = new System.Drawing.Point(446, 199);
            this.btn_add_point.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add_point.Name = "btn_add_point";
            this.btn_add_point.Size = new System.Drawing.Size(106, 41);
            this.btn_add_point.TabIndex = 26;
            this.btn_add_point.Text = "ADD";
            this.btn_add_point.UseVisualStyleBackColor = false;
            this.btn_add_point.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_add_point
            // 
            this.txt_add_point.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_add_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_point.Location = new System.Drawing.Point(211, 118);
            this.txt_add_point.Name = "txt_add_point";
            this.txt_add_point.Size = new System.Drawing.Size(341, 22);
            this.txt_add_point.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(98, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID No";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 62);
            this.panel1.TabIndex = 21;
            // 
            // CashierAddLoyality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(620, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add_point);
            this.Controls.Add(this.txt_add_point);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Name = "CashierAddLoyality";
            this.Text = "CashierAddLoyality";
            this.Load += new System.EventHandler(this.CashierAddLoyality_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add_point;
        private System.Windows.Forms.TextBox txt_add_point;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}