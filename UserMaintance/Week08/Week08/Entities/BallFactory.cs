using System;
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
            public Color BallColor { get; set; }

            public Toy CreateNew()
            {
                return new Ball(BallColor);
            }
        }
    }
}
