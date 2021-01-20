using loophouse.ScriptableEvents;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Events/Bool Event", fileName = "BoolScriptableEvent")]
public class BoolScriptableEvent : ScriptableEvent<BoolEvent,bool> { }