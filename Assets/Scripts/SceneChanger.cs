using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "AR_Scene")
        {
            Screen.autorotateToPortrait = true;
            Screen.autorotateToLandscapeLeft = true;
            Screen.autorotateToLandscapeRight = true;
            Screen.autorotateToPortraitUpsideDown = false;
            
            Screen.orientation = ScreenOrientation.AutoRotation;
        }
        else
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }

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
