using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WGU_C968_Software_I_CS;

public class advancedListClass : BindingList<baseData>
{
    private mainForm.LVIAddRange? lviAddRange;
    private mainForm.LVIClear? lviClear;

    public new baseData this[int i]
    {
        get
        {
            return base[i];
        }
    }
    
    public advancedListClass(mainForm.LVIAddRange? _lviAddRange, mainForm.LVIClear? _lviClear) : base()
    {
        this.lviAddRange = _lviAddRange;
        this.lviClear = _lviClear;
    }

    public new void Add(baseData newItem)
    {
        this.lviClear?.Invoke();
        base.Add(newItem);
        this.lviAddRange?.Invoke(this.ToListViewItemArray());
    }

    public new void RemoveAt(int index)
    {
        this.lviClear?.Invoke();
        base.RemoveAt(index);
        this.lviAddRange?.Invoke(this.ToListViewItemArray());
    }

    public new void Insert(int index, baseData item)
    {
        this.lviClear?.Invoke();
        base.Insert(index, item);
        this.lviAddRange?.Invoke(this.ToListViewItemArray());
    }

    public void addDelegates(mainForm.LVIAddRange _lviAddRange, mainForm.LVIClear _lviClear)
    {
        this.lviAddRange = _lviAddRange;
        this.lviClear = _lviClear;
    }

    public void removeDelegates()
    {
        this.lviAddRange = null;
        this.lviClear = null;
    }
    
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