using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_10_Homework
{
    class Creature
    {
        public enum creatureType { alien, facehugger }
        public enum creatureStatus { alive, dead }


        public creatureType СreatureType;
        public creatureStatus Status;
        public int health = 200;


        public Marine Attack(Marine marine)
        {
            marine.SetStatus(Marine.marineStatus.KIA);
            return marine;
        }
    }
}
