namespace Game.Scripts.Utilities.Events.Listeners
{
    public interface IGameEventListener<in T>
    {
        void OnEventRaised(T item);
    }
}
