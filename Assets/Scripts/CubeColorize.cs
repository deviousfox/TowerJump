
using UnityEngine;
public class CubeColorize : MonoBehaviour
{
    [SerializeField] private Color defaultColor = Color.gray;

    private Material thisMaterial;

    private void Awake()
    {
        thisMaterial = GetComponent<MeshRenderer>().material;
        thisMaterial.SetColor("_Color", defaultColor);
    }
    public void SetColor(Color color)
    {
        thisMaterial.SetColor("_Color", color);
    }
}
