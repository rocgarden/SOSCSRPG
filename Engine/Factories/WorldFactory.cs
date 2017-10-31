using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
   internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home", "This is your Home.", "/Engine;component/Images/Home.png");           

            newWorld.AddLocation(-2, -1, "Farmer's Field", "There are rows of corn growing here, with giant rats hiding between them",
                "/Engine;component/Images/FarmFields.png");

            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

            newWorld.AddLocation(-1, -1, "Farmer's House", "This is the house of your neighbor, Farmer Ted.",
                "/Engine;component/Images/Farmhouse.png");

            newWorld.AddLocation(-1, 0, "Trading Shop", "The shop of Susan, the trader.", "/Engine;component/Images/Trader.png");

            newWorld.AddLocation(0, 0, "Town Square", "You see a fountain here.", "/Engine;component/Images/TownSquare.png");

            newWorld.AddLocation(1, 0, "Town Gate", "There is a gate, protecting the town from giant spiders.", "/Engine;component/Images/TownGate.png");

            newWorld.AddLocation(2, 0, "Spider Forest", "The trees are covered with spider webs", "/Engine;component/Images/SpiderForest.png");

            newWorld.LocationAt(2, 0).AddMonster(3, 100);

            newWorld.AddLocation(0, 1, "Herbalist's hut", "You see a small hut, with plants drying from the roof.", "/Engine;component/Images/HerbalistsHut.png");
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQestByID(1));

            newWorld.AddLocation(0, 2, "Herbalist's garden", "There are many plants here, with snakes hiding in them.", "/Engine;component/Images/HerbalistsGarden.png"); 

            newWorld.LocationAt(0, 2).AddMonster(1, 100);


            return newWorld;

        }


    }
}
