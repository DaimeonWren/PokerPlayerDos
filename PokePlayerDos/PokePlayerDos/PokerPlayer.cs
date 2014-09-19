using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePlayerDos
{
    class PokerPlayer
    {
        public List<Card> Hand { get; set; }
        public PokerPlayer()
        {
            this.Hand = new List<Card>();

        }
        public bool Pair()
        {
            return this.Hand.Select(x => x.Rank).Distinct().Count() == 4;
        }
        public bool HasFlush()
        {
            return this.Hand.Select(x => x.Suit).Distinct().Count() == 1;
        }
        public bool FourOfAKind()
        {
            return this.Hand.Select(x => x.Rank).Distinct().Count() == 2;
        }
        public bool ThreeOfAKind()
        {
            return this.Hand.Select(x => x.Rank).Distinct().Count() == 3;
        }
        public bool HasRoyalFlush()
        {
            return this.Hand.Select(x => x.Suit).Distinct().Count() == 1 && this.Hand.Select(x => x.Rank).Distinct().Contains(Rank.Ace);
        }
        public bool StraightFlush()
        {
            if ((this.Hand.Select(x => x.Rank).Distinct().OrderBy(x => x).Last() - this.Hand.Select(x => x.Rank).Distinct().OrderBy(x => x).First() == 4) && (this.Hand.Select(x => x.Suit).Distinct().Count() == 1))
            {
                return true;
            }
            else return false;
        }
        public bool Straight()
        {
            if (this.Hand.Select(x => x.Rank).Distinct().OrderBy(x => x).Last() - this.Hand.Select(x => x.Rank).Distinct().OrderBy(x => x).First() == 4)
            {
                return true;
            }
            else return false;
        }
        public bool FullHouse()
        {
            if (this.Hand.Select(x => x.Rank).Distinct().Count() == 2)
            {
                IEnumerable<IGrouping<Rank, Card>> group = this.Hand.GroupBy(x => x.Rank);
                return group.Any(x => x.Count() == 3);
            }
            else return false;
        }
        public bool Flush()
        {
            return this.Hand.Select(x => x.Suit).Distinct().Count() == 1;
        }
        public bool TwoPair()
        {
            return this.Hand.GroupBy(x => x.Rank).Where(x => x.Count() == 2).Count() == 2;
        }

        public void HasHighCard()
        {
            if (Pair() == false && TwoPair() == false && ThreeOfAKind() == false && Straight() == false && Flush() == false && FullHouse() == false
                && FourOfAKind() == false && StraightFlush() == false)
            {
                Console.WriteLine("\nHigh card is: " + this.Hand.Select(x => x.Rank).OrderBy(x => x).Last().ToString());
            }
        }
    }
}
