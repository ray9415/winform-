namespace WindowsFormsApp_訂單專題
{
    partial class Side
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btn_addToOrder = new System.Windows.Forms.Button();
            this.listBox_Side = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_amount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBox.Location = new System.Drawing.Point(294, 23);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(355, 285);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            // 
            // btn_addToOrder
            // 
            this.btn_addToOrder.AutoSize = true;
            this.btn_addToOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToOrder.Location = new System.Drawing.Point(413, 335);
            this.btn_addToOrder.Name = "btn_addToOrder";
            this.btn_addToOrder.Size = new System.Drawing.Size(112, 34);
            this.btn_addToOrder.TabIndex = 7;
            this.btn_addToOrder.Text = "加入至訂單";
            this.btn_addToOrder.UseVisualStyleBackColor = true;
            this.btn_addToOrder.Click += new System.EventHandler(this.btn_addToOrder_Click);
            // 
            // listBox_Side
            // 
            this.listBox_Side.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Side.FormattingEnabled = true;
            this.listBox_Side.ItemHeight = 22;
            this.listBox_Side.Location = new System.Drawing.Point(22, 23);
            this.listBox_Side.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Side.Name = "listBox_Side";
            this.listBox_Side.Size = new System.Drawing.Size(230, 202);
            this.listBox_Side.TabIndex = 8;
            this.listBox_Side.SelectedIndexChanged += new System.EventHandler(this.listBox_Side_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "小計：";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(210, 335);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(40, 24);
            this.lbl_price.TabIndex = 9;
            this.lbl_price.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "份數：";
            // 
            // cbox_amount
            // 
            this.cbox_amount.Enabled = false;
            this.cbox_amount.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_amount.FormattingEnabled = true;
            this.cbox_amount.Location = new System.Drawing.Point(102, 333);
            this.cbox_amount.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_amount.Name = "cbox_amount";
            this.cbox_amount.Size = new System.Drawing.Size(57, 30);
            this.cbox_amount.TabIndex = 11;
            this.cbox_amount.SelectedIndexChanged += new System.EventHandler(this.cbox_amount_SelectedIndexChanged);
            // 
            // Side
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(641, 368);
            this.Controls.Add(this.cbox_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Side);
            this.Controls.Add(this.btn_addToOrder);
            this.Controls.Add(this.picBox);
            this.Name = "Side";
            this.Text = "Side";
            this.Load += new System.EventHandler(this.Side_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btn_addToOrder;
        private System.Windows.Forms.ListBox listBox_Side;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_amount;
    }
}