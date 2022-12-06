using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDot : MonoBehaviour
{
    public Camera ReferenceCam;

    void Update()
    {
        // transform.position = (Vector2)ReferenceCam.ScreenToViewportPoint(Input.mousePosition);
        transform.position = (Vector2)ReferenceCam.ScreenToWorldPoint(Input.mousePosition);
    }
}
