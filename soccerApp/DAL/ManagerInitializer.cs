using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using soccerApp.Models;

namespace soccerApp.DAL
{
    public class ManagerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ManagerContext>
    {
        protected override void Seed(ManagerContext context)
        {
            /*var teams = new List<Team>
            {
                new Team{TeamName="Seattle Strikers"},
                new Team{TeamName="Brooklyn Bashers"},
                new Team{TeamName="Raleigh Ruffians"}
            };
            teams.ForEach(s => context.Teams.Add(s));
            context.SaveChanges();

            var players = new List<Player>
            {
                new Player{FirstName="Peter",LastName="Parker",TeamID=1},
                new Player{FirstName="Bruce",LastName="Banner",TeamID=1},
                new Player{FirstName="Tony",LastName="Stark",TeamID=1},
                new Player{FirstName="Wanda",LastName="Maximoff",TeamID=1},
                new Player{FirstName="Thor",LastName="Odinson",TeamID=2},
                new Player{FirstName="Steve",LastName="Rogers",TeamID=2},
                new Player{FirstName="Natasha",LastName="Romanova",TeamID=2},
                new Player{FirstName="Matt",LastName="Murdock",TeamID=2},
                new Player{FirstName="Peter",LastName="Quill",TeamID=3},
                new Player{FirstName="Jean",LastName="Grey",TeamID=3},
                new Player{FirstName="Wade",LastName="Wilson",TeamID=3},
                new Player{FirstName="Rocket",LastName="Raccoon",TeamID=3}
            };

            players.ForEach(s => context.Players.Add(s));
            context.SaveChanges();*/
        }
    }
}