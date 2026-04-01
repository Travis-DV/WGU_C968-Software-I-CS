using System.Reflection.PortableExecutable;

namespace WGU_C968_Software_I_CS;

public abstract class partClass
{
    public int ID { get; }
    public string Name;
    public decimal Price;
    public int InStock;
    public int Minimum;
    public int Maximum;
}

public class partInHouse : partClass
{
    public int MachineID;
}
public class partOutsourced : partClass
{
    public string CompanyName;
}