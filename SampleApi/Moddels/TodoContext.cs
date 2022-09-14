using Microsoft.EntityFrameworkCore;

namespace SampleApi.Moddels
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext>options):base(options)
        {

        }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
    }
}
