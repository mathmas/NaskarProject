using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public Color defaultColor;
    public Color hoverColor;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = defaultColor;
    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = defaultColor;
    }
}
