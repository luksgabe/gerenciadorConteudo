
using System.Data.Entity;

namespace Project.Data.Context.Config
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<ProjectContext>
    {

        protected override void Seed(ProjectContext context)
        {

        }
    }
}
