using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationManager : MonoBehaviour
{
#pragma warning disable 649
    [SerializeField]
    RectTransform scrollview;
    [SerializeField]
    RectTransform ssbutton;
    [SerializeField]
    RectTransform signboard;
#pragma warning restore 649

    float ButtonHalfBodyWidth = 157.5f;
    float BlankCloser = 70;
    bool portraiting = false;
    // Start is called before the first frame update
    void Start()
    {
        //signboard.SetAnchor(AnchorPresets.MiddleCenter);
        //signboard.localPosition = new Vector3(PlayerPrefs.GetFloat("X", 0.0f), PlayerPrefs.GetFloat("Y", 0.0f), 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Screen.width < Screen.height)
        {
            if (portraiting == false)
            {
                //scrollview.SetAnchor(AnchorPresets.MiddleCenter);
                scrollview.sizeDelta = new Vector2(Screen.width + BlankCloser, Screen.height + BlankCloser);

                ssbutton.SetAnchor(AnchorPresets.BottomCenter);
                ssbutton.localPosition = new Vector3(ssbutton.localPosition.x, ssbutton.localPosition.y + ButtonHalfBodyWidth, 0);

                signboard.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                portraiting = true;
            }
        }
        else
        {
            if (portraiting == true)
            {
                //scrollview.SetAnchor(AnchorPresets.MiddleCenter);
                scrollview.sizeDelta = new Vector2(Screen.width + BlankCloser, Screen.height + BlankCloser);

                ssbutton.SetAnchor(AnchorPresets.MiddleRight);
                ssbutton.localPosition = new Vector3(ssbutton.localPosition.x - ButtonHalfBodyWidth, ssbutton.localPosition.y, 0);

                signboard.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                portraiting = false;
            }
        }
    }
}
