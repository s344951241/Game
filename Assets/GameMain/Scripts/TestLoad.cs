using GameFramework.ObjectPool;
using GameFramework.Resource;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game{
    public class TestLoad
    {

        private IObjectPool<EntityBase> m_EntityPool = null;
        EntityBase curEntity;

        private LoadAssetCallbacks m_LoadCallbacks = null;
        public TestLoad()
        {
            m_EntityPool = GameEntry.ObjectPool.CreateSingleSpawnObjectPool<EntityBase>("Entity", 10);

            m_LoadCallbacks = new LoadAssetCallbacks(LoadSuccessCallback, LoadFailureCallback);
           
        }

        public void CreateEntity()
        {
            string cubeName = "Assets/GameMain/Entities/Cube.prefab";
            curEntity = m_EntityPool.Spawn(cubeName);
            if (curEntity == null)
            {
                GameEntry.Resource.LoadAsset(cubeName, m_LoadCallbacks);
            }
            else
            {
                GameObject.Instantiate(curEntity.Target as GameObject, null, false);
            }
        }
        private void LoadSuccessCallback(string name, object asset, float duration, object userData)
        {
            if (asset == null)
            {
                Debug.LogError(name + " loaded failed");
            }

            curEntity = m_EntityPool.Spawn(name);
            if (curEntity == null)
            {
                curEntity = new EntityBase(name,asset);
                m_EntityPool.Register(curEntity, true);
            }
            else
            {
                GameEntry.Resource.UnloadAsset(asset);
            }
            GameObject.Instantiate(curEntity.Target as GameObject, null, false);
            m_EntityPool.Unspawn(curEntity);
            
        }

        private void LoadFailureCallback(string name, LoadResourceStatus status, string errorMessage, object userData)
        {
            Debug.LogError(name + " loaded failed");
        }
    }
}

