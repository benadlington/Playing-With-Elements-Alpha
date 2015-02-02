using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;
using System.Threading;
using Playing_With_Fire___Alpha_0._1.Textures;

namespace Playing_With_Fire___Alpha_0._1.Game_Objects
{
    class Dynamite
    {
        
        public Texture2D Texture { get; set; }
        public Cell Location { get; set; }
        public int Fuse { get; set; }
        public Boolean Ignited { get; set; }

        //private
        private Thread timerThread;
        public Dynamite()
        {

        }
        public Dynamite(Cell _location)
        {
            Ignited = true;
            Location = _location;
            Location.Contains = "Dynamite";
            Texture = Materials.dynamite;
            Fuse = 3;
            timerThread = new Thread(new ThreadStart(timerTick));
            timerThread.Start();
        }
        //public void startTimer()
        //{
        //    timerThread = new Thread(new ThreadStart(timerTick));
        //    timerThread.Start();
        //}
        //public void abortTimer()
        //{
        //    timerThread.Abort();
        //}
        private void timerTick()
        {
            while(Ignited)
            {
                if (Fuse == 0)
                {
                    Ignited = false;
                    Debug.WriteLine("Boom!");
                    Thread.CurrentThread.Abort();
                }
                Debug.WriteLine(Fuse);
                Fuse--;
                Thread.Sleep(1000);
            }

        }
    }
}
