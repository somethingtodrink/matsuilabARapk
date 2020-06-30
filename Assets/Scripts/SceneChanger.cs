using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "Menu_Scene")
                Application.Quit();
            else
                SceneManager.LoadScene("Menu_Scene");
        }
    }

    public void ChangeToARScene()
    {
        SceneManager.LoadScene("AR_Scene");
    }

    public void ChangeToInputScene()
    {
        SceneManager.LoadScene("Input_Scene");
    }
}
