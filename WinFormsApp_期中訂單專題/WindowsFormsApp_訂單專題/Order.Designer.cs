namespace WindowsFormsApp_訂單專題
{
    partial class Order
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTbl = new System.Windows.Forms.ComboBox();
            this.btn_MainDish = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_side = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_finishOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "桌號";
            // 
            // cbxTbl
            // 
            this.cbxTbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTbl.FormattingEnabled = true;
            this.cbxTbl.Location = new System.Drawing.Point(63, 21);
            this.cbxTbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTbl.Name = "cbxTbl";
            this.cbxTbl.Size = new System.Drawing.Size(51, 30);
            this.cbxTbl.TabIndex = 0;
            this.cbxTbl.SelectedIndexChanged += new System.EventHandler(this.cbxTbl_SelectedIndexChanged);
            // 
            // btn_MainDish
            // 
            this.btn_MainDish.AutoSize = true;
            this.btn_MainDish.Enabled = false;
            this.btn_MainDish.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_MainDish.Location = new System.Drawing.Point(16, 131);
            this.btn_MainDish.Name = "btn_MainDish";
            this.btn_MainDish.Size = new System.Drawing.Size(96, 34);
            this.btn_MainDish.TabIndex = 2;
            this.btn_MainDish.Text = "選擇主食";
            this.btn_MainDish.UseVisualStyleBackColor = true;
            this.btn_MainDish.Click += new System.EventHandler(this.btn_MainDish_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(145, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(487, 194);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(143, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "購物車";
            // 
            // btn_side
            // 
            this.btn_side.AutoSize = true;
            this.btn_side.Enabled = false;
            this.btn_side.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_side.Location = new System.Drawing.Point(16, 178);
            this.btn_side.Name = "btn_side";
            this.btn_side.Size = new System.Drawing.Size(96, 34);
            this.btn_side.TabIndex = 2;
            this.btn_side.Text = "選擇加購";
            this.btn_side.UseVisualStyleBackColor = true;
            this.btn_side.Click += new System.EventHandler(this.btn_side_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_delete.Location = new System.Drawing.Point(314, 306);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 34);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "刪除所選";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_finishOrder
            // 
            this.btn_finishOrder.AutoSize = true;
            this.btn_finishOrder.Enabled = false;
            this.btn_finishOrder.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_finishOrder.Location = new System.Drawing.Point(433, 306);
            this.btn_finishOrder.Name = "btn_finishOrder";
            this.btn_finishOrder.Size = new System.Drawing.Size(103, 34);
            this.btn_finishOrder.TabIndex = 2;
            this.btn_finishOrder.Text = "輸出訂單";
            this.btn_finishOrder.UseVisualStyleBackColor = true;
            this.btn_finishOrder.Click += new System.EventHandler(this.btn_finishOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(149, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "電話";
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(197, 21);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(118, 26);
            this.txt_tel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "總計：";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(220, 306);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(60, 26);
            this.lbl_total.TabIndex = 7;
            this.lbl_total.Text = "0000";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(561, 335);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_finishOrder);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_side);
            this.Controls.Add(this.btn_MainDish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Order";
            this.Text = "Order";
            this.Activated += new System.EventHandler(this.Order_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Order_FormClosed);
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cbxTbl;
        private System.Windows.Forms.Button btn_MainDish;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_side;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_finishOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total;
    }
}

