
namespace Blokitect.Data.Models.Enums
{
    public enum Priority
    {
        Low,
        High
    }
    public enum ReturnValue
    {
        Int,
        String,
        DateTime,
        TimeStamp,
        Decimal,
        Bytes,
    }
    public enum SupplierType
    {
        Accountancy,
        Engineering,
        IT,
        Software,
    }
    public enum UserRole
    {
        Admin,
        Customer,
        Supplier,
    }

    public enum TokenProvider
    {
        Admin,
        Customer,
        Supplier,
        Temporary,
    }
}
