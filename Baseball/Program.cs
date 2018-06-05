using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            var woodenBat = new WoodenBat();
            var aluminumBat = new AluminumBat();
            //var hank = new BaseballPlayer();
            var compositeBat = new CompositeBat();
            var jack = new CricketPlayer();

            //hank.TakeTurn(woodenBat);
            //hank.TakeTurn(aluminumBat);
            //hank.TakeTurn(compositeBat);
            jack.TakeTurn(woodenBat);
            jack.TakeTurn(aluminumBat);
            jack.TakeTurn(compositeBat);
        }
    }
}
