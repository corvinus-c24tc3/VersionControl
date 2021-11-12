﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08.Entities
{
   public class BallFactory
    {

        public class BallFactory : IToyFactory
        {
            public Toy CreateNew()
            {
                return new Ball();
            }
        }
    }
}
