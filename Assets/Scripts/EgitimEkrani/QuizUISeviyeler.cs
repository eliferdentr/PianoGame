using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


//oyunun arayüzünü kontrol edecek
public class QuizUISeviyeler : MonoBehaviour
{
    [SerializeField] public QuizManagerSeviyeler quizManagerSeviyeler;
    [SerializeField] public Image questionImage; //bunu serializefield yaparak buna inspector'dan referans yapabiliriz
    [SerializeField] public List<Button> options;     //bunlar butonlarýn, yani tuþlarýn hepsi oluyor
    [SerializeField] public Color correctCol, wrongCol, normalCol;

    public Question question; //seçilen soru burada tutulacak
    public bool answered; //bu sorunun cevaplanýp cevaplanmadýðýna bakýlacak. böylece birden fazla seçeneðe týklanmayacak (?) adam öyle dedi idk

    // Start is called before the first frame update


    void Awake()
    {
        for (int i = 0; i < options.Count; i++)
        {
            Button localBtn = options[i];
            localBtn.onClick.AddListener(() => OnClick(localBtn));
        }
    }

    // Update is called once per frame


    /// Method which populate the question on the screen

    public void SetQuestion(Question question)
    {
        this.question = question; //bir soru seçildi
        questionImage.transform.parent.gameObject.SetActive(true);
        questionImage.transform.gameObject.SetActive(true);
        questionImage.sprite = question.questionImg;

        //EÐER BUTONLAR SORULARLA UYUÞMUYORSA BURASI DÜZELTÝLECEK

        //suffle the list of options

        //assign options to respective option buttons
        for (int i = 0; i < options.Count; i++)    //LOOP THROUGH THE BUTTONS
        {
            //set button text and name with respect to the answers. for that we need to 
            options[i].image.color = normalCol; //set color of button to normal


        }

        answered = false;
     


    }
    private void OnClick(Button btn)
    {
        if (!answered)
        {
            answered = true;
            bool val = quizManagerSeviyeler.Answer(btn);

            if (val)
            {
                btn.image.color = correctCol;

            }

            else
            {

                btn.image.color = wrongCol;


            }
        }
    }

}
