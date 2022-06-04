using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    [SerializeField] public QuizUI quizUI;
    public List<Question> questions; //quizmanager panelindeki inspector'da her bir question i�in bir resim ve do�ru bir cevap haz�rlad�m.


    public Question selectedQuestion;
    // Start is called before the first frame update
    void Start()
    {
        SelectQuestion();

    }

    void SelectQuestion() {
        int val = UnityEngine.Random.Range(0, questions.Count); //sorular� random se�ece�i i�in randoom bir numara olu�tural�m
        selectedQuestion.correctAnswer = questions[val].correctAnswer;
        selectedQuestion.questionImg = questions[val].questionImg;
        quizUI.SetQuestion(selectedQuestion);
    }

    public bool Answer(Button answered) { //soru do�ru cevaplanm�� m� kontrol eder
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
public class Question {  //Bu bir soru olu�turmaya yar�yor. 
    public Button correctAnswer;  //Sorunun do�ru cevab� bir piyano tu�u olacak ???????????????????????????
    public Sprite questionImg; //sorunun notas�n� g�steren bir resim olacak
}


