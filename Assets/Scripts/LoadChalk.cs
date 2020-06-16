using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadChalk : MonoBehaviour
{   
    #pragma warning disable 649
    [SerializeField] GameObject chalk;
    #pragma warning restore 649
    string key, str, nl;
    int len, remainder, quotient;

    void Start()
    {
        key = chalk.name + "_InputField";
        str = PlayerPrefs.GetString(key, "");
        len = str.Length;
        
        if (len > 19) //Description用
        {
            remainder = len % 19;               //余り 
            quotient = (len-remainder) / 19;    //商
            
            for (int i = 0; i < quotient; i++) 
            {
                nl += str.Substring(0, 18) + "\n";   //0-18 19-37
            }
            nl += str.Substring(0, remainder);
            str = nl;
        }

        chalk.GetComponent<TextMesh>().text = str;
    }
}
