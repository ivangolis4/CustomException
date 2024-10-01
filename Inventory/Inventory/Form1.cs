using System.Text.RegularExpressions;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;
        private BindingSource showProductList;
        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();

            string[] ListOfProductCategory =
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Diary",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Others"
            };

            foreach (string Category in ListOfProductCategory)
            {
                cbCategory.Items.Add(Category);
            }
        }

        public string Product_Name(string name)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    throw new StringFormatException("Invalid Product Name");
                }
                
            }
            catch(StringFormatException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }
            return name;


        }
        public int Quantity(string qty)
        {
            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new NumberFormatException("Invalid Product Number");
                }
                else
                {
                    return Convert.ToInt32(qty);
                }
            }
            catch(NumberFormatException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return 0;
            }
            
                
        }
        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                {
                    throw new CurrencyFormatException("Invalid Currency Format");
                }
                else
                {
                    return Convert.ToDouble(price);
                }
            }
            catch(CurrencyFormatException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return 0;
            }
                
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgdate.Value.ToString("yyyy-MM-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
            _Description = richTextDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(textSellPrice.Text);
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
            _ExpDate, _SellPrice, _Quantity, _Description)); gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; gridViewProductList.DataSource = showProductList;

        }




    }

}
