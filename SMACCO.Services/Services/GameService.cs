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
        public bool CreateGame(GameCreate model)
        {
            var entity =
                new Game()
                {
                    GameName = model.GameName,
                    IsOwned = model.IsOwned,
                    LastPatchUpdate = model.LastPatchUpdate
                };
            using (var sdx = new ApplicationDbContext())
            {
                
            }
        }
    }
}
