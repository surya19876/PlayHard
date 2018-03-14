﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayHard.Views.Games
{

    public class MasterHomeMenuItem
    {
        public MasterHomeMenuItem()
        {
            TargetType = typeof(MasterHomeDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}