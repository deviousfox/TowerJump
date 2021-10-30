
using UnityEngine;

public class MoveToGlobalDirection : MonoBehaviour
{
    [SerializeField] private Vector3 direction = Vector3.forward;
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool canMove;

    public void ChangeMoveState(bool moveState)
    {
        canMove = moveState;
    }

    private void Update()
    {
        if(canMove)
            transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
