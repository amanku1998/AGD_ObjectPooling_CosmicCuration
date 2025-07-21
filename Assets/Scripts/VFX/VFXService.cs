using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.VFX
{
    public class VFXService
    {
        //private List<VFXData> vfxData = new List<VFXData>();

        private VFXPool VFXPool;
        //public VFXService(VFXScriptableObject vfxScriptableObject)
        //{
        //    vfxData = vfxScriptableObject.vfxData;

        //}

        public VFXService(VFXView vfxPrefab)
        {
            VFXPool = new VFXPool(vfxPrefab);
        }

        public void PlayVFXAtPosition(VFXType type, Vector2 spawnPosition)
        {
            //VFXView prefabToSpawn = vfxData.Find(item => item.type == type).prefab;
            //VFXController vfxToPlay = new VFXController(prefabToSpawn);
            VFXController vfxToPlay = VFXPool.GetVFX();
            vfxToPlay.Configure(type, spawnPosition);
        }

        public void ReturnVFXToPool(VFXController vfxController)
        {
            VFXPool.ReturnItem(vfxController);
        }
    }
}