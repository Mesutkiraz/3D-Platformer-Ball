using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void Oyna()
    {
        SceneManager.LoadScene(1);
    }
    public void Cikis()
    {
        Application.Quit();
    }

    public void AppMenu()
    {
        SceneManager.LoadScene(0);
    }
}
