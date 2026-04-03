namespace WGU_C968_Software_I_CS;

public partial class PartsForm : Form
{
    private inventoryClass Inventory;
    private int inv;
    private decimal price = -1;
    private int min = -1;
    private int max = -1;
    private int mid = -1;

    private int modIndex = -1;
    
    public PartsForm(inventoryClass _Inventory, string TitleString)
    {
        InitializeComponent();
        this.Inventory = _Inventory;
        this.TitleLabel.Text = TitleString;
        this.Text = TitleString;
        this.IDTextbox.Text = (this.Inventory.Parts.Count + 1).ToString();
    }
    public PartsForm(inventoryClass _Inventory, string TitleString, baseData modPart)
    {
        InitializeComponent();
        this.Inventory = _Inventory;
        this.TitleLabel.Text = TitleString;
        this.Text = TitleString;
        modIndex = modPart.ID-1;
        
        this.IDTextbox.Text = modPart.ID.ToString();
        this.NameTextbox.Text = modPart.Name;
        this.InventoryTextbox.Text = modPart.InStock.ToString();
        this.VariableTextbox1.Text = modPart.Price.ToString();
        this.MinTextbox.Text = modPart.Minimum.ToString();
        this.MaxTextbox.Text = modPart.Maximum.ToString();

        if (modPart.GetType() == typeof(partInHouse))
        {
            partInHouse pModPart = (partInHouse)modPart;
            InHouseRadioButton.Checked = true;
            VariableLabel1.Text = "Cost";
            VariableLabel2.Text = "Machine ID";
            this.VariableTextbox2.Text = pModPart.MachineID.ToString();
        }
        else if (modPart.GetType() == typeof(partOutsourced))
        {
            partOutsourced oModPart = (partOutsourced)modPart;
            OutsourcedRadioButton.Checked = true;
            VariableLabel1.Text = "Price";
            VariableLabel2.Text = "Company Name";
            this.VariableTextbox2.Text = oModPart.CompanyName;
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

    private void InHouseRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        VariableLabel1.Text = "Cost";
        VariableLabel2.Text = "Machine ID";
    }

    private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        VariableLabel1.Text = "Price";
        VariableLabel2.Text = "Company Name";
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        NameTextbox.BackColor = Color.White;
        InventoryTextbox.BackColor = Color.White;
        VariableTextbox1.BackColor = Color.White;
        MinTextbox.BackColor = Color.White;
        MaxTextbox.BackColor = Color.White;
        VariableTextbox2.BackColor = Color.White;
        
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
            NameTextbox.BackColor = Color.Red;
            MessageBox.Show("Inventory amount must be a number!");
            return;
        }
        if (VariableTextbox1.Text == "")
        {
            VariableTextbox1.BackColor = Color.Red;
            MessageBox.Show($"{VariableLabel1.Text} Amount Required!");
            return;
        }
        if (!decimal.TryParse(VariableTextbox1.Text, out this.price) || this.price <= 0)
        {
            VariableTextbox1.BackColor = Color.Red;
            MessageBox.Show($"{VariableLabel1.Text} amount must be a number greater than 0!");
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

        if (VariableTextbox2.Text == "")
        {
            VariableTextbox2.BackColor = Color.Red;
            MessageBox.Show($"{VariableLabel2.Text} is required!");
            return;
        }
        
        if (!(InHouseRadioButton.Checked && int.TryParse(VariableTextbox2.Text, out this.mid) && this.mid > 0) && !OutsourcedRadioButton.Checked)
        {
            VariableTextbox2.BackColor = Color.Red;
            MessageBox.Show($"{VariableLabel2.Text} must be a number greater than 0!");
            return;
        }

        if (InHouseRadioButton.Checked && modIndex == -1)
        {
            this.Inventory.addPart(new partInHouse(
                (this.Inventory.Parts.Count + 1),
                this.NameTextbox.Text,
                this.price,
                this.inv,
                this.min,
                this.max,
                this.mid
            )); 
        }
        else if (InHouseRadioButton.Checked && modIndex != -1)
        {
            this.Inventory.updatePart(modIndex, new partInHouse(
                (this.modIndex + 1),
                this.NameTextbox.Text,
                this.price,
                this.inv,
                this.min,
                this.max,
                this.mid
            ));
        }
        else if (OutsourcedRadioButton.Checked && modIndex == -1)
        {
            this.Inventory.addPart(new partOutsourced(
                (this.Inventory.Parts.Count + 1),
                this.NameTextbox.Text,
                this.price,
                this.inv,
                this.min,
                this.max,
                VariableTextbox2.Text
            )); 
        }
        else if (OutsourcedRadioButton.Checked && modIndex != -1)
        {
            this.Inventory.updatePart(modIndex, new partOutsourced(
                (this.modIndex + 1),
                this.NameTextbox.Text,
                this.price,
                this.inv,
                this.min,
                this.max,
                VariableTextbox2.Text
            ));
        }
        this.Close();
    }
}