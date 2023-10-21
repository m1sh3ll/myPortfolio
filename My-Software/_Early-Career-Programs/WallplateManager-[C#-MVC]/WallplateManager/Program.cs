using WallplateManager.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallplateManager
{
    class Program
    {
        static void Main(string[] args)
        {
            WallplateController controller = new WallplateController();
            controller.Run();
        }
    }
}
