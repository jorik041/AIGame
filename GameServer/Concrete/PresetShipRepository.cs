﻿using GameServer.DataEntities;
using GameServer.GameLogic.JSClasses;
using Jurassic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameServer.Concrete
{
    public class PresetShipRepository
    {
        /// <summary>
        /// Gets Ship preset from it's index
        /// </summary>
        /// <param name="presetId"></param>
        /// <returns></returns>
        public ShipPreset GetShip(int presetId)
        {
            ShipPreset preset = new ShipPreset();

            preset.ImageFilename = "/content/img/shipBackground" + presetId + ".png";
            preset.LayoutFilename = "/content/img/shipLayout" + presetId + ".png";

            switch (presetId)
            {
                case 1:
                    preset.LayoutOffset = new double[] { 28, 29 };

                    preset.weapons = new Weapon[] { 
                        new Weapon() { position = new double[] { 19, 49 }, weaponType = 0, reversed = true },
                        new Weapon() { position = new double[] { 284, 49 }, weaponType = 0 }
                    };

                    preset.RoomIds = new int[,]{
                        {1,1,0,0,0,5,5},
                        {0,2,2,3,4,4,0},
                        {0,0,0,3,0,0,0}
                    };

                    preset.DefaultLayout = new int[] { 0, 2, 4, 3, 1, 2 };
                    break;
                case 2:
                    preset.LayoutOffset = new double[] { 51, 66 };

                    preset.weapons = new Weapon[] { 
                        new Weapon() { position = new double[] { 52, 53 }, weaponType = 0, reversed = true },
                    };

                    preset.RoomIds = new int[,]{
                        {1,2},
                        {3,3}
                    };

                    preset.DefaultLayout = new int[] { 0, 2, 1, 3};
                    break;
            }

            /*preset.afterShipBuilt = (ship =>
                ((CellWeapon)ship.cells[0][5]).weaponId =
                ((CellWeapon)ship.cells[0][6]).weaponId = 1);*/

            return preset;
        }
    }
}