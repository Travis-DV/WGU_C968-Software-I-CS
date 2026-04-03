using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WGU_C968_Software_I_CS;

public abstract class baseData
{
    public int ID { get; set; }
    public string Name;
    public decimal Price;
    public int InStock;
    public int Minimum;
    public int Maximum;
    
    public ListViewItem ToListViewItem()
    {
        ListViewItem ListViewItem = new ListViewItem(this.ID.ToString());
        ListViewItem.SubItems.Add(this.Name);
        ListViewItem.SubItems.Add(this.Price.ToString("C"));
        ListViewItem.SubItems.Add(this.InStock.ToString());
        ListViewItem.SubItems.Add(this.Minimum.ToString());
        ListViewItem.SubItems.Add(this.Maximum.ToString());
        return ListViewItem;
    }
};