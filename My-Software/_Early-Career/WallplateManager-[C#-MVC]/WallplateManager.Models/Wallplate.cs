using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallplateManager.Models

{
    public class Wallplate

    {
        public int WallplateID { get; set; }

        public string Color { get; set; }
        public int NumberPorts { get; set; }
        public bool DecoraIsTrue { get; set; }
        public string Title { get; set; }
        public string  Type { get; set; }
    }
}
