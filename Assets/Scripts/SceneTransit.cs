using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
