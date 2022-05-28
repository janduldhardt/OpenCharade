

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCharade.Data.Models;

namespace OpenCharade.Services
{
    public interface IDeckService
    {
        public Task<List<Deck>> GetDecksAsync();
    }
}
