using UnityEngine;

public class MyDisplay : MonoBehaviour
{
    void Start()
    {
        var display = Display.displays[0];
        display.Activate();
        display.SetParams(width: 1600, height: 900, x: 320, y: 0);
    }
}
