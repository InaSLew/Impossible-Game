using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent voidEvent;
    public UnityEvent Response;

    private void OnEnable() => voidEvent.RegisterListener(this);
    private void OnDisable() => voidEvent.UnregisterListener(this);
    public void OnEventRaised() => Response.Invoke();
}