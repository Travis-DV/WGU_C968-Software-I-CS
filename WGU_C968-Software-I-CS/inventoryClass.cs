using System.ComponentModel;
using System.Net.Http.Headers;

namespace WGU_C968_Software_I_CS;

public class inventoryClass
{
    public advancedListClass Products = new advancedListClass();
    public advancedListClass Parts = new advancedListClass();

    #region  product
    public void addProduct(productClass NewProduct)
    {
        
    }

    public bool removeProduct(int ProductIndex)
    {
        return false;
    }

    public productClass lookupProduct(int ProductIndex)
    {
        throw new NotImplementedException();
    }

    public void updateProduct(int ProductIndex, productClass UpdatedProduct)
    {
        
    }
    #endregion

    #region parts

    public void addPart(productClass NewPart)
    {
        
    }
 
    public bool removePart(int PartIndex)
    {
        return false;
    }

    public partClass lookupPart(int PartIndex)
    {
        throw new NotImplementedException();
    }

    public void updatePart(int PartIndex, productClass UpdatedPart)
    {
        
    }
    #endregion

    public List<int> search(advancedListClass inputList, string searchString)
    {
        string[] nameArray = inputList.ToNameArray();
        List<int> outputIndex = new List<int>();
        for (int i = 0; i < nameArray.Length; i++)
        {
            if (nameArray[i].Contains(searchString, StringComparison.OrdinalIgnoreCase))
            {
                outputIndex.Add(i);
            }
        }
        return outputIndex;
    }
    
    public List<int> search(advancedListClass inputList, int searchInt)
    {
        int[] idArray = inputList.ToIdArray();
        List<int> outputIndex = new List<int>();
        for (int i = 0; i < idArray.Length; i++)
        {
            if (idArray[i] == searchInt)
            {
                outputIndex.Add(i);
            }
        }
        return outputIndex;
    }
    
}