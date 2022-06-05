using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManagerSeviyeler : MonoBehaviour
{
    [SerializeField] public QuizUISeviyeler quizUISeviyeler;
    public List<Question> questions; //quizmanager panelindeki inspector'da her bir question için bir resim ve doðru bir cevap hazýrladým.
    public int kalancan=3; //YENÝ
    public int questionindex;
    

    public Question selectedQuestion;

    

    // Start is called before the first frame update
    void Start()
    {
        SelectQuestion();
        kalancan = 3;

    }

    void SelectQuestion()
    {
        if (questions.Count == 0)
        {
            SceneManager.LoadScene("SeviyeyiBitir");
        }
        else
        {
            int val = UnityEngine.Random.Range(0, questions.Count); //sorularý random seçeceði için randoom bir numara oluþturalým
            questionindex = val;

            selectedQuestion.correctAnswer = questions[val].correctAnswer;
            selectedQuestion.questionImg = questions[val].questionImg;
            quizUISeviyeler.SetQuestion(selectedQuestion);
        }
  
    }

    public bool Answer(Button answered)
    { //soru doðru cevaplanmýþ mý kontrol eder
        bool correctAns = false;



      

        if (answered == selectedQuestion.correctAnswer)
        {
            correctAns = true;
            questions[questionindex].dondurmesayisi -= 1;

           

            if (questions[questionindex].dondurmesayisi == 0) {
                questions.RemoveAt(questionindex);
            }


        }

        else
        {

            correctAns = false;
            kalancan -= 1; //YENÝ
            quizUISeviyeler.ReduceLife(kalancan);
            questions[questionindex].yanlishakkisayisi -= 1;


            if (kalancan == 0)
            {

                SceneManager.LoadScene("TekrarDene");
            }

            if (questions[questionindex].yanlishakkisayisi == 0) {

                SceneManager.LoadScene("TekrarDene");

            }

        }

        Invoke("SelectQuestion", 0.3f);
        return correctAns;
    }
}


