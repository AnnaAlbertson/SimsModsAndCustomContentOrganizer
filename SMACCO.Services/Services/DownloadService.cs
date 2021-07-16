using SMACCO.Data;
using SMACCO.Data.Entities;
using SMACCO.Models.DownloadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMACCO.Services.Services
{
    public class DownloadService
    {
        // private readonly Guid _userID;

        //public NoteService(Guid userID)
        //{
        //  _userID = userID
        //}

        public bool CreateDownload(DownloadCreate model)
        {
            var entity =
                new Download()
                {
                    //OwnerID or AdminID
                    DownloadName = model.DownloadName,
                    CreatorName = model.CreatorName,
                    DownloadURL = model.DownloadURL,
                    GameID = model.GameID,
                    IsCustomContent = model.IsCustomContent,
                    IsMod = model.IsMod,
                    LastDownloaded = model.LastDownloaded
                };
            using (var sdx = new ApplicationDbContext())
            {
                sdx.Downloads.Add(entity);
                return sdx.SaveChanges() == 1;
            }
        }

        //public IEnumerable<GameListItem> GetGames()
        //{
        //    using (var sdx = new ApplicationDbContext())
        //    {
        //        var query =
        //            sdx
        //            .Games
        //            .Select(
        //                e =>
        //                new GameListItem
        //                {
        //                    GameID = e.GameID,
        //                    GameName = e.GameName,
        //                    IsOwned = e.IsOwned,
        //                    LastPatchUpdate = e.LastPatchUpdate
        //                    //NumberOfDownloads = 
        //                }
        //                );
        //        return query.ToArray();
        //    }
        //}

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
