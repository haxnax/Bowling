using Bowling.Data;
using Bowling.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bowling
{
    public class Application
    {

        public void Run()
        {
            var factory = new ApplicationContextFactory();
            var dbContext = factory.CreateDbContext(new string[0]);

            // Anpassad!
            // Migrate & Seed databasen!
            var dataInitiaizer = new DatainItializer();
            dataInitiaizer.MigrateAndSeed(dbContext);

            // Fanns redan
            var sel = MainMenu.ShowMenu();


        }
    }
}
