using UnityEngine;
using UnityEngine.Events;

namespace loophouse.ScriptableEvents
{
    public class ScriptableEventListener : MonoBehaviour
    {
        [SerializeField] private ScriptableEvent _scriptableEvent;
        [SerializeField] private UnityEvent _listeners;

        private void OnEnable()
        {
            _scriptableEvent.Subscribe(OnEventTrigger);
        }

        private void OnDisable()
        {
            _scriptableEvent.Unsubscribe(OnEventTrigger);
        }

        void OnEventTrigger()
        {
            _listeners.Invoke();
        }
    }

    public abstract class ScriptableEventListener<S, E, T> : MonoBehaviour where S : ScriptableEvent<E, T> where E : UnityEvent<T>
    {
        [SerializeField] protected S _scriptableEvent;
        [SerializeField] private E _listeners;

        private void OnEnable()
        {
            _scriptableEvent.Subscribe(OnEventTrigger);
        }

        private void OnDisable()
        {
            _scriptableEvent.Unsubscribe(OnEventTrigger);
        }

        void OnEventTrigger(T parameter)
        {
            _listeners.Invoke(parameter);
        }
    }

    public abstract class ScriptableEventListener<S, E, T0, T1> : MonoBehaviour where S : ScriptableEvent<E, T0, T1> where E : UnityEvent<T0, T1>
    {
        [SerializeField] protected S _scriptableEvent;
        [SerializeField] private E _listeners;

        private void OnEnable()
        {
            _scriptableEvent.Subscribe(OnEventTrigger);
        }

        private void OnDisable()
        {
            _scriptableEvent.Unsubscribe(OnEventTrigger);
        }

        void OnEventTrigger(T0 parameter1, T1 parameter2)
        {
            _listeners.Invoke(parameter1, parameter2);
        }
    }
}