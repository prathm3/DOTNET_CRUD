namespace DaoLayer;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer;
public class CollectionContext : DbContext
{
    public DbSet<Data> data { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString = @"server=localhost;uid=root;" + "pwd=mynewpassword;database=db1";
        optionsBuilder.UseMySQL(conString);
    }

}
