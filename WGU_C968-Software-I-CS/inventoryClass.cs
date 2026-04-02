using System.ComponentModel;
using System.Net.Http.Headers;

namespace WGU_C968_Software_I_CS;

public class inventoryClass
{
    public BindingList<productClass> Products = new BindingList<productClass>();
    public BindingList<partClass> Parts = new BindingList<partClass>();

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

    public ListViewItem[] inventoryProductsLVIA()
    {
        ListViewItem[] inventoryProductsLVIA = new ListViewItem[this.Products.Count];
        for (int i = 0; i < this.Products.Count; i++)
        {
            inventoryProductsLVIA[i] = this.Products[i].ToListViewItem();
        }

        return inventoryProductsLVIA;
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

    public ListViewItem[] inventoryPartsLVIA()
    {
        ListViewItem[] inventoryPartsLVIA = new ListViewItem[this.Parts.Count];
        for (int i = 0; i < this.Parts.Count; i++)
        {
            inventoryPartsLVIA[i] = this.Parts[i].ToListViewItem();
        }

        return inventoryPartsLVIA;
    }
    #endregion
    
}