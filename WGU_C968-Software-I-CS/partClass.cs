using System.Reflection.PortableExecutable;

namespace WGU_C968_Software_I_CS;

public abstract class partClass : baseData
{

    public partClass(int _ID, string _Name, decimal _Price, int _InStock, int _Minimum, int _Maximum)
    {
        this.ID = _ID;
        this.Name = _Name;
        this.Price = _Price;
        this.InStock = _InStock;
        this.Minimum = _Minimum;
        this.Maximum = _Maximum;
    }
}

public class partInHouse : partClass
{
    public int MachineID;

    public partInHouse(int _ID, string _Name, decimal _Price, int _InStock, int _Minimum, int _Maximum, int _MachineID)
        : base(_ID, _Name, _Price, _InStock, _Minimum, _Maximum)
    {
        this.MachineID = _MachineID;
    }
    
    // public ListViewItem ToListViewItem()
    // {
    //     ListViewItem PartLVI = base.ToListViewItem();
    //     PartLVI.SubItems.Add(this.MachineID.ToString());
    //     return PartLVI;
    // }
}
public class partOutsourced : partClass
{
    public string CompanyName;
    
    public partOutsourced(int _ID, string _Name, decimal _Price, int _InStock, int _Minimum, int _Maximum, string _CompanyName)
        : base(_ID, _Name, _Price, _InStock, _Minimum, _Maximum)
    {
        this.CompanyName = _CompanyName;
    }
    
    // public ListViewItem ToListViewItem()
    // {
    //     ListViewItem PartLVI = base.ToListViewItem();
    //     PartLVI.SubItems.Add(this.CompanyName.ToString());
    //     return PartLVI;
    // }
}