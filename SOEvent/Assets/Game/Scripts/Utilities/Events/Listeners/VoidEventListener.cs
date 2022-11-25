using System;
using UnityEngine.Events;

namespace Game.Scripts.Utilities.Events.Listeners
{
    [Serializable]
    public class UnityVoidEvent : UnityEvent<Void>
    {
        
    }
    
    [Serializable]
    public class VoidEventListener : BaseEventListener<Void, VoidEvent, UnityVoidEvent>
    {
        
    }
}