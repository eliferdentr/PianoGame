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

  
    public void Cikis() {
        Application.Quit();
    }

}
