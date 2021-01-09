using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace navigation.Level_2
{
    public class Level2HomeMasterMenuItem
    {
        public Level2HomeMasterMenuItem()
        {
            TargetType = typeof(Level2HomeMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}