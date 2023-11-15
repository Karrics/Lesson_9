using System;
using System.Collections.Generic;
using static DZ.Program;

namespace DZ
{
    internal class BigRace
    {
        readonly List<IGame> gamesList = new List<IGame>();
        readonly List<Team> teamsList = new List<Team>();
        private static BigRace show = null;



        // Добавление игры в шоу
        public void AddGameToShow(IGame game)
        {
            gamesList.Add(game);
        }

        // Добавление команды в шоу
        public void AddTeamToTeamsList(Team team)
        {
            teamsList.Add(team);
        }


        public void StartShow(IGame game)
        {
            game.StartTheGame();
        }



        public static BigRace getInstance()
        {
            if (show == null)
            {
                show = new BigRace();
            }

            return show;
        }
    }
}
