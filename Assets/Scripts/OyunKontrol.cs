using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{

    public int skor;
    public Text skorText;
    public List<Image> canlar;

    void Start()
    {
        skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        skorText.text = "Skor: " + skor;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public void OyunBitti()
    {
        SceneManager.LoadScene("AnaMenü");
    }
}
