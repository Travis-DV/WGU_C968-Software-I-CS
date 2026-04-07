namespace WGU_C968_Software_I_CS;

public partial class ProductForm : Form
{
    private inventoryClass inventory;
    private productClass product;
    
    private int inv;
    private decimal price = -1;
    private int min = -1;
    private int max = -1;
    private int mid = -1;
    
    public ProductForm(inventoryClass _inventory, string TitleString)
    {
        InitializeComponent();
        AllPartsListView.HideSelection = true;
        AssociatedPartsListView.HideSelection = true;
        this.Text = TitleString;
        this.TitleLabel.Text = TitleString;
        
        #region Set Columns

        AllPartsListView.Columns.Add("ID", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("Name", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("Price", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("InStock", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("Min", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("Max", -2, HorizontalAlignment.Center);
        
        AssociatedPartsListView.Columns.Add("ID", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("Name", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("Price", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("InStock", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("Min", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("Max", -2, HorizontalAlignment.Center);

        #endregion
        
        this.inventory = _inventory;
        this.IDTextbox.Text = (this.inventory.Products.Last().Value.ID+1).ToString();
        this.product = new productClass(AssociatedPartsListView.Items.AddRange, AssociatedPartsListView.Items.Clear, (this.inventory.Products.Last().Value.ID+1), "", -1, -1, -1, -1);
        this.AllPartsListView.Items.AddRange(this.inventory.Parts.ToListViewItemArray());
    }
    public ProductForm(inventoryClass _inventory, string TitleString, productClass product)
    {
        InitializeComponent();
        AllPartsListView.HideSelection = true;
        AssociatedPartsListView.HideSelection = true;
        this.Text = TitleString;
        this.TitleLabel.Text = TitleString;
        
        #region Set Columns

        AllPartsListView.Columns.Add("ID", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("Name", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("Price", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("InStock", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("Min", -2, HorizontalAlignment.Center);
        AllPartsListView.Columns.Add("Max", -2, HorizontalAlignment.Center);
        
        AssociatedPartsListView.Columns.Add("ID", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("Name", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("Price", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("InStock", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("Min", -2, HorizontalAlignment.Center);
        AssociatedPartsListView.Columns.Add("Max", -2, HorizontalAlignment.Center);

        #endregion
        
        this.inventory = _inventory;
        this.IDTextbox.Text = (product.ID).ToString();
        this.product = product;
        this.product.AssociatedParts.addDelegates(AssociatedPartsListView.Items.AddRange, AssociatedPartsListView.Items.Clear);
        this.AllPartsListView.Items.AddRange(this.inventory.Parts.ToListViewItemArray());
        this.AssociatedPartsListView.Items.AddRange(this.product.AssociatedParts.ToListViewItemArray());
        
        this.IDTextbox.Text = this.product.ID.ToString();
        this.NameTextbox.Text = this.product.Name;
        this.InventoryTextbox.Text = this.product.InStock.ToString();
        this.PriceTextbox.Text = this.product.Price.ToString();
        this.MinTextbox.Text = this.product.Minimum.ToString();
        this.MaxTextbox.Text = this.product.Maximum.ToString();

    }

    private void AllPartsSearchButtonClick(object sender, EventArgs e)
    {
        if (AllPartsSearchTextbox.Text == "")
        {
            return;
        }
        
        foreach (ListViewItem listViewItem in AllPartsListView.Items)
        {
            listViewItem.Selected = false;
        }
        List<int> indexs;
        
        int searchInt;
        if (int.TryParse(AllPartsSearchTextbox.Text, out searchInt))
        {
            indexs = this.inventory.search(inventory.Parts, searchInt);
        }
        else
        {
            indexs = this.inventory.search(inventory.Parts, AllPartsSearchTextbox.Text);
        }
        
        foreach (int i in indexs)
        {
            AllPartsListView.Items[i].Selected = true;
        }
    }

    private void AddPartButton_Click(object sender, EventArgs e)
    {
        List<ListViewItem> selected = this.AllPartsListView.SelectedItems.Cast<ListViewItem>().ToList();
        foreach (ListViewItem partLVI in selected)
        {
            int index = int.Parse(partLVI.SubItems[0].Text);
            if (this.product.AssociatedParts.ContainsValue(this.inventory.Parts[index]))
            {
                continue;
            }
            this.product.addAssociatedPart((partClass)this.inventory.Parts[index]);
        }
    }

    private void RemovePartButton_Click(object sender, EventArgs e)
    {
        List<ListViewItem> selected = this.AssociatedPartsListView.SelectedItems.Cast<ListViewItem>().ToList();
        foreach (ListViewItem selectedLVI in selected)
        {
            this.product.removeAssociatedPart(int.Parse(selectedLVI.SubItems[0].Text));
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult confirmation = MessageBox.Show("Your changes will not be saved!", "Are you sure you want to exit.", MessageBoxButtons.YesNo);
        if (confirmation == DialogResult.Yes)
        {
            this.Close();
        }
    }


    private void SaveButton_Click(object sender, EventArgs e)
    {
        NameTextbox.BackColor = Color.White;
        InventoryTextbox.BackColor = Color.White;
        PriceTextbox.BackColor = Color.White;
        MinTextbox.BackColor = Color.White;
        MaxTextbox.BackColor = Color.White;
        
        if (NameTextbox.Text == "")
        {
            NameTextbox.BackColor = Color.Red;
            MessageBox.Show("Name Required!");
            return;
        }
        if (InventoryTextbox.Text == "")
        {
            InventoryTextbox.BackColor = Color.Red;
            MessageBox.Show("Inventory Amount Required!");
            return;
        }
        if (!int.TryParse(InventoryTextbox.Text, out this.inv))
        {
            InventoryTextbox.BackColor = Color.Red;
            MessageBox.Show("Inventory amount must be a number!");
            return;
        }
        if (PriceTextbox.Text == "")
        {
            PriceTextbox.BackColor = Color.Red;
            MessageBox.Show($"{PriceLabel.Text} Amount Required!");
            return;
        }
        if (!decimal.TryParse(PriceTextbox.Text, out this.price) || this.price <= 0)
        {
            PriceTextbox.BackColor = Color.Red;
            MessageBox.Show($"{PriceLabel.Text} amount must be a number greater than 0!");
            return;
        }
        if (MinTextbox.Text == "")
        {
            MinTextbox.BackColor = Color.Red;
            MessageBox.Show("Minimum Inventory Amount Required!");
            return;
        }
        if (!int.TryParse(MinTextbox.Text, out this.min) || this.min < 0)
        {
            MinTextbox.BackColor = Color.Red;
            MessageBox.Show($"{MinTextbox.Text} amount must be a number greater than or equal to 0!");
            return;
        }
        if (MaxTextbox.Text == "")
        {
            MaxTextbox.BackColor = Color.Red;
            MessageBox.Show("Inventory Amount Required");
            return;
        }
        if (!int.TryParse(MaxTextbox.Text, out this.max) || this.max <= 0)
        {
            MaxTextbox.BackColor = Color.Red;
            MessageBox.Show($"{MaxTextbox.Text} amount must be a number greater than 0!");
            return;
        }
        if (this.min > this.max)
        {
            MinTextbox.BackColor = Color.Red;
            MessageBox.Show($"Minimum inventory amount must be less than maximum ({min})!");
            return;
        }
        if (this.max < this.min)
        {
            MaxTextbox.BackColor = Color.Red;
            MessageBox.Show($"Maximum inventory amount must be greater than minimum ({max})!");
            return;
        }
        if (this.min == this.max)
        {
            MinTextbox.BackColor = Color.Red;
            MaxTextbox.BackColor = Color.Red;
            MessageBox.Show($"Minimum and Maximum can not be the same!");
            return;
        }
        if (this.inv < this.min)
        {
            InventoryTextbox.BackColor = Color.Red;
            MessageBox.Show($"Inventory amount must be a number greater than the minimum ({min})");
            return;
        }
        if (this.inv > this.max)
        {
            InventoryTextbox.BackColor = Color.Red;
            MessageBox.Show($"Inventory amount must be a number less than the maximum ({max})");
            return;
        }

        if (this.product.AssociatedParts.Count <= 0)
        {
            MessageBox.Show("Product have at least one associated part!");
            return;
        }

        this.product.Name = this.NameTextbox.Text;
        this.product.Price = this.price;
        this.product.InStock = this.inv;
        this.product.Minimum = this.min;
        this.product.Maximum = this.max;
        this.product.AssociatedParts.removeDelegates();


        if (!this.inventory.Products.ContainsKey(int.Parse(this.IDTextbox.Text)))
        {
            this.inventory.addProduct(this.product);
        }
        else if (this.inventory.Products.ContainsKey(int.Parse(this.IDTextbox.Text)))
        {
            this.inventory.updateProduct(int.Parse(this.IDTextbox.Text), this.product);
        }
        this.Close();
    }

    private void AllPartsListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.AllPartsListView.Items.Cast<ListViewItem>()
            .ToList().ForEach(item =>
            {
                item.BackColor = SystemColors.Window;
                item.ForeColor = SystemColors.WindowText;
            });
        this.AllPartsListView.SelectedItems.Cast<ListViewItem>()
            .ToList().ForEach(item =>
            {
                item.BackColor = SystemColors.Highlight;
                item.ForeColor = SystemColors.HighlightText;
            });
    }

    private void AssociatedPartsListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.AssociatedPartsListView.Items.Cast<ListViewItem>()
            .ToList().ForEach(item =>
            {
                item.BackColor = SystemColors.Window;
                item.ForeColor = SystemColors.WindowText;
            });
        this.AssociatedPartsListView.SelectedItems.Cast<ListViewItem>()
            .ToList().ForEach(item =>
            {
                item.BackColor = SystemColors.Highlight;
                item.ForeColor = SystemColors.HighlightText;
            });
    }
}