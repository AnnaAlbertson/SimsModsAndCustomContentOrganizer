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

        public IEnumerable<DownloadListItem> GetDownloads()
        {
            using (var sdx = new ApplicationDbContext())
            {
                var query =
                    sdx
                    .Downloads
                    .Select(
                        e =>
                        new DownloadListItem
                        {
                            DownloadID = e.DownloadID,
                            DownloadName = e.DownloadName,
                            CreatorName = e.CreatorName,
                            LastDownloaded = e.LastDownloaded,
                            IsMod = e.IsMod,
                            IsCustomContent = e.IsCustomContent,
                            GameName = e.Games.GameName
                        }
                        );
                return query.ToArray();
            }
        }

        public DownloadDetails GetDownloadByID(int id)
        {
            using (var sdx = new ApplicationDbContext())
            {
                var entity =
                    sdx
                    .Downloads
                    .Single(e => e.DownloadID == id);  //&& OwnerID == _userID)
                return
                    new DownloadDetails
                    {
                        DownloadID = entity.DownloadID,
                        DownloadName = entity.DownloadName,
                        CreatorName = entity.CreatorName,
                        DownloadURL = entity.DownloadURL,
                        IsMod = entity.IsMod,
                        IsCustomContent = entity.IsCustomContent,
                        LastDownloaded = entity.LastDownloaded,
                        GameName = entity.Games.GameName
                    };
            }
        }

        public bool UpdateDownload(DownloadEdit model)
        {
            using (var sdx = new ApplicationDbContext())
            {
                var entity =
                    sdx
                    .Downloads
                    .Single(e => e.DownloadID == model.DownloadID); //&&OwnerID == _userID

                //entity.GameName = model.GameName;
                entity.DownloadName = model.DownloadName;
                entity.CreatorName = model.CreatorName;
                entity.DownloadURL = model.DownloadURL;
                entity.IsMod = model.IsMod;
                entity.IsCustomContent = model.IsCustomContent;
                entity.LastDownloaded = model.LastDownloaded;
                entity.GameID = model.GameID;

                return sdx.SaveChanges() == 1;
            }
        }

        public bool DeleteDownload(int downloadID)
        {
            using (var sdx = new ApplicationDbContext())
            {
                var entity =
                    sdx
                    .Downloads
                    .Single(e => e.DownloadID == downloadID); //OwnerID == _userID

                sdx.Downloads.Remove(entity);

                return sdx.SaveChanges() == 1;
            }
        }
    }
}
