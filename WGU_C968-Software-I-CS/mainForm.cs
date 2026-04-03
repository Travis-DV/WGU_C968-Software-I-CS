namespace WGU_C968_Software_I_CS;

public partial class mainForm : Form
{
    
    inventoryClass inventory;

    public delegate void LVIAddRange(params ListViewItem[] items);

    public delegate void LVIClear();
    
    public mainForm()
    {
        InitializeComponent();
        LVIAddRange PartsLVIAddRange = PartsListView.Items.AddRange;
        LVIClear PartsLVIClear = PartsListView.Items.Clear;
        LVIAddRange ProductsLVIAddRange = ProductsListView.Items.AddRange;
        LVIClear ProductsLVIClear = ProductsListView.Items.Clear;
        this.inventory = new inventoryClass(PartsLVIAddRange, PartsLVIClear, ProductsLVIAddRange, ProductsLVIClear);

        #region Set Columns

        PartsListView.Columns.Add("ID", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("Name", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("Price", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("InStock", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("Min", -2, HorizontalAlignment.Center);
        PartsListView.Columns.Add("Max", -2, HorizontalAlignment.Center);
        
        ProductsListView.Columns.Add("ID", -2, HorizontalAlignment.Center);
        ProductsListView.Columns.Add("Name", -2, HorizontalAlignment.Center);
        ProductsListView.Columns.Add("Price", -2, HorizontalAlignment.Center);
        ProductsListView.Columns.Add("InStock", -2, HorizontalAlignment.Center);
        ProductsListView.Columns.Add("Min", -2, HorizontalAlignment.Center);
        ProductsListView.Columns.Add("Max", -2, HorizontalAlignment.Center);

        #endregion
        
        inventory.Parts.Add(new partInHouse(0, "part1", 11.2m, 10, 1, 10, 1));
        inventory.Parts.Add(new partInHouse(1, "part2", 21.2m, 20, 2, 20, 2));
        inventory.Parts.Add(new partInHouse(2, "part3", 31.2m, 30, 3, 30, 2));
        
        inventory.Products.Add(new productClass(null, null, 0, "product1", 11.2m, 10, 20, 2));
        inventory.Products.Add(new productClass(null, null,1, "product2", 21.2m, 20, 20, 2));
        inventory.Products.Add(new productClass(null, null, 2, "product3", 31.2m, 30, 30, 2));
    }

    private void PartsSearchButton_Click(object sender, EventArgs e)
    {
        if (PartsSearchTextbox.Text == "")
        {
            return;
        }
        
        foreach (ListViewItem listViewItem in PartsListView.Items)
        {
            listViewItem.Selected = false;
        }
        List<int> indexs;
        
        int searchInt;
        if (int.TryParse(PartsSearchTextbox.Text, out searchInt))
        {
            indexs = this.inventory.search(inventory.Parts, searchInt);
        }
        else
        {
            indexs = this.inventory.search(inventory.Parts, PartsSearchTextbox.Text);
        }
        
        foreach (int i in indexs)
        {
            PartsListView.Items[i].Selected = true;
        }
    }

    private void ProductsSearchButtonClick(object sender, EventArgs e)
    {
        if (ProductsSearchTextbox.Text == "")
        {
            return;
        }
        
        foreach (ListViewItem listViewItem in ProductsListView.Items)
        {
            listViewItem.Selected = false;
        }
        List<int> indexs;
        
        int searchInt;
        if (int.TryParse(ProductsSearchTextbox.Text, out searchInt))
        {
            indexs = this.inventory.search(inventory.Products, searchInt);
        }
        else
        {
            indexs = this.inventory.search(inventory.Products, ProductsSearchTextbox.Text);
        }
        
        foreach (int i in indexs)
        {
            ProductsListView.Items[i].Selected = true;
        }
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }

    private void PartsAddButton_Click(object sender, EventArgs e)
    {
        PartsForm newPart = new PartsForm(inventory, "Add Part");
        using (newPart)
        {
            newPart.ShowDialog();
        }
    }

    private void PartsModifyButton_Click(object sender, EventArgs e)
    {
        List<int> selected = this.PartsListView.SelectedIndices.Cast<int>().ToList();
        foreach (int index in selected)
        {
            PartsForm modPart = new PartsForm(inventory, "Modify Part", inventory.Parts[index]);
            using (modPart)
            {
                modPart.ShowDialog();
            }
        }
    }

    private void PartsDeleteButton_Click(object sender, EventArgs e)
    {
        List<int> selected = this.PartsListView.SelectedIndices.Cast<int>().ToList();
        int subtractor = 0;
        for (int i = 0; (i-subtractor) < selected.Count; i++)
        {
            bool dontdo = false;
            foreach (baseData bd in this.inventory.Products)
            {
                productClass product = (productClass)bd;
                if (product.AssociatedParts.Contains(this.inventory.Parts[selected[i - subtractor] - subtractor]))
                {
                    MessageBox.Show($"Can not delete part associated with a product ({product.Name})");
                    dontdo = true;
                }
            }

            if (dontdo)
            {
                continue;
            }
            DialogResult confirmation = MessageBox.Show($"Are you sure you want to Delete {this.inventory.Parts[selected[i-subtractor]-subtractor].Name}.\nAll data will be lost!", $"Are you sure!", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                inventory.Parts.RemoveAt(selected[i-subtractor]-subtractor);
                selected.RemoveAt(i-subtractor);
                subtractor++;
            }
        }
    }

    private void ProductsAddButton_Click(object sender, EventArgs e)
    {
        ProductForm newProduct = new ProductForm(this.inventory, "Add Product");
        using (newProduct)
        {
            newProduct.ShowDialog();
        }
        
    }

    private void ProductsModifyButton_Click(object sender, EventArgs e)
    {
        List<int> selected = this.ProductsListView.SelectedIndices.Cast<int>().ToList();
        foreach (int index in selected)
        {
            ProductForm modPart = new ProductForm(inventory, "Modify Part", (productClass)inventory.Products[index]);
            using (modPart)
            {
                modPart.ShowDialog();
            }
        }
    }

    private void ProductsDeleteButton_Click(object sender, EventArgs e)
    {
        List<int> selected = this.ProductsListView.SelectedIndices.Cast<int>().ToList();
        int subtractor = 0;
        for (int i = 0; (i-subtractor) < selected.Count; i++)
        {
            DialogResult confirmation = MessageBox.Show($"Are you sure you want to Delete {this.inventory.Products[selected[i-subtractor]-subtractor].Name}.\nAll data will be lost!", $"Are you sure!", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                inventory.removeProduct(selected[i-subtractor]-subtractor);
                selected.RemoveAt(i-subtractor);
                subtractor++;
            }
        }
    }
}