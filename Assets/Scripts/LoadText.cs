using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    string key, str;
    string nl = "";
    int indx, len, remainder, quotient, i;

    void Start()
    {
        indx = this.name.IndexOf("_");
        key = this.name.Substring(0, indx);
        str = PlayerPrefs.GetString(key, "");
        len = str.Length;
        
        if (len > 19) //Description用
        {
            remainder = len % 19;               //余り 
            quotient = (len-remainder) / 19;    //商
            
            for (i = 0; i < quotient; i++) 
            {
                nl += str.Substring(0+i*19, 19) + "\n";   //0-18 19-37
            }
            nl += str.Substring(quotient*19, remainder);
            str = nl;
        }

        this.GetComponent<Text>().text = str;
    }
}
