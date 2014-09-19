using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Battleboats.Domain;

namespace Battleboats.Infrastructure.Repositories
{
    public interface IGameService
    {
        Game New();
        Game GetBy(Guid gameId);
        void Save(Game game);
    }
}
