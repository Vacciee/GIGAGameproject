using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    private List<Dictionary<string, object>> data;
    private List<Button> buttonsList;
    private List<TMP_Text> buttonTexts;
    public int currentQuestion;
    private int currentButton;
    public Button correctButton;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private TMP_Text button1text;
    private TMP_Text button2text;
    private TMP_Text button3text;
    private TMP_Text button4text;
    private TMP_Text questionText;

    void Awake()
    {
        button1 = GameObject.Find("Answer1").GetComponent<Button>();
        button2 = GameObject.Find("Answer2").GetComponent<Button>();
        button3 = GameObject.Find("Answer3").GetComponent<Button>();
        button4 = GameObject.Find("Answer4").GetComponent<Button>();

        button1text = GameObject.Find("AnswerText1").GetComponent<TMP_Text>();
        button2text = GameObject.Find("AnswerText2").GetComponent<TMP_Text>();
        button3text = GameObject.Find("AnswerText3").GetComponent<TMP_Text>();
        button4text = GameObject.Find("AnswerText4").GetComponent<TMP_Text>();

        questionText = GameObject.Find("QuestionText").GetComponent<TMP_Text>();

        data = new List<Dictionary<string, object>>();
        // Filling the list with the stuff from file QuizQuestions.csv
        data = CSVReader.Read("QuizQuestions");
        // prints into console QuizQuestions.csv 's data, so this bit is not strictly necessary, but it's nice 
        for (var i = 0; i < data.Count; i++)
        {
            print("Nro " + data[i]["Nro"] + " " +
                   "Question " + data[i]["Question"] + " " +
                   "CorrectAnswer " + data[i]["CorrectAnswer"] + " " +
                   "False1 " + data[i]["False1"] + " " +
                   "False2 " + data[i]["False2"] + " " +
                   "False3 " + data[i]["False3"]);
        }
        // Getting our first quiz round
        UpdateQuiz();
    }

    // void Update()
    // {

    // }

    void UpdateQuiz()
    {
        GetNewQuestion();
        // Update the question text
        questionText.text = data[currentQuestion]["Question"].ToString();
        // Listing our buttons for randomizing answers
        buttonsList = new List<Button>();
        buttonsList.Add(button1);
        buttonsList.Add(button2);
        buttonsList.Add(button3);
        buttonsList.Add(button4);
        // Listing our buttons' texts in the same way to update them at the same time with the buttons
        buttonTexts = new List<TMP_Text>();
        buttonTexts.Add(button1text);
        buttonTexts.Add(button2text);
        buttonTexts.Add(button3text);
        buttonTexts.Add(button4text);
        // Getting a button for the correct answer
        currentButton = UnityEngine.Random.Range(0, buttonsList.Count);
        correctButton = buttonsList[currentButton];
        // Setting the text for the correct answer
        buttonTexts[currentButton].text = data[currentQuestion]["CorrectAnswer"].ToString();
        // In order to not pick the same button for the next answer, we remove it from the list (the text as well)
        buttonsList.RemoveAt(currentButton);
        buttonTexts.RemoveAt(currentButton);
        // Picking a button for 1st wrong answer
        currentButton = UnityEngine.Random.Range(0, buttonsList.Count);
        buttonTexts[currentButton].text = data[currentQuestion]["False1"].ToString();
        buttonsList.RemoveAt(currentButton);
        buttonTexts.RemoveAt(currentButton);
        // And for the second
        currentButton = UnityEngine.Random.Range(0, buttonsList.Count);
        buttonTexts[currentButton].text = data[currentQuestion]["False2"].ToString();
        buttonsList.RemoveAt(currentButton);
        buttonTexts.RemoveAt(currentButton);
        // And the third
        currentButton = UnityEngine.Random.Range(0, buttonsList.Count);
        buttonTexts[currentButton].text = data[currentQuestion]["False3"].ToString();
        buttonsList.RemoveAt(currentButton);
        buttonTexts.RemoveAt(currentButton);
        // And now let's make sure the lists are empty for sure for the next round
        buttonsList.Clear();
        buttonTexts.Clear();
    }

    void AnswerCorrect()
    {

    }

    void AnswerWrong()
    {

    }

    void GetNewQuestion()
    {
        currentQuestion = UnityEngine.Random.Range(0, data.Count);
        print("currentQuestion has been set to question " + currentQuestion + ".");
    }
}