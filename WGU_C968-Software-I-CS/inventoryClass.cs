using System.ComponentModel;
using System.Net.Http.Headers;

namespace WGU_C968_Software_I_CS;

public class inventoryClass
{
    public BindingList<productClass> Products;
    public BindingList<partClass> Parts;

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
        return new productClass();
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
        return new partInHouse();
    }

    public void updatePart(int PartIndex, productClass UpdatedPart)
    {
        
    }

    #endregion
    
}