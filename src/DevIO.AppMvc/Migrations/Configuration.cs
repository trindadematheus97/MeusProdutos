using System.Data.Entity.Migrations;
using DevIO.Infra.Data.Context;

namespace DevIO.AppMvc.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

       
    }
}
