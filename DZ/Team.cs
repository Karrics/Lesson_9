using System;
using System.Collections.Generic;


namespace DZ
{
    internal class Team
    {
        readonly string teamCountry;
        readonly List<Person> teamMembers = new List<Person>();


        public Team(string teamCountry, params Person[] teamMembers)
        {
            this.teamCountry = teamCountry;

            foreach (Person player in teamMembers)
            {
                this.teamMembers.Add(player);
            }
        }
    }
}
