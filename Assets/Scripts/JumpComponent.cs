using System.Collections;
using UnityEngine;

public class JumpComponent : MonoBehaviour
{
    [SerializeField] private AnimationCurve jumpCurve;
   
    [SerializeField] private float jumpDuration = 1;
    [SerializeField] private float maxJumpMultiplier = 5;
    [SerializeField] private float maxJumpDuration = 1;


    public void StartJump(float jumpMultiplier = 1f)
    {
        jumpMultiplier = Mathf.Clamp(Mathf.Abs(jumpMultiplier), 0, maxJumpMultiplier);

        StartCoroutine(Jump(jumpMultiplier, jumpDuration));
    }
    
    public void StartJump(float jumpMultiplier = 1f, float jumpDuration = 1f)
    {
        jumpMultiplier = Mathf.Clamp(Mathf.Abs(jumpMultiplier), 0, maxJumpMultiplier);
        jumpDuration = Mathf.Clamp(Mathf.Abs(jumpDuration), 0, maxJumpDuration);
       
        StartCoroutine(Jump(jumpMultiplier, jumpDuration));
    }

    private IEnumerator Jump(float jumpMultiplier, float jumpDuration)
    {

        float _currentDuration = 0;
        
        while (_currentDuration < jumpDuration)
        {
            _currentDuration += Time.deltaTime;
            
            float _progress = _currentDuration / jumpDuration;
            transform.position = new Vector3(transform.position.x, jumpCurve.Evaluate(_progress)*jumpMultiplier, transform.position.z);
            
            yield return null;
        }
    }

}
