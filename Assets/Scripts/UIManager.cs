using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void loadGame()
    {
        //Debug.Log("WORKING");
        SceneManager.LoadScene(0);
    }


    public void exitGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("a");
    }
}
