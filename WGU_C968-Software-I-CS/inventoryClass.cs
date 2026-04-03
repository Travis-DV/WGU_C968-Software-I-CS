using System.ComponentModel;
using System.Net.Http.Headers;

namespace WGU_C968_Software_I_CS;

public class inventoryClass
{
    public advancedListClass Products;
    public advancedListClass Parts;

    public inventoryClass(mainForm.LVIAddRange partsLVIAddRange, mainForm.LVIClear partsLVIClear, mainForm.LVIAddRange productsLVIAddRange, mainForm.LVIClear productsLVIClear)
    {
        Parts = new advancedListClass(partsLVIAddRange, partsLVIClear);
        Products = new advancedListClass(productsLVIAddRange, productsLVIClear);
    }
    
    #region parts

    public void addPart(partClass NewPart)
    {
        this.Parts.Add(NewPart);
    }
 
    public void updatePart(int PartIndex, partClass UpdatedPart)
    {
        this.Parts.RemoveAt(PartIndex);
        this.Parts.Insert(PartIndex, UpdatedPart);
    }
    
    public bool removePart(int PartIndex)
    {
        this.Parts.RemoveAt(PartIndex);
        return false;
    }

    public partClass lookupPart(int PartIndex)
    {
        throw new NotImplementedException();
    }
    
    #endregion

    #region  product
    public void addProduct(productClass NewProduct)
    {
        this.Products.Add(NewProduct);
    }

    public void updateProduct(int ProductIndex, productClass UpdatedProduct)
    {
        this.Products.RemoveAt(ProductIndex);
        this.Products.Insert(ProductIndex, UpdatedProduct);
    }
    
    public bool removeProduct(int ProductIndex)
    {
        throw new NotImplementedException();
    }

    public productClass lookupProduct(int ProductIndex)
    {
        throw new NotImplementedException();
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