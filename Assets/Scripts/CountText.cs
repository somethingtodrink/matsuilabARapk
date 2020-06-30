using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour
{
    InputField inFi;
    Text txt;
    int len = 0;

    // Start is called before the first frame update
    void Start()
    {
        inFi = this.GetComponentInParent<InputField>();
        txt = this.GetComponent<Text>();
        len = inFi.text.Length;
        txt.text = len.ToString() + "字";
    }

    // Update is called once per frame
    void Update()
    {
        len = inFi.text.Length;
        txt.text = len.ToString() + "字";
    }
}
