using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText_InputField : MonoBehaviour
{   public GameObject chalk;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        chalk.GetComponent<TextMesh>().text = PlayerPrefs.GetString("text_inputField", "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
