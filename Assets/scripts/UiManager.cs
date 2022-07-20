using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Application.LoadLevel("level1");
    }

    public void doExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();       
            
            
        
    }
}
