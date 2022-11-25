using UnityEngine;
using UnityEngine.Events;

namespace Game.Scripts.Utilities.Events.Listeners
{
    [System.Serializable]
    public abstract class BaseEventListener<T, TE, TUER> : MonoBehaviour, IGameEventListener<T>
        where TE : BaseEvent<T> where TUER : UnityEvent<T>
    {
       [SerializeField] private TE gameEvent;

        private TE GameEvent
        {
            get => gameEvent;
            set => gameEvent = value;
        }

       [SerializeField] private TUER unityEventResponse;

        private void OnEnable()
        {
            if (gameEvent == null)
            {
                return;
            }

            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (gameEvent == null)
            {
                return;
            }

            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T item)
        {
            unityEventResponse?.Invoke(item);
        }
    }
}
