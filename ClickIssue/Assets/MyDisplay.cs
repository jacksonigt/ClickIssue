using UnityEngine;

public class MyDisplay : MonoBehaviour
{
    void Start()
    {


        for(var i = 0; i < 2; i++)
        {
            var display = Display.displays[i];

            if(i == 0)
            {
                // To change the size and position of primary display you must also activate it by calling Display.displays[0].Activate(0, 0, 0);
                // https://docs.unity3d.com/2020.3/Documentation/ScriptReference/Display.SetParams.html
                display.Activate(0,0,0);
            }
            else
            {
                display.Activate();
            }

            var width = 800;
            int height = 450;
            display.SetParams(width, height, x: 50, y: i * height + i * 24);
        }
    }
}
