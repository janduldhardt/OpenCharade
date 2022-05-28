

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCharade.Data.Models
{
    public class Card
    {
        public string Name { get; }

        public Card(string name)
        {
            Name = name;
        }
    }
}
