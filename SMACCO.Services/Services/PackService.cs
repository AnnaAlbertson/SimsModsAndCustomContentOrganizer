using SMACCO.Data;
using SMACCO.Data.Entities;
using SMACCO.Models.PackModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Services.Services
{
    public class PackService
    {
        // private readonly Guid _userID;

        //public NoteService(Guid userID)
        //{
        //  _userID = userID
        //}

        public bool CreatePack(PackCreate model)
        {
            var entity =
                new Pack()
                {
                    //OwnerID or AdminID
                    PackName = model.PackName,
                    Description = model.PackName,
                    IsOwned = model.IsOwned,
                    GameID = model.GameID
                };
            using (var sdx = new ApplicationDbContext())
            {
                sdx.Packs.Add(entity);
                return sdx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PackListItem> GetPacks()
        {
            using (var sdx = new ApplicationDbContext())
            {
                var query =
                    sdx
                    .Packs
                    .Select(
                        e =>
                        new PackListItem
                        {
                            PackName = e.PackName,
                            Description = e.Description,
                            IsOwned = e.IsOwned,
                            GameName = e.Games.GameName
                        }
                        );
                return query.ToArray();
            }
        }

        //public GameDetails GetGameByID(int id)
        //{
        //    using (var sdx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            sdx
        //            .Games
        //            .Single(e => e.GameID == id);  //&& OwnerID == _userID)
        //        return
        //            new GameDetails
        //            {
        //                GameID = entity.GameID,
        //                GameName = entity.GameName,
        //                IsOwned = entity.IsOwned,
        //                LastPatchUpdate = entity.LastPatchUpdate
        //            };
        //    }
        //}

        //public bool UpdateGame(GameEdit model)
        //{
        //    using (var sdx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            sdx
        //            .Games
        //            .Single(e => e.GameID == model.GameID); //&&OwnerID == _userID

        //        entity.GameName = model.GameName;
        //        entity.IsOwned = model.IsOwned;
        //        entity.LastPatchUpdate = model.LastPatchUpdate;

        //        return sdx.SaveChanges() == 1;
        //    }
        //}

        //public bool DeleteGame(int gameID)
        //{
        //    using (var sdx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            sdx
        //            .Games
        //            .Single(e => e.GameID == gameID); //OwnerID == _userID

        //        sdx.Games.Remove(entity);

        //        return sdx.SaveChanges() == 1;
        //    }
        //}
    }
}
