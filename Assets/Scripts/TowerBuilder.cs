
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TowerBuilder : MonoBehaviour
{

    [SerializeField] private Transform towerParent;
    [SerializeField] private float cubeOffset;
    [SerializeField] private UnityEvent OnLoseEvent;

    private Stack<CubeComponent> cubeComponents = new Stack<CubeComponent>();
    private CubeComponent[] cubeComponenstTempArray;

    public void AddCube(CubeComponent cube)
    {
        cubeComponents.Push(cube);
        cube.CubeColorize.SetColor(Color.blue);
        cube.transform.parent = towerParent;
        
        RebuildTower();
    }

    public CubeComponent GetCube(CubeComponent cube)
    {
        cube.transform.parent = null;
        CubeComponent returnedCube = cubeComponents.Pop();
        if(cubeComponents.Count == 0)
        {
            OnLoseEvent?.Invoke();
        }
        RebuildTower();
        return returnedCube;
    }

    private void RebuildTower()
    {
        cubeComponenstTempArray = new CubeComponent[cubeComponents.Count * 2];
        cubeComponenstTempArray = cubeComponents.ToArray();
        for (int i = 0; i < cubeComponents.Count; i++)
        {
            cubeComponenstTempArray[i].transform.localPosition = new Vector3(0, i * cubeOffset, 0);
        }
    }
}
