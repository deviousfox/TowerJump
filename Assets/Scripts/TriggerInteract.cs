
using UnityEngine;

public class TriggerInteract : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        TriggerEnter(other);
    }
    private void OnTriggerExit(Collider other)
    {
        TriggerExit(other);
    }

    private void OnTriggerStay(Collider other)
    {
        TriggerStay(other);
    }

    protected virtual void TriggerEnter(Collider other)
    {

    }
    protected virtual void TriggerExit(Collider other)
    {

    }
    protected virtual void TriggerStay(Collider other)
    {

    }
}
