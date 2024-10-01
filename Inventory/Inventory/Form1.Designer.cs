namespace Inventory
{
    partial class frmAddProduct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtProductName = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgdate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            txtQuantity = new TextBox();
            textSellPrice = new TextBox();
            gridViewProductList = new DataGridView();
            richTextDescription = new RichTextBox();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 46);
            label1.Name = "label1";
            label1.Size = new Size(156, 24);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 103);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 144);
            label3.Name = "label3";
            label3.Size = new Size(75, 18);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 184);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 3;
            label4.Text = "Mfg. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 225);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 4;
            label5.Text = "Exp. Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 258);
            label6.Name = "label6";
            label6.Size = new Size(40, 18);
            label6.TabIndex = 5;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 297);
            label7.Name = "label7";
            label7.Size = new Size(76, 18);
            label7.TabIndex = 6;
            label7.Text = "Sale Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Berlin Sans FB Demi", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(418, 78);
            label8.Name = "label8";
            label8.Size = new Size(89, 18);
            label8.TabIndex = 7;
            label8.Text = "Description";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(141, 103);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(201, 23);
            txtProductName.TabIndex = 8;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(141, 139);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(201, 23);
            cbCategory.TabIndex = 9;
            // 
            // dtPickerMfgdate
            // 
            dtPickerMfgdate.Location = new Point(141, 184);
            dtPickerMfgdate.Name = "dtPickerMfgdate";
            dtPickerMfgdate.Size = new Size(200, 23);
            dtPickerMfgdate.TabIndex = 10;
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(142, 225);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(200, 23);
            dtPickerExpDate.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(142, 258);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(201, 23);
            txtQuantity.TabIndex = 12;
            // 
            // textSellPrice
            // 
            textSellPrice.Location = new Point(142, 297);
            textSellPrice.Name = "textSellPrice";
            textSellPrice.Size = new Size(201, 23);
            textSellPrice.TabIndex = 13;
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(46, 326);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(727, 150);
            gridViewProductList.TabIndex = 14;
            // 
            // richTextDescription
            // 
            richTextDescription.Location = new Point(418, 106);
            richTextDescription.Name = "richTextDescription";
            richTextDescription.Size = new Size(306, 137);
            richTextDescription.TabIndex = 15;
            richTextDescription.Text = "";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(602, 273);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(112, 23);
            btnAddProduct.TabIndex = 16;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(btnAddProduct);
            Controls.Add(richTextDescription);
            Controls.Add(gridViewProductList);
            Controls.Add(textSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgdate);
            Controls.Add(cbCategory);
            Controls.Add(txtProductName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddProduct";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtProductName;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgdate;
        private DateTimePicker dtPickerExpDate;
        private TextBox txtQuantity;
        private TextBox textSellPrice;
        private DataGridView gridViewProductList;
        private RichTextBox richTextDescription;
        private Button btnAddProduct;
    }
}
