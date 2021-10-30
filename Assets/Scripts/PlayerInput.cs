
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private JumpComponent jumpComponent;
    [SerializeField] private float multiplierAddSpeed = 2;
    
    private float currentMultiplier;

    private void Update()
    {
        if (Input.GetMouseButton(0))
            currentMultiplier += Time.deltaTime*multiplierAddSpeed;
        

        if (Input.GetMouseButtonUp(0))
        {
            jumpComponent.StartJump(currentMultiplier);
            currentMultiplier = 0;
        }
    }
}
