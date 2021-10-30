
using UnityEngine;

public class CubeComponent : MonoBehaviour
{
    [SerializeField] private CubeColorize cubeColorize;
    public CubeColorize CubeColorize => cubeColorize;
}
