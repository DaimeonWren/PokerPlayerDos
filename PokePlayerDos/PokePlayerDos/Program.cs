using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokePlayerDos
{
    public enum HandRank
    {
        HighCard,
        OnePair,
        TwoPairs,
        ThreeofKind,
        Straight,
        Flush,
        FullHouse,
        FourofaKind,
        StraightFlush,
        RoyalFlush
    }
    class Program
    {
        
       
        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.PrintDeck();
            deck.Shuffle();
            Console.WriteLine("\nSHUFFLED\n");
            deck.PrintDeck();

           




            Console.ReadKey();
        }
    }
}
