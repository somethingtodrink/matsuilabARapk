using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveInputField : MonoBehaviour
{
    public GameObject inputField;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        inputField.GetComponent<InputField>().text = PlayerPrefs.GetString("text_inputField", "");
        text = inputField.GetComponent<InputField>().text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveText()
    {
        text = inputField.GetComponent<InputField>().text;
        PlayerPrefs.SetString("text_inputField", text);
        PlayerPrefs.Save();
    }
}
