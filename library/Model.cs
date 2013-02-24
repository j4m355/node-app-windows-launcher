using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Model
    {
        public string AppName { get; set; }
        public SubModel SubModel { get; set; }
    }

    public class SubModel
    {
        public string Path { get; set; } 
        public string Command { get; set; } 
    }
}
