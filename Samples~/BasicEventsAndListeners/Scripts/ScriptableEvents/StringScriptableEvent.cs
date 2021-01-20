using loophouse.ScriptableEvents;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Events/String Event", fileName = "StringScriptableEvent")]
public class StringScriptableEvent : ScriptableEvent<StringEvent, string> { }
