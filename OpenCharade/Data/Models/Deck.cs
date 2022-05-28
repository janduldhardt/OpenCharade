

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCharade.Data.Models
{
    public class Deck
    {
        public string Name { get; set; }
        public IList<Card> Cards { get;  } = new List<Card>();

        public bool AddCard(Card card)
        {
            Cards.Add(card);
            return true;
        }
    }
}
