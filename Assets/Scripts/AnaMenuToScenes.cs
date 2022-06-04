using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AnaMenuToScenes : MonoBehaviour
{
    public void EgitimEkr() {

        SceneManager.LoadScene("EgitimEkrani");
    }

    public void AraMen() {
        SceneManager.LoadScene("AraMenu");
    }

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

    public void Cikis() {
        Application.Quit();
    }

}
