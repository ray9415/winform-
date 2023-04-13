namespace WindowsFormsApp_訂單專題
{
    partial class MainDish
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_set = new System.Windows.Forms.RadioButton();
            this.radioBtn_neither = new System.Windows.Forms.RadioButton();
            this.picBox_main = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox_Main = new System.Windows.Forms.ListBox();
            this.listBox_Side = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_set);
            this.groupBox1.Controls.Add(this.radioBtn_neither);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "套餐選項";
            // 
            // radioBtn_set
            // 
            this.radioBtn_set.AutoSize = true;
            this.radioBtn_set.Location = new System.Drawing.Point(7, 55);
            this.radioBtn_set.Name = "radioBtn_set";
            this.radioBtn_set.Size = new System.Drawing.Size(230, 26);
            this.radioBtn_set.TabIndex = 0;
            this.radioBtn_set.TabStop = true;
            this.radioBtn_set.Text = "套餐：加100元附飲品+甜點";
            this.radioBtn_set.UseVisualStyleBackColor = true;
            this.radioBtn_set.CheckedChanged += new System.EventHandler(this.radioBtn_set_CheckedChanged);
            // 
            // radioBtn_neither
            // 
            this.radioBtn_neither.AutoSize = true;
            this.radioBtn_neither.Checked = true;
            this.radioBtn_neither.Location = new System.Drawing.Point(7, 26);
            this.radioBtn_neither.Name = "radioBtn_neither";
            this.radioBtn_neither.Size = new System.Drawing.Size(44, 26);
            this.radioBtn_neither.TabIndex = 0;
            this.radioBtn_neither.TabStop = true;
            this.radioBtn_neither.Text = "無";
            this.radioBtn_neither.UseVisualStyleBackColor = true;
            this.radioBtn_neither.CheckedChanged += new System.EventHandler(this.radioBtn_neither_CheckedChanged);
            // 
            // picBox_main
            // 
            this.picBox_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBox_main.Location = new System.Drawing.Point(482, 22);
            this.picBox_main.Name = "picBox_main";
            this.picBox_main.Size = new System.Drawing.Size(363, 315);
            this.picBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_main.TabIndex = 4;
            this.picBox_main.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_add.Location = new System.Drawing.Point(583, 371);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(145, 47);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "加入至訂單";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listBox_Main
            // 
            this.listBox_Main.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Main.FormattingEnabled = true;
            this.listBox_Main.ItemHeight = 22;
            this.listBox_Main.Location = new System.Drawing.Point(24, 88);
            this.listBox_Main.Name = "listBox_Main";
            this.listBox_Main.Size = new System.Drawing.Size(193, 158);
            this.listBox_Main.TabIndex = 5;
            this.listBox_Main.SelectedIndexChanged += new System.EventHandler(this.listBox_Main_SelectedIndexChanged);
            // 
            // listBox_Side
            // 
            this.listBox_Side.Enabled = false;
            this.listBox_Side.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Side.FormattingEnabled = true;
            this.listBox_Side.ItemHeight = 22;
            this.listBox_Side.Location = new System.Drawing.Point(226, 88);
            this.listBox_Side.Name = "listBox_Side";
            this.listBox_Side.Size = new System.Drawing.Size(193, 158);
            this.listBox_Side.TabIndex = 5;
            this.listBox_Side.SelectedIndexChanged += new System.EventHandler(this.listBox_Side_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "小計：";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(379, 404);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(40, 22);
            this.lbl_price.TabIndex = 7;
            this.lbl_price.Text = "000";
            // 
            // MainDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(841, 429);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Side);
            this.Controls.Add(this.listBox_Main);
            this.Controls.Add(this.picBox_main);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainDish";
            this.Text = "MainDish";
            this.Load += new System.EventHandler(this.MainDish_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_set;
        private System.Windows.Forms.RadioButton radioBtn_neither;
        private System.Windows.Forms.PictureBox picBox_main;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listBox_Main;
        private System.Windows.Forms.ListBox listBox_Side;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_price;
    }
}