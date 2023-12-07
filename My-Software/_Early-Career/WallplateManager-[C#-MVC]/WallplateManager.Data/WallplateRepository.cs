using WallplateManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallplateManager.Data
{
    public class WallplateRepository
    {
        Wallplate[] _wallplates;
        public WallplateRepository()
        {
            //initialize array
            _wallplates = new Wallplate[10];

            //create wallplate
            Wallplate wallplate1 = new Wallplate();
            wallplate1.WallplateID = 0;
            wallplate1.Title = "1 Port Cat6 Wallplate White";
            wallplate1.NumberPorts = 1;
            wallplate1.DecoraIsTrue = false;
            wallplate1.Color = "White";
            wallplate1.Type = "solid";

            //add wallplate 1 to our list
            _wallplates[0] = wallplate1;

            //create wallplate
            Wallplate wallplate2 = new Wallplate();
            wallplate2.WallplateID = 1;
            wallplate2.Title = "2 Port HDMI Wallplate Black";
            wallplate2.NumberPorts = 2;
            wallplate2.DecoraIsTrue = false;
            wallplate2.Color = "Black";
            wallplate2.Type = "solid";

            //add wallplate 2 to our list
            _wallplates[1] = wallplate2;
        }

        public Wallplate CreateWallplate(Wallplate wallplate)
        {
            // find the first open spot in the wallplates list
            for (int i = 0; i < _wallplates.Length; i++)
            {
                if (_wallplates[i] == null)
                {
                    wallplate.WallplateID = i;      // set the id for wallplate                    
                    _wallplates[i] = wallplate;     // add the wallplate to list
                    return wallplate;
                }
            }
            return null;                            // if array full don't add the wallplate
        }

        public Wallplate[] RetrieveAllWallplates()
        {
            return _wallplates;
        }

        public Wallplate RetrieveWallplateById(int wallplateID)
        {
            return _wallplates[wallplateID];
        }

        public void DeleteWallplate(int wallplateID)
        {
            _wallplates[wallplateID] = null;
        }

        public Wallplate EditWallplate(Wallplate wallplate)
        {
            DeleteWallplate(wallplate.WallplateID);
            Wallplate updatedWallplate = CreateWallplate(wallplate);
            return updatedWallplate;
        }

    }
}
