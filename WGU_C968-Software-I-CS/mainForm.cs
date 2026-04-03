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
        
        inventory.Parts.Add(new partInHouse(1, "part1", 11.2m, 10, 20, 2, 1));
        inventory.Parts.Add(new partInHouse(2, "part2", 21.2m, 20, 20, 2, 1));
        inventory.Parts.Add(new partInHouse(3, "part3", 31.2m, 30, 30, 2, 1));
        
        inventory.Products.Add(new partInHouse(1, "product1", 11.2m, 10, 20, 2, 1));
        inventory.Products.Add(new partInHouse(2, "product2", 21.2m, 20, 20, 2, 1));
        inventory.Products.Add(new partInHouse(3, "product3", 31.2m, 30, 30, 2, 1));
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
        this.external(this.PartsListView.SelectedIndices.Cast<int>().ToList());
    }

    private void external(List<int> selected)
    {
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
        throw new System.NotImplementedException();
    }

    private void ProductsAddButton_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void ProductsModifyButton_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void ProductsDeleteButton_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}