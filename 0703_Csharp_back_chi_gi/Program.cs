﻿using System;

namespace QSS200703
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Player plr = new Player(200,100,15,0,"플레이어",0,0);
            Enemy enem = new Enemy(50,25,"해골",5,5);
            plr.Move(4,3);
            enem.Move(0, -2);
            while (enem.hp > 0 && plr.hp > 0)
            {
                plr.Attack(enem);
                enem.Attack(plr);
                plr.Heal(10);
            }
        }
    }
}