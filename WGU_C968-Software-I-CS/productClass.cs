using System.ComponentModel;

namespace WGU_C968_Software_I_CS;

public class productClass : baseData
{
    public BindingList<partClass> AssociatedParts = new BindingList<partClass>();

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
}