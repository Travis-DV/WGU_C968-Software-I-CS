namespace WGU_C968_Software_I_CS;

public partial class mainForm : Form
{
    
    inventoryClass inventory = new inventoryClass();
    
    public mainForm()
    {
        InitializeComponent();
        

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
        
        PartsListView.Items.AddRange(inventory.Parts.ToListViewItemArray());
        ProductsListView.Items.AddRange(inventory.Products.ToListViewItemArray());
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
}