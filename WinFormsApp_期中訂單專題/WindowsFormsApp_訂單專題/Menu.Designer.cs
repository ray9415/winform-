namespace WindowsFormsApp_訂單專題
{
    partial class Menu
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
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_orderManage = new System.Windows.Forms.Button();
            this.btn_productUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_order
            // 
            this.btn_order.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_order.Location = new System.Drawing.Point(61, 156);
            this.btn_order.Margin = new System.Windows.Forms.Padding(4);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(260, 101);
            this.btn_order.TabIndex = 0;
            this.btn_order.Text = "開始點餐";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            this.btn_order.MouseEnter += new System.EventHandler(this.btn_order_MouseEnter);
            this.btn_order.MouseLeave += new System.EventHandler(this.btn_order_MouseLeave);
            // 
            // btn_orderManage
            // 
            this.btn_orderManage.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderManage.Location = new System.Drawing.Point(61, 299);
            this.btn_orderManage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_orderManage.Name = "btn_orderManage";
            this.btn_orderManage.Size = new System.Drawing.Size(123, 39);
            this.btn_orderManage.TabIndex = 1;
            this.btn_orderManage.Text = "訂單管理";
            this.btn_orderManage.UseVisualStyleBackColor = true;
            // 
            // btn_productUpdate
            // 
            this.btn_productUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productUpdate.Location = new System.Drawing.Point(199, 299);
            this.btn_productUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_productUpdate.Name = "btn_productUpdate";
            this.btn_productUpdate.Size = new System.Drawing.Size(123, 39);
            this.btn_productUpdate.TabIndex = 1;
            this.btn_productUpdate.Text = "菜單更新";
            this.btn_productUpdate.UseVisualStyleBackColor = true;
            this.btn_productUpdate.Click += new System.EventHandler(this.btn_productUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "★ 麵館點餐系統 ★";
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_logout.Location = new System.Drawing.Point(140, 433);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(105, 39);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "登出權限";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(369, 556);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_productUpdate);
            this.Controls.Add(this.btn_orderManage);
            this.Controls.Add(this.btn_order);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_orderManage;
        private System.Windows.Forms.Button btn_productUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
    }
}