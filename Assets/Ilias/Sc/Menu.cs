using UnityEngine;
using System.Collections.Generic;

public class Menu : MonoBehaviour
{
    public List<GameObject> selectedObjects;
    

    public void SetHoverColor(Color color)
    {
        foreach (GameObject obj in selectedObjects)
        {
            obj.GetComponent<ObjectSelector>().hoverColor = color;
        }
    }
}
