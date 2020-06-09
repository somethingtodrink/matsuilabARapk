using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour
{
    #pragma warning disable 649
    [SerializeField] GameObject inFi;
    [SerializeField] Text count;
    #pragma warning restore 649
    int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        n = inFi.GetComponent<InputField>().text.Length;
        count.GetComponent<Text>().text = n.ToString() + "字";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeCount()
    {
        n = inFi.GetComponent<InputField>().text.Length;
        count.GetComponent<Text>().text = n.ToString() + "字";
    }
}
