
using UnityEngine;

public class AddCubeComponent : TriggerInteract
{
    [SerializeField] private CubeComponent thisCube;
    protected override void TriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out TowerBuilder towerBuilder))
        {
            towerBuilder.AddCube(thisCube);
            Destroy(this);
        }
    }
}
