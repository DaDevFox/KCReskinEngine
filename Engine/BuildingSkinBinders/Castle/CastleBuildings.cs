﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ReskinEngine.Engine
{
    #region Keep

    public class KeepSkinBinder : BuildingSkinBinder
    {
        public override string UniqueName => "keep";

        public GameObject keepUpgrade1;
        public GameObject keepUpgrade2;
        public GameObject keepUpgrade3;
        public GameObject keepUpgrade4;

        public GameObject banner1;
        public GameObject banner2;

        public override SkinBinder Create(GameObject obj)
        {
            KeepSkinBinder inst = new KeepSkinBinder();

            if (obj.transform.Find("keepUpgrade1"))
                inst.keepUpgrade1 = obj.transform.Find("keepUpgrade1").gameObject;
            if (obj.transform.Find("keepUpgrade2"))
                inst.keepUpgrade2 = obj.transform.Find("keepUpgrade2").gameObject;
            if (obj.transform.Find("keepUpgrade3"))
                inst.keepUpgrade3 = obj.transform.Find("keepUpgrade3").gameObject;
            if (obj.transform.Find("keepUpgrade4"))
                inst.keepUpgrade4 = obj.transform.Find("keepUpgrade4").gameObject;

            ApplyPersonPositions(inst, obj);

            return inst;
        }

        public override void BindToBuildingBase(Building building)
        {
            Engine.dLog("keep bind begun");

            Keep keep = building.GetComponent<Keep>();
            Upgradeable upgradeable = keep.GetComponent<Upgradeable>();

            // Upgrades
            if (keepUpgrade1)
            {
                GameObject.Destroy(upgradeable.upgrades[0].model);
                upgradeable.upgrades[0] = new Upgrade()
                {
                    model = GameObject.Instantiate(keepUpgrade1, building.transform)
                };
            }
            if (keepUpgrade2)
            {
                GameObject.Destroy(upgradeable.upgrades[1].model);
                upgradeable.upgrades[1] = new Upgrade()
                {
                    model = GameObject.Instantiate(keepUpgrade2, building.transform)
                };
            }
            if (keepUpgrade3)
            {
                GameObject.Destroy(upgradeable.upgrades[2].model);
                upgradeable.upgrades[2] = new Upgrade()
                {
                    model = GameObject.Instantiate(keepUpgrade3, building.transform)
                };
            }
            if (keepUpgrade4)
            {
                GameObject.Destroy(upgradeable.upgrades[3].model);
                upgradeable.upgrades[3] = new Upgrade()
                {
                    model = GameObject.Instantiate(keepUpgrade4, building.transform)
                };
            }

            BindPersonPositions(building, this);
        }

        public override void BindToBuildingInstance(Building b)
        {
            this.BindToBuildingBase(b);
        }

    }

    #endregion

    #region Training Buildings



    public class ArcherSchoolSkinBinder : GenericBuildingSkinBinder
    {
        public override string UniqueName => "archerschool";
    }

    #endregion

    #region Misc Buildings

    public class TreasureRoomSkinBinder : GenericBuildingSkinBinder
    {
        public override string UniqueName => "throneroom";
    }
    

    public class ChamberOfWarSkinBinder : GenericBuildingSkinBinder
    {
        public override string UniqueName => "chamberofwar";
    }

    public class GreatHallSkinBinder : GenericBuildingSkinBinder
    {
        public override string UniqueName => "greathall";
    }


    #endregion




    // Great Hall





    // Barracks

    // Archer School


}
