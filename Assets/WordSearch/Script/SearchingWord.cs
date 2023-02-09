
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchingWord : MonoBehaviour
{
    public Text displayText;
    public Image crossLine;

    private string _word;

    void Start()
    {
    }

    private void OnEnable()
    {
        GameEvent.OnCorrectWord += CorrectWord;

    }
    private void OnDisable()
    {
        GameEvent.OnCorrectWord -= CorrectWord;
    }

    public void SetWord(string word, string question)
    {
        _word = word;
        displayText.text = question;
    }

    private void CorrectWord(string word, List<int> squareIndex)
    {
        if(word == _word)
        {
            crossLine.gameObject.SetActive(true);
        }
    }

}
