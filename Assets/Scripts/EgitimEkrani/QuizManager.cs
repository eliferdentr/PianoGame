using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    [SerializeField] public QuizUI quizUI;
    public List<Question> questions; //quizmanager panelindeki inspector'da her bir question için bir resim ve doðru bir cevap hazýrladým.


    public Question selectedQuestion;
    // Start is called before the first frame update
    void Start()
    {
        SelectQuestion();

    }

    void SelectQuestion() {
        int val = UnityEngine.Random.Range(0, questions.Count); //sorularý random seçeceði için randoom bir numara oluþturalým
        selectedQuestion.correctAnswer = questions[val].correctAnswer;
        selectedQuestion.questionImg = questions[val].questionImg;
        quizUI.SetQuestion(selectedQuestion);
    }

    public bool Answer(Button answered) { //soru doðru cevaplanmýþ mý kontrol eder
        bool correctAns = false;

        if (answered == selectedQuestion.correctAnswer)
        {
            correctAns = true;
         
        }

        else {

            correctAns = false;

        }
        Invoke("SelectQuestion", 0.2f);
        return correctAns;
    }

}

[System.Serializable]
public class Question {  //Bu bir soru oluþturmaya yarýyor. 
    public Button correctAnswer;  //Sorunun doðru cevabý bir piyano tuþu olacak ???????????????????????????
    public Sprite questionImg; //sorunun notasýný gösteren bir resim olacak
}


