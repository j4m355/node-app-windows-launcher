using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Model2
    {
        public ObservableCollection<Model> Applications { get; set; }  
    }

    public class Model
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Command { get; set; }
        public string Parameters { get; set; }
    }
}
