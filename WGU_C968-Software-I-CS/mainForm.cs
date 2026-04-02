namespace WGU_C968_Software_I_CS;

public partial class mainForm : Form
{
    public mainForm()
    {
        InitializeComponent();
        
        inventoryClass inventory = new inventoryClass();
        inventory.Parts.Add(new partInHouse(1, "Something1", 11.2m, 10, 20, 2, 1));
        inventory.Parts.Add(new partInHouse(2, "Something2", 21.2m, 20, 20, 2, 1));
        inventory.Parts.Add(new partInHouse(3, "Something3", 31.2m, 30, 30, 2, 1));
        Console.WriteLine(inventory.Parts[1].Name);
        PartsListView.Items.AddRange(inventory.inventoryPartsLVIA());
    }
}