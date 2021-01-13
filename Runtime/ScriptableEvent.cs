using UnityEngine;
using UnityEngine.Events;

namespace loophouse.ScriptableEvents
{
    [CreateAssetMenu(menuName = "Scriptable Events/Scriptable Event", fileName = "ScriptableEvent")]
    public class ScriptableEvent : ScriptableObject
    {
        [SerializeField] private UnityEvent _event;

        public void Subscribe(UnityAction action)
        {
            _event.AddListener(action);
        }

        public void Unsubscribe(UnityAction action)
        {
            _event.RemoveListener(action);
        }

        public void Invoke()
        {
            _event.Invoke();
        }
    }

    public abstract class ScriptableEvent<E, T> : ScriptableObject where E : UnityEvent<T>
    {
        [SerializeField] private E _event;

        public void Subscribe(UnityAction<T> action)
        {
            _event.AddListener(action);
        }

        public void Unsubscribe(UnityAction<T> action)
        {
            _event.RemoveListener(action);
        }

        public void Invoke(T parameter)
        {
            _event.Invoke(parameter);
        }
    }

    public abstract class ScriptableEvent<E, T0, T1> : ScriptableObject where E : UnityEvent<T0, T1>
    {
        [SerializeField] private E _event;

        public void Subscribe(UnityAction<T0,T1> action)
        {
            _event.AddListener(action);
        }

        public void Unsubscribe(UnityAction<T0,T1> action)
        {
            _event.RemoveListener(action);
        }

        public void Invoke(T0 parameter1, T1 parameter2)
        {
            _event.Invoke(parameter1,parameter2);
        }
    }
}