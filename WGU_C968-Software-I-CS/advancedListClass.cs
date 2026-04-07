using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WGU_C968_Software_I_CS;

public class advancedListClass : Dictionary<int, baseData>
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
        base.Add(newItem.ID, newItem);
        this.lviAddRange?.Invoke(this.ToListViewItemArray());
    }

    public new void RemoveAt(int index)
    {
        this.lviClear?.Invoke();
        base.Remove(index);
        this.lviAddRange?.Invoke(this.ToListViewItemArray());
    }

    public new void Insert(int index, baseData item)
    {
        this.lviClear?.Invoke();
        base.Add(index, item);
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
        List<baseData> valueList = this.Values.ToList().OrderBy(x => x.ID).ToList();
        ListViewItem[] toListViewItemArray = new ListViewItem[valueList.Count];
        for (int i = 0; i < valueList.Count; i++)
        {
            toListViewItemArray[i] = valueList[i].ToListViewItem();
        }

        return toListViewItemArray;
    }

    public String[] ToNameArray()
    {
        List<baseData> valueList = this.Values.ToList().OrderBy(x => x.ID).ToList();
        String[] toNameArray = new String[valueList.Count];
        for (int i = 0; i < valueList.Count; i++)
        {
            toNameArray[i] = valueList[i].Name;
        }

        return toNameArray;
    }
    
    public int[] ToIdArray()
    {
        List<baseData> valueList = this.Values.ToList().OrderBy(x => x.ID).ToList();
        int[] toIdArray = new int[valueList.Count];
        for (int i = 0; i < valueList.Count; i++)
        {
            toIdArray[i] = valueList[i].ID;
        }

        return toIdArray;
    }

    public KeyValuePair<int, baseData> Last()
    {
        List<baseData> valueList = this.Values.ToList().OrderBy(x => x.ID).ToList();
        return new KeyValuePair<int, baseData>(valueList[^1].ID, valueList[^1]);
    }
}