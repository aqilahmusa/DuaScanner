using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void Scan()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonHome()
    {
        SceneManager.LoadScene(0);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void Library()
    {
        SceneManager.LoadScene(2);

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
