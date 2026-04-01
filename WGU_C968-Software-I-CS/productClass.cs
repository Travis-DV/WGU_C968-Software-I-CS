using System.ComponentModel;

namespace WGU_C968_Software_I_CS;

public class productClass
{
    public BindingList<partClass> AssociatedParts;
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
        return new partInHouse();
    }
}