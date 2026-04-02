using System.ComponentModel;

namespace WGU_C968_Software_I_CS;

public class productClass
{
    public BindingList<partClass> AssociatedParts = new BindingList<partClass>();
    public int ID;
    public string Name;
    public decimal Price;
    public int InStock;
    public int Minimum;
    public int Maximum;

    public void addAssociatedPart(partClass NewPart)
    {
        
    }

    public bool removeAssociatedPart(int PartIndex)
    {
        return false;
    }

    public partClass lookupAssociatedPart(int PartIndex)
    {
        throw new NotImplementedException();
    }
    
    public ListViewItem ToListViewItem()
    {
        ListViewItem ProductLVI = new ListViewItem(this.ID.ToString());
        ProductLVI.SubItems.Add(this.Name);
        ProductLVI.SubItems.Add(this.Price.ToString("C"));
        ProductLVI.SubItems.Add(this.InStock.ToString());
        ProductLVI.SubItems.Add(this.Minimum.ToString());
        ProductLVI.SubItems.Add(this.Maximum.ToString());
        return ProductLVI;
    }
}