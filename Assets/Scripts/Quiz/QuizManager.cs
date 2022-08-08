using System;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    void Awake()
    {
        // Creating a new list for questions
        List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();
        // Filling that list with the stuff from file QuizQuestions.csv
        data = CSVReader.Read("QuizQuestions");

        // prints into console QuizQuestions.csv 's data, so this bit is not strictly necessary
        for (var i = 0; i < data.Count; i++)
        {
            print("Nro " + data[i]["Nro"] + " " +
                   "Question " + data[i]["Question"] + " " +
                   "CorrectAnswer " + data[i]["CorrectAnswer"] + " " +
                   "False1 " + data[i]["False1"] + " " +
                   "False2 " + data[i]["False2"] + " " +
                   "False3 " + data[i]["False3"]);
        }
    }

    void Update()
    {

    }
}