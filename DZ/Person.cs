using System;
using static DZ.Program;

namespace DZ
{
    enum Post
    {
        игрок,
        организатор
    }
    internal class Person
    {
        readonly string personName;
        readonly Post post;


        // Добавление команды в шоу
        public void AddingTeamToShow(BigRace tournament, params Team[] teams)
        {
            if (post == Post.организатор)
            {
                foreach (Team team in teams)
                {
                    tournament.AddTeamToTeamsList(team);
                }
            }
        }

        // Добавление игры в шоу 
        public void AddingGameToToShow(BigRace tournament, params IGame[] games)
        {
            if (post == Post.организатор)
            {
                foreach (IGame game in games)
                {
                    tournament.AddGameToShow(game);
                }
            }
        }

        public Person(string personName, Post positionOfPerson)
        {
            this.personName = personName;
            this.post = positionOfPerson;
        }
    }
}
