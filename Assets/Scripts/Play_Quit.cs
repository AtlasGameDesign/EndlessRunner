using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void button()
    {
        SceneManager.LoadScene(3);
    }

    public void escape()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }
}
