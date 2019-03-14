namespace Sales.Backend.Models
{
    using Sales.Domain;
    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Sales.Common.Models.Products> Products { get; set; }
    }
}