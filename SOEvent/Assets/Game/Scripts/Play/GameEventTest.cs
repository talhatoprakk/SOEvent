using System.Collections;
using Game.Scripts.Utilities;
using UnityEngine;

namespace Game.Scripts.Play
{
    public class GameEventTest : MonoBehaviour
    {
        #region Variables
        
        private readonly WaitForSeconds _duration = new (3f);

        #endregion
        
        
        #region Mono Methods
        
        #endregion
        
        
        #region Private Methods
        public void CalledOnStartEventRunFunction()
        {
            TLogger.Log("Success! CalledOnStartEvent!");
        }
        
        public void CallRoutine()
        {
            StartCoroutine(GameEventHelperRoutine());
        }
        private IEnumerator GameEventHelperRoutine()
        {
            yield return _duration;
            TLogger.Log("Success! CalledOnEnableEvent");
        }
        
        #endregion
    }
}