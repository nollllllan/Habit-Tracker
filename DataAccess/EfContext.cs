using System.Data.Entity;

namespace DataAccess
{
    public class EfContext : DbContext
    {
        public EfContext(string connection) : base(connection)
        { }
    }
}