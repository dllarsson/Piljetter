using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piljetter
{
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxVisitors { get; set; }
        public int City_Id { get; set; }
    }
}
