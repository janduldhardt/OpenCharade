

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCharade.Data.Models;

namespace OpenCharade.Services
{
    public class DeckService : IDeckService
    {
        public async Task<List<Deck>> GetDecksAsync()
        {
            var list = new List<Deck>();
            var deck1 = new Deck() { Name = "Deck 1" };
            deck1.AddCard(new Card("Horse"));
            deck1.AddCard(new Card("Cow"));
            deck1.AddCard(new Card("Pig"));
            deck1.AddCard(new Card("Human"));
            deck1.AddCard(new Card("Wulf"));
            deck1.AddCard(new Card("Chicken"));
            deck1.AddCard(new Card("Goat"));
            deck1.AddCard(new Card("Camel"));
            list.Add(deck1);

            return list;
        }
    }
}
