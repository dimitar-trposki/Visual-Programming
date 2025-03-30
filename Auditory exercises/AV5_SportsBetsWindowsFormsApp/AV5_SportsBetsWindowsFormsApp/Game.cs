using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV5_SportsBetsWindowsFormsApp
{
    public class Game
    {
        public SoccerTeam Home {  get; set; }
        public SoccerTeam Away {  get; set; }
        public decimal Coef1 { get; set; }
        public decimal CoefX { get; set; }
        public decimal Coef2 { get; set; }
        public string Code { get; set; }

        public Game(SoccerTeam home, SoccerTeam away, decimal coef1, decimal coefX, decimal coef2, string code)
        {
            Home = home;
            Away = away;
            Coef1 = coef1;
            CoefX = coefX;
            Coef2 = coef2;
            Code = code;
        }

        public override string ToString()
        {
            return $"({Code}) {Home} - {Away}";
        }
    }
}
