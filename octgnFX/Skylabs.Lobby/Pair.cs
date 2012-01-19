﻿//Copyright 2012 Skylabs
//In order to use this software, in any manor, you must first contact Skylabs.
//Website: http://www.skylabsonline.com
//Email:   skylabsonline@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Skylabs.Lobby
{
    public class Pair<T1,T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public Pair(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
