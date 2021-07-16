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

        public PackDetails GetPackByID(int id)
        {
            using (var sdx = new ApplicationDbContext())
            {
                var entity =
                    sdx
                    .Packs
                    .Single(e => e.PackID == id);  //&& OwnerID == _userID)
                return
                    new PackDetails
                    {
                        PackID = entity.PackID,
                        PackName = entity.PackName,
                        Description = entity.Description,
                        IsOwned = entity.IsOwned,
                        GameName = entity.Games.GameName
                    };
            }
        }

        public bool UpdatePack(PackEdit model)
        {
            using (var sdx = new ApplicationDbContext())
            {
                var entity =
                    sdx
                    .Packs
                    .Single(e => e.PackID == model.PackID); //&&OwnerID == _userID

                entity.PackName = model.PackName;

                return sdx.SaveChanges() == 1;
            }
        }

        //public bool DeletePack(int packID)
        //{
        //    using (var sdx = new ApplicationDbContext())
        //    {
        //        var entity =
        //            sdx
        //            .Packs
        //            .Single(e => e.PackID == packID); //OwnerID == _userID

        //        sdx.Packs.Remove(entity);

        //        return sdx.SaveChanges() == 1;
        //    }
        //}
    }
}
