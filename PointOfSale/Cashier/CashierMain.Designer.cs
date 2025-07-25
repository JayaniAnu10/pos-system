﻿namespace PointOfSale.Cashier
{
    partial class CashierMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierMain));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_List1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_cash = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_done = new System.Windows.Forms.Button();
            this.ptn_print = new System.Windows.Forms.Button();
            this.btn_lo = new System.Windows.Forms.Button();
            this.lbl_bill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_List2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_buy_item = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(228)))), ((int)(((byte)(199)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.DGV_List1);
            this.panel4.Controls.Add(this.txt_search);
            this.panel4.Location = new System.Drawing.Point(364, 68);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(725, 819);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search Item code";
            // 
            // DGV_List1
            // 
            this.DGV_List1.AllowUserToAddRows = false;
            this.DGV_List1.AllowUserToDeleteRows = false;
            this.DGV_List1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.DGV_List1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_List1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DGV_List1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_List1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DGV_List1.ColumnHeadersHeight = 56;
            this.DGV_List1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_List1.EnableHeadersVisualStyles = false;
            this.DGV_List1.GridColor = System.Drawing.Color.White;
            this.DGV_List1.Location = new System.Drawing.Point(-3, 105);
            this.DGV_List1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_List1.MultiSelect = false;
            this.DGV_List1.Name = "DGV_List1";
            this.DGV_List1.ReadOnly = true;
            this.DGV_List1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_List1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGV_List1.RowHeadersVisible = false;
            this.DGV_List1.RowHeadersWidth = 50;
            this.DGV_List1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_List1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.DGV_List1.RowTemplate.Height = 40;
            this.DGV_List1.RowTemplate.ReadOnly = true;
            this.DGV_List1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_List1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_List1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_List1.Size = new System.Drawing.Size(727, 730);
            this.DGV_List1.TabIndex = 2;
            this.DGV_List1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_List1_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(177)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(13, 43);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.MinimumSize = new System.Drawing.Size(267, 37);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(472, 37);
            this.txt_search.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbl_time);
            this.panel5.Controls.Add(this.txt_net);
            this.panel5.Controls.Add(this.lbl_date);
            this.panel5.Controls.Add(this.txt_cash);
            this.panel5.Controls.Add(this.txt_balance);
            this.panel5.Controls.Add(this.txt_total);
            this.panel5.Controls.Add(this.txt_discount);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.lbl_bill);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.DGV_List2);
            this.panel5.Location = new System.Drawing.Point(1108, -1);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(950, 1038);
            this.panel5.TabIndex = 3;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(715, 21);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(41, 20);
            this.lbl_time.TabIndex = 20;
            this.lbl_time.Text = "time";
            // 
            // txt_net
            // 
            this.txt_net.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(177)))));
            this.txt_net.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_net.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_net.Location = new System.Drawing.Point(201, 838);
            this.txt_net.Margin = new System.Windows.Forms.Padding(4);
            this.txt_net.Name = "txt_net";
            this.txt_net.ReadOnly = true;
            this.txt_net.Size = new System.Drawing.Size(299, 27);
            this.txt_net.TabIndex = 15;
            this.txt_net.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_net.TextChanged += new System.EventHandler(this.txt_net_TextChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(712, 58);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(41, 20);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "date";
            // 
            // txt_cash
            // 
            this.txt_cash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(177)))));
            this.txt_cash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash.Location = new System.Drawing.Point(201, 891);
            this.txt_cash.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(299, 27);
            this.txt_cash.TabIndex = 14;
            this.txt_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_cash.TextChanged += new System.EventHandler(this.txt_cash_TextChanged_1);
            // 
            // txt_balance
            // 
            this.txt_balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(177)))));
            this.txt_balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(201, 940);
            this.txt_balance.Margin = new System.Windows.Forms.Padding(4);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.ReadOnly = true;
            this.txt_balance.Size = new System.Drawing.Size(299, 27);
            this.txt_balance.TabIndex = 13;
            this.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(177)))));
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(201, 735);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(299, 27);
            this.txt_total.TabIndex = 12;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_discount
            // 
            this.txt_discount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(177)))));
            this.txt_discount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(201, 788);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.ReadOnly = true;
            this.txt_discount.Size = new System.Drawing.Size(299, 27);
            this.txt_discount.TabIndex = 11;
            this.txt_discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(23, 942);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 29);
            this.label13.TabIndex = 10;
            this.label13.Text = "Balance";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(23, 788);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "Discount";
            this.label12.Click += new System.EventHandler(this.label7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(23, 838);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 29);
            this.label11.TabIndex = 8;
            this.label11.Text = "Net Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(23, 891);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cash";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(23, 735);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.btn_done);
            this.panel1.Controls.Add(this.ptn_print);
            this.panel1.Controls.Add(this.btn_lo);
            this.panel1.Location = new System.Drawing.Point(-1, 665);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 373);
            this.panel1.TabIndex = 18;
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.btn_done.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.Color.Transparent;
            this.btn_done.Location = new System.Drawing.Point(553, 71);
            this.btn_done.Margin = new System.Windows.Forms.Padding(0);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(343, 53);
            this.btn_done.TabIndex = 17;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // ptn_print
            // 
            this.ptn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(56)))), ((int)(((byte)(72)))));
            this.ptn_print.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.ptn_print.FlatAppearance.BorderSize = 0;
            this.ptn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ptn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptn_print.ForeColor = System.Drawing.Color.Transparent;
            this.ptn_print.Location = new System.Drawing.Point(553, 256);
            this.ptn_print.Margin = new System.Windows.Forms.Padding(0);
            this.ptn_print.Name = "ptn_print";
            this.ptn_print.Size = new System.Drawing.Size(343, 49);
            this.ptn_print.TabIndex = 17;
            this.ptn_print.Text = "Print";
            this.ptn_print.UseVisualStyleBackColor = false;
            this.ptn_print.Click += new System.EventHandler(this.ptn_print_Click);
            // 
            // btn_lo
            // 
            this.btn_lo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.btn_lo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_lo.FlatAppearance.BorderSize = 0;
            this.btn_lo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lo.ForeColor = System.Drawing.Color.Transparent;
            this.btn_lo.Location = new System.Drawing.Point(553, 135);
            this.btn_lo.Margin = new System.Windows.Forms.Padding(0);
            this.btn_lo.Name = "btn_lo";
            this.btn_lo.Size = new System.Drawing.Size(343, 53);
            this.btn_lo.TabIndex = 16;
            this.btn_lo.Text = "Add Points";
            this.btn_lo.UseVisualStyleBackColor = false;
            this.btn_lo.Click += new System.EventHandler(this.btn_lo_Click);
            // 
            // lbl_bill
            // 
            this.lbl_bill.AutoSize = true;
            this.lbl_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.lbl_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bill.ForeColor = System.Drawing.Color.Black;
            this.lbl_bill.Location = new System.Drawing.Point(119, 58);
            this.lbl_bill.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_bill.Name = "lbl_bill";
            this.lbl_bill.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.lbl_bill.Size = new System.Drawing.Size(24, 51);
            this.lbl_bill.TabIndex = 5;
            this.lbl_bill.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.label2.Size = new System.Drawing.Size(121, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bill No :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DGV_List2
            // 
            this.DGV_List2.AllowUserToAddRows = false;
            this.DGV_List2.AllowUserToDeleteRows = false;
            this.DGV_List2.BackgroundColor = System.Drawing.Color.White;
            this.DGV_List2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_List2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DGV_List2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_List2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DGV_List2.ColumnHeadersHeight = 56;
            this.DGV_List2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV_List2.ColumnHeadersVisible = false;
            this.DGV_List2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Code,
            this.Product,
            this.Cost,
            this.Qty,
            this.Amount,
            this.btnDelete});
            this.DGV_List2.EnableHeadersVisualStyles = false;
            this.DGV_List2.GridColor = System.Drawing.Color.White;
            this.DGV_List2.Location = new System.Drawing.Point(-1, 110);
            this.DGV_List2.Margin = new System.Windows.Forms.Padding(0);
            this.DGV_List2.MultiSelect = false;
            this.DGV_List2.Name = "DGV_List2";
            this.DGV_List2.ReadOnly = true;
            this.DGV_List2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_List2.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DGV_List2.RowHeadersVisible = false;
            this.DGV_List2.RowHeadersWidth = 50;
            this.DGV_List2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(189)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_List2.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DGV_List2.RowTemplate.Height = 40;
            this.DGV_List2.RowTemplate.ReadOnly = true;
            this.DGV_List2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_List2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_List2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_List2.Size = new System.Drawing.Size(947, 555);
            this.DGV_List2.TabIndex = 3;
            this.DGV_List2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_List2_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "No";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cost
            // 
            this.Cost.FillWeight = 75F;
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cost.Width = 125;
            // 
            // Qty
            // 
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Qty.Width = 50;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Amount.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Action";
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.MinimumWidth = 6;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDelete.Width = 125;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.panel6.Controls.Add(this.lbl_qty);
            this.panel6.Controls.Add(this.btn_min);
            this.panel6.Controls.Add(this.btn_buy_item);
            this.panel6.Controls.Add(this.btn_plus);
            this.panel6.Controls.Add(this.txt_qty);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(364, 908);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(725, 112);
            this.panel6.TabIndex = 3;
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(48)))));
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ForeColor = System.Drawing.Color.White;
            this.lbl_qty.Location = new System.Drawing.Point(385, 31);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.lbl_qty.Size = new System.Drawing.Size(50, 51);
            this.lbl_qty.TabIndex = 3;
            this.lbl_qty.Text = "1";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(48)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(312, 31);
            this.btn_min.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(56, 52);
            this.btn_min.TabIndex = 5;
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_buy_item
            // 
            this.btn_buy_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.btn_buy_item.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_buy_item.FlatAppearance.BorderSize = 0;
            this.btn_buy_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy_item.ForeColor = System.Drawing.Color.Transparent;
            this.btn_buy_item.Location = new System.Drawing.Point(569, 32);
            this.btn_buy_item.Margin = new System.Windows.Forms.Padding(0);
            this.btn_buy_item.Name = "btn_buy_item";
            this.btn_buy_item.Size = new System.Drawing.Size(141, 50);
            this.btn_buy_item.TabIndex = 4;
            this.btn_buy_item.Text = "ADD";
            this.btn_buy_item.UseVisualStyleBackColor = false;
            this.btn_buy_item.Click += new System.EventHandler(this.btn_buy_item_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(54)))), ((int)(((byte)(48)))));
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Image = ((System.Drawing.Image)(resources.GetObject("btn_plus.Image")));
            this.btn_plus.Location = new System.Drawing.Point(457, 30);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(56, 52);
            this.btn_plus.TabIndex = 3;
            this.btn_plus.TabStop = false;
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(177)))));
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.Location = new System.Drawing.Point(15, 31);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_qty.Multiline = true;
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.ReadOnly = true;
            this.txt_qty.Size = new System.Drawing.Size(288, 50);
            this.txt_qty.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.button10);
            this.panel7.Controls.Add(this.button9);
            this.panel7.Controls.Add(this.button8);
            this.panel7.Location = new System.Drawing.Point(0, -1);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 1039);
            this.panel7.TabIndex = 4;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 986);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(300, 53);
            this.button10.TabIndex = 2;
            this.button10.Text = "Log out";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 427);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(300, 58);
            this.button9.TabIndex = 1;
            this.button9.Text = "New Loyality";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(145)))), ((int)(((byte)(109)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 357);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(300, 57);
            this.button8.TabIndex = 0;
            this.button8.Text = "Invoice";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome,";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(431, 11);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(0, 29);
            this.lbl_user.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PointOfSale.Properties.Resources.shopmart_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(23, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.label4.Location = new System.Drawing.Point(91, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cashier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.label5.Location = new System.Drawing.Point(69, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Welcome to";
            // 
            // CashierMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(243)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1924, 1034);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CashierMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierMain_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_List2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView DGV_List1;
        private System.Windows.Forms.Button btn_buy_item;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.DataGridView DGV_List2;
        private System.Windows.Forms.Label lbl_bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_net;
        private System.Windows.Forms.TextBox txt_cash;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ptn_print;
        private System.Windows.Forms.Button btn_lo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}