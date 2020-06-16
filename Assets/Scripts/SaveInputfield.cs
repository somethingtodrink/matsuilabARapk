using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveInputfield : MonoBehaviour
{
    #pragma warning disable 649
    [SerializeField] GameObject inFi;
    #pragma warning restore 649

    void Start()
    {
        inFi.GetComponent<InputField>().text = PlayerPrefs.GetString(inFi.name, "");
    }

    public void SaveInfi()
    {
        PlayerPrefs.SetString(inFi.name, inFi.GetComponent<InputField>().text);
        inFi.GetComponent<InputField>().text = PlayerPrefs.GetString(inFi.name, "");
        PlayerPrefs.Save();
    }
}
