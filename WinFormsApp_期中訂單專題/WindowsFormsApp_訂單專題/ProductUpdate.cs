using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp_訂單專題
{
    public partial class ProductUpdate : Form
    {
        SqlConnectionStringBuilder scsb;
        string imgdir ;
        struct _product //定義暫存商品資料的結構
        {
            public short P_ID;
            public string P_Name;
            public string P_type;
            public short P_price;
            public string P_image;
        }
        List<_product> productList = new List<_product>();

        public ProductUpdate()
        {
            InitializeComponent();
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            scsb= new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mid_proj";
            scsb.IntegratedSecurity= true;

            imgdir = Application.ExecutablePath;
            for( short i = 0; i < 5; i++)
                imgdir = System.IO.Directory.GetParent(imgdir).ToString();
            imgdir += @"\IMGsource\";

            cBox1_type.Items.Add("main");
            cBox1_type.Items.Add("beverage");
            cBox1_type.Items.Add("sweet");

            LoadtoLV();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //新增商品
            try// 確保數值為正
            {
                Convert.ToUInt16(txt_price.Text);
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if ( Convert.ToInt16( txt_price.Text) < 500 && txt_Name.Text !="" && cBox1_type.Text != "" && txt_price.Text != "" )
            {
                NewProduct();
                
                txt_Name.Clear();
                cBox1_type.Text = "";
                txt_price.Clear();
                productList.Clear();
                listView1.Clear();
                LoadtoLV();

            }

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            //更改商品
            try// 確保數值為正
            {
                Convert.ToUInt16(txt_price.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (Convert.ToInt16(txt_price.Text) < 500 && cBox1_type.Text != "" && txt_price.Text != "")
            { 
                ChangeProduct();
                productList.Clear();
                listView1.Clear();
                LoadtoLV();

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( listView1.SelectedItems.Count != 0)
            {
                btn_update.Enabled = false;
                btn_change.Enabled = true;
                txt_Name.ReadOnly= true;

                foreach( ListViewItem litem in listView1.SelectedItems)
                {
                    txt_Name.Text = litem.Text;

                    foreach ( var v in productList)
                    {
                        if ( v.P_Name == litem.Text)
                        {
                            cBox1_type.Text = v.P_type;
                            txt_price.Text = v.P_price.ToString();
                            lbl_fname.Text = v.P_image;
                        }
                    }
                }

            }
            else
            {
                txt_Name.Clear();
                cBox1_type.Text = "";
                txt_price.Clear();
                lbl_fname.Text = "";
                btn_update.Enabled = true;
                btn_change.Enabled= false;
                txt_Name.ReadOnly= false;
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            productList.Clear();
            listView1.Clear();
            LoadtoLV();
        }

        private void btn_selpic_Click(object sender, EventArgs e)
        {
            //選擇圖片
            openFileDialog1.Filter = "檔案類型 (*.jpg, *.jpeg, *.png, *.gif)|*.jpeg;*.jpg;*.png;*.gif";
            DialogResult R = openFileDialog1.ShowDialog();

            if ( R == DialogResult.OK)
            {
                string Fname = openFileDialog1.SafeFileName;
                Image.FromFile(openFileDialog1.FileName).Save( imgdir + Fname  );
                lbl_fname.Text = Fname;
            }

        }

        //==============自訂函式=================

        void LoadtoLV()//讀取資料至listview
        {
            SqlConnection conn = new SqlConnection(scsb.ConnectionString);
            conn.Open();
            string sql = " SELECT * FROM Product ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                _product P = new _product();
                P.P_ID = Convert.ToInt16( r["P_ID"]);
                P.P_Name = r["P_Name"].ToString();
                P.P_type = r["P_type"].ToString();
                P.P_price = Convert.ToInt16( r["P_price"] );
                P.P_image = r["P_image"].ToString();
                productList.Add(P);
            }
            if( productList.Count > 0)
            {
                for( short i = 0; i < productList.Count; i++)
                {
                    listView1.Items.Add(productList[i].P_Name);

                    try
                    {
                        Image img = Image.FromFile(imgdir + productList[i].P_image);
                        imageList1.Images.Add(productList[i].P_image , img);
                    }
                    catch ( Exception e )
                    {
                        continue;
                    }
                    listView1.Items[i].ImageKey = productList[i].P_image;

                }
            }

            r.Close();
            conn.Close();

        }

        void NewProduct()//新增商品
        {

            mid_proj_DataClasses1DataContext mid_Proj_Data = new mid_proj_DataClasses1DataContext(scsb.ConnectionString);

            Product newProduct= new Product();
            newProduct.P_Name= txt_Name.Text;
            newProduct.P_type= cBox1_type.Text;
            newProduct.P_price = Convert.ToInt16( txt_price.Text);
            newProduct.P_image = lbl_fname.Text;
            mid_Proj_Data.Product.InsertOnSubmit( newProduct);
            mid_Proj_Data.SubmitChanges();

            MessageBox.Show("已新增商品");
        }

        void ChangeProduct()
        {
            mid_proj_DataClasses1DataContext mid_Proj_Data = new mid_proj_DataClasses1DataContext(scsb.ConnectionString);
            Product changeProduct = mid_Proj_Data.Product.First( s => s.P_Name == txt_Name.Text);
            changeProduct.P_type= cBox1_type.Text;
            changeProduct.P_price = Convert.ToInt16( txt_price.Text);
            changeProduct.P_image= lbl_fname.Text;
            mid_Proj_Data.SubmitChanges();

            MessageBox.Show("已更改商品");

        }

    }
}
