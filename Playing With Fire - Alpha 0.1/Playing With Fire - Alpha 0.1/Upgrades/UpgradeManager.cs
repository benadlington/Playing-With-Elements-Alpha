using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace Playing_With_Fire___Alpha_0._1.Upgrades
{
    class UpgradeManager
    {


        public static List<Upgrade> upgradeList = new List<Upgrade>();


        public static Upgrade GetRandomUpgrade()
        {
            Random random = new Random();
            return upgradeList[random.Next(0, upgradeList.Count)];
        }
    }
}
