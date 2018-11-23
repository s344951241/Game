using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public partial class GameEntry : MonoBehaviour
    {

        private IEnumerator Start()
        {
            InitBuiltinComponents();
            InitCustomComponents();
            yield return new WaitForEndOfFrame();
        }
    }
}

