using System.Collections;
using System.Reflection;
using TMPro;
using UnityEngine;

public class MyDisplay : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countDownText;

    void Start()
    {

        if(!Application.isEditor)
        {
            StartCoroutine(DelayThenInit(10f));
        }
    }

    private IEnumerator DelayThenInit(float delaySec)
    {
        var totalDelay = (int)delaySec;

        for(var i = totalDelay; i >=0; i--)
        {
            countDownText.text = $"Time remaining to attach a debugger: {i}";
            yield return new WaitForSeconds((1));
        }
        countDownText.gameObject.SetActive((false));
        InitDisplays();
    }

    void InitDisplays()
    {
        for(var i = 0; i < 2; i++)
        {
            var display = Display.displays[i];

            if(i == 0)
            {
                // To change the size and position of primary display you must also activate it by calling Display.displays[0].Activate(0, 0, 0);
                // https://docs.unity3d.com/2020.3/Documentation/ScriptReference/Display.SetParams.html
                display.Activate(0, 0, 0);
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
