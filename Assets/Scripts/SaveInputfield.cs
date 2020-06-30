using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveInputfield : MonoBehaviour
{
    int indx;
    string key;

    void Start()
    {
        indx = this.name.IndexOf("_");
        key = this.name.Substring(0, indx);
        this.GetComponent<InputField>().text = PlayerPrefs.GetString(key);
    }

    void Update()
    {
        PlayerPrefs.SetString(key, this.GetComponent<InputField>().text);
        PlayerPrefs.Save();
        this.GetComponent<InputField>().text = PlayerPrefs.GetString(key, "");
    }
}
