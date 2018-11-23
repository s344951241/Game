using GameFramework.ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class EntityBase : ObjectBase
    {
        public EntityBase(string name,object target) : base(name,target)
        {
            
        }

        protected internal override void Release(bool isShutdown)
        {
            GameEntry.Resource.UnloadAsset(Target);
        }
    }
}

