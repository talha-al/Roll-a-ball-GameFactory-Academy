using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenü : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }

    public IEnumerator Anan()
    {
        yield return null; 
    }

    public void OyunaBasla()
    {
        SceneManager.LoadScene("Gecis");
    }

    public void Linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/talha-%C5%9Feref-alata%C5%9F-b28153158/");
    }

    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/talhaalatas/");
    }
}
