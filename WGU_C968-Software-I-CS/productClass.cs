using System.ComponentModel;

namespace WGU_C968_Software_I_CS;

public class productClass : baseData
{
    public advancedListClass AssociatedParts;

    public productClass(mainForm.LVIAddRange? _lviAddRange, mainForm.LVIClear? _lviClear, int _ID, string _Name, decimal _Price, int _InStock, int _Minimum, int _Maximum) : base()
    {
        this.AssociatedParts = new advancedListClass(_lviAddRange, _lviClear);
        this.ID = _ID;
        this.Name = _Name;
        this.Price = _Price;
        this.InStock = _InStock;
        this.Minimum = _Minimum;
        this.Maximum = _Maximum;
    }

    public void addAssociatedPart(partClass NewPart)
    {
        this.AssociatedParts.Add(NewPart);
    }

    public bool removeAssociatedPart(int PartIndex)
    {
        this.AssociatedParts.RemoveAt(PartIndex);
        return true;
    }

    public partClass lookupAssociatedPart(int PartIndex)
    {
        throw new NotImplementedException();
    }
}