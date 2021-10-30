
using UnityEngine;

public class RemoveCubeComponent : TriggerInteract
{
    private TowerBuilder towerBuilder;
    private void Awake()
    {
        towerBuilder = FindObjectOfType<TowerBuilder>();
    }
    protected override void TriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out CubeComponent cubeComponent))
        {
            towerBuilder.GetCube(cubeComponent).CubeColorize.SetColor(Color.gray);
            Destroy(this);
        }
    }
}
