using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadChalk : MonoBehaviour
{   
    #pragma warning disable 649
    [SerializeField] GameObject chalk;
    #pragma warning restore 649
    string key;

    void Start()
    {
        key = chalk.name + "_InputField";
        chalk.GetComponent<TextMesh>().text = PlayerPrefs.GetString(key, "");
    }
}
