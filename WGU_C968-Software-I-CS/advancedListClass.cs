using System.ComponentModel;

namespace WGU_C968_Software_I_CS;

public class advancedListClass : BindingList<baseData>
{
    public advancedListClass() : base() {}
    
    public ListViewItem[] ToListViewItemArray()
    {
        ListViewItem[] toListViewItemArray = new ListViewItem[this.Count];
        for (int i = 0; i < this.Count; i++)
        {
            toListViewItemArray[i] = this[i].ToListViewItem();
        }

        return toListViewItemArray;
    }

    public String[] ToNameArray()
    {
        String[] toNameArray = new String[this.Count];
        for (int i = 0; i < this.Count; i++)
        {
            toNameArray[i] = this[i].Name;
        }

        return toNameArray;
    }
    
    public int[] ToIdArray()
    {
        int[] toIdArray = new int[this.Count];
        for (int i = 0; i < this.Count; i++)
        {
            toIdArray[i] = this[i].ID;
        }

        return toIdArray;
    }
}