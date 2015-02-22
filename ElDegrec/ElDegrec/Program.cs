using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp.Common;
using LeagueSharp;
using System.Media;

namespace ElDegrec
{
    class Program
    {
        private static Menu _menu;

        static void Main(string[] args)
        {
            LeagueSharp.Common.CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            Notifications.AddNotification("Hola mi nombre es Degrec and I use cracked scripts.", 5);
            new SoundObject(Properties.Resources.Degrec).Play();

            InitializeMenu();
            Game.OnGameUpdate += Game_OnGameUpdate;
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (_menu.Item("crkekt").IsActive())
            {
                new SoundObject(Properties.Resources.Degrec).Play();
            }
        }

        private class SoundObject
        {
            private static SoundPlayer deREKT;

            public SoundObject(Stream sound)
            {
                deREKT = new SoundPlayer(sound);
            }

            public void Play()
            {
                deREKT.Play();
            }
        }

        private static void InitializeMenu()
        {
            _menu = new Menu("ElDecrec", "ElDecrec", true);
            var DecrecMenu = _menu.AddSubMenu(new Menu("krektscripts", "krektscripts"));
            DecrecMenu.AddItem(new MenuItem("crkekt", "krekt scripts").SetValue(new KeyBind("L".ToCharArray()[0], KeyBindType.Press)));

            _menu.AddToMainMenu();
        }
    }
}
