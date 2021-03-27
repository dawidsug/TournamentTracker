﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> persons = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if (persons.Count > 0)
            {
                currentId = persons.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            persons.Add(model);

            persons.SaveToPersonFile();
            
        }

        public void CreatePrize(PrizeModel model)
        {
            
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            prizes.Add(model);
            
            prizes.SaveToPrizeFile();
            
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();
            
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);

        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> persons = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPersonModels();
            return persons;
        }

        public List<TeamModel> GetTeams_All()
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            return teams;
        }
        
        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
           
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}