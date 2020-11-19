using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
public class GecisEkran : MonoBehaviour
{
    public Button[] butonlar;
    public int bölümler;




    private void Awake()
    {
        bölümler = PlayerPrefs.GetInt("bolum");

        if (bölümler <= 1)
        {
            bölümler = 1;
        }
    }

    public void BolumeBasla(string bolum)
    {
        SceneManager.LoadScene(bolum);

    }
    public void Start()
    {
        KilitSistemi();

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void KilitSistemi()
    {
        for (int i = 0; i < butonlar.Length; i++)
        {
            if (bölümler >= butonlar.Length)
            {
                butonlar[i].interactable = true;
            }

            if (bölümler >= int.Parse(butonlar[i].name))
            {
                butonlar[i].interactable = true;
            }
            else if(bölümler < int.Parse(butonlar[i].name))
            {
                butonlar[i].interactable = false;
            }

        }
    }


    //[MenuItem("My Menu/Kayit Sil")]
    //static void KayitSil()
    //{
    //    PlayerPrefs.DeleteAll();
    //}
}
