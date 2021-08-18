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
        private readonly Guid _userID;

        public GameService(Guid userID)
        {
            _userID = userID;
        }

        public bool CreateGame(GameCreate model)
        {
            var entity =
                new Game()
                {
                    OwnerID = _userID,
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
                    .Where(e => e.OwnerID == _userID)
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
            using (var sdx = new ApplicationDbContext())
            {
                var entity =
                    sdx
                    .Games
                    .Single(e => e.GameID == id && e.OwnerID == _userID);
                return
                    new GameDetails
                    {
                        GameID = entity.GameID,
                        GameName = entity.GameName,
                        IsOwned = entity.IsOwned,
                        LastPatchUpdate = entity.LastPatchUpdate
                    };
            }
        }

        public bool UpdateGame(GameEdit model)
        {
            using (var sdx = new ApplicationDbContext())
            {
                var entity =
                    sdx
                    .Games
                    .Single(e => e.GameID == model.GameID && e.OwnerID == _userID);
                
                entity.GameName = model.GameName;
                entity.IsOwned = model.IsOwned;
                entity.LastPatchUpdate = model.LastPatchUpdate;

                return sdx.SaveChanges() == 1;
            }
        }

        public bool DeleteGame(int gameID)
        {
            using (var sdx = new ApplicationDbContext())
            {
                var entity =
                    sdx
                    .Games
                    .Single(e => e.GameID == gameID && e.OwnerID == _userID);

                sdx.Games.Remove(entity);

                return sdx.SaveChanges() == 1;
            }
        }
    }
}
