using SMACCO.Data;
using SMACCO.Data.Entities;
using SMACCO.Models.GameModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Services.Services
{
    public class GameService
    {
        // private readonly Guid _userID;

        //public NoteService(Guid userID)
        //{
        //  _userID = userID
        //}

        public bool CreateGame(GameCreate model)
        {
            var entity =
                new Game()
                {
                    //OwnerID or AdminID
                    GameName = model.GameName,
                    IsOwned = model.IsOwned,
                    LastPatchUpdate = model.LastPatchUpdate
                };
            using (var sdx = new ApplicationDbContext())
            {
                sdx.Games.Add(entity);
                return sdx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameListItem> GetGames()
        {
            using (var sdx = new ApplicationDbContext())
            {
                var query =
                    sdx
                    .Games
                    .Select(
                        e =>
                        new GameListItem
                        {
                            GameID = e.GameID,
                            GameName = e.GameName,
                            IsOwned = e.IsOwned,
                            LastPatchUpdate = e.LastPatchUpdate
                            //NumberOfDownloads = 
                        }
                        );
                return query.ToArray();
            }
        }

        public GameDetails GetGameByID(int id)
        {

        }

        public bool UpdateGame(GameEdit model)
        {

        }

        public bool DeleteGame(int gameID)
        {

        }
    }
}
