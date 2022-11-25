using Game.Scripts.Utilities.Events;
using UnityEngine;
using Void = Game.Scripts.Utilities.Events.Void;

namespace Game.Scripts.Play
{
    public class GameEventRaiser : MonoBehaviour
    {
        #region Variables

        public BaseEvent<Void> onStart;
        public BaseEvent<Void> onEnable;

        #endregion

        #region Mono Methods

        private void Start()
        {
            onStart.Raise(new Void());
        }

        private void OnEnable()
        {
            onEnable.Raise(new Void());
        }
        
        #endregion

        #region Private Methods
        
        #endregion
    }
}
