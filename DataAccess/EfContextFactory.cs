using System.Data.Entity.Infrastructure;

namespace DataAccess
{
    public class EfContextFactory : IDbContextFactory<EfContext>
    {
        public EfContext Create()
        {
            return new EfContext("Addr=.;Database=HabitTracker;Trusted_Connection=True;");
        }
    }
}