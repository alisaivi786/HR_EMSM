using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.EMS.Presistence.Configuration
{
    public class SeedStoreProc
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HrDatabaseContext(
                serviceProvider.GetRequiredService<DbContextOptions<HrDatabaseContext>>()))
            {
                // Apply migrations if they haven't been applied yet
                context.Database.Migrate();

                // Execute the stored procedure
               // context.Database.ExecuteSqlRaw("EXEC [dbo].[CalculateLeaveSummaryByEmployee] @EmployeeId = 1");
            }
        }
    }
}
