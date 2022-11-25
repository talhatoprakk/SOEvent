using UnityEngine;

namespace Game.Scripts.Utilities.Events
{
    [System.Serializable]
    public struct Void
    {
        
    }
    
    [CreateAssetMenu(fileName = "New Void Event", menuName = "Game Events/Void Event")]
    public class VoidEvent : BaseEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }
}