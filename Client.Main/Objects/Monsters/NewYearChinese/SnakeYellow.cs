﻿using Client.Main.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Main.Objects.Monsters.NewYearChinese
{
    public class SnakeYellow : MonsterObject
    {
        public SnakeYellow()
        {
        }

        public override async Task Load()
        {
            Model = await BMDLoader.Instance.Prepare($"Monster/Monster254.bmd");
            await base.Load();
        }
    }
}
