using UnityEngine;
using loophouse.ScriptableEvents;

[CreateAssetMenu(menuName = "Scriptable Events/Int Event", fileName = "IntScriptableEvent")]
public class IntScriptableEvent : ScriptableEvent<IntEvent, int> { }