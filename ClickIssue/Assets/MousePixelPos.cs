using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MousePixelPos : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var pos = Input.mousePosition;

        GetComponent<TextMeshProUGUI>().text = $"Mouse Pos: x{pos.x}, y{pos.y}";
    }
}
