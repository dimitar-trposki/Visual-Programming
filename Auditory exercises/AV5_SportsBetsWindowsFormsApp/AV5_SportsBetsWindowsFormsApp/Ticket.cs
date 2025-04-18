﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV5_SportsBetsWindowsFormsApp
{
    public class Ticket
    {
        public Game Game { get; set; }
        public int Tip { get; set; }

        public Ticket(Game game, int tip)
        {
            Game = game;
            Tip = tip;
        }

        public override string ToString()
        {
            return string.Format("{0} vs {1}: {2}", Game.Home.Name, Game.Away.Name, Tip == 0 ? "1" : Tip == 1 ? "X" : "2");
        }
    }
}
