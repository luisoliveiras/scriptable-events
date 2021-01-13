using UnityEngine;
using loophouse.ScriptableEvents;

[CreateAssetMenu(menuName = "Scriptable Objects/Vector3ScriptableEvent", fileName = "new Vector3ScriptableEvent")]
public class Vector3ScriptableEvent : ScriptableEvent<Vector3Event, Vector3> { }