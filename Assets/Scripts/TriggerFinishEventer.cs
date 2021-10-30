
using UnityEngine;
using UnityEngine.Events;
public class TriggerFinishEventer : TriggerInteract
{
    [SerializeField] private UnityEvent OnFinishedEvent;
    protected override void TriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerInput input))
        {
            OnFinishedEvent?.Invoke();
        }
    }
}
