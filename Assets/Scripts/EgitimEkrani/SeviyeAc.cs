using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeviyeAc : MonoBehaviour
{
    public static Button seviye1button, seviye2button, seviye3button;
    public static bool seviye1 = true, seviye2 = false, seviye3 = false;
    // Start is called before the first frame update
    public void AnaMen()
    {
        SceneManager.LoadScene("AnaMenu");
    }

    public void Seviye1()
    {
        SceneManager.LoadScene("EgitimEkrani 1");
    }

    public void Seviye2()
    {
        SceneManager.LoadScene("EgitimEkrani 2");
    }

    public void Seviye3()
    {
        SceneManager.LoadScene("EgitimEkrani 3");
    }

    public void Cikis()
    {
        Application.Quit();
    }

   
}
