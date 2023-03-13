using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public string[] sentences;
    private int index = 0;
    public float dialogueSpeed = 0f;
    private readonly Array keyCodes = Enum.GetValues(typeof(KeyCode));
    [SerializeField] private float timer;
    private bool isTimerDone = false;
    [SerializeField] private ToTheNextScene nextScene;
    void Start()
    {
        DialogueText.text = string.Empty;
        StartCoroutine(Start(timer));
    }
    void Update()
    {
        if (GetKeyboard() && isTimerDone)
        {
            if(DialogueText.text == sentences[index])
            {
                NextSentence();
            }
            else
            {
                StopAllCoroutines();
                DialogueText.text = sentences[index];
            }
        }
    }
    private IEnumerator Start(float timer)
    {
        yield return new WaitForSeconds(timer);
        isTimerDone = true;
        StartDialogue();
    }
    bool GetKeyboard()
    {
        if (Input.anyKeyDown)
        {
            foreach (KeyCode keyCode in keyCodes)
            {
                if (Input.GetKey(keyCode))
                {
                    if (keyCode == KeyCode.Escape)
                        return false;
                    else
                        return true;
                }
            }
        }
        return false;
    }
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(WriteSentence());
    }

    void NextSentence()
    {
        if(index < sentences.Length - 1)
        {
            AnimatorHear hear = GameObject.FindObjectOfType<AnimatorHear>();
            hear.ClickMe();
            index++;
            DialogueText.text = string.Empty;
            StartCoroutine(WriteSentence());
        }
        else
        {
            nextScene.onClick();
        }
    }

    IEnumerator WriteSentence()
    {
        foreach(char character in sentences[index].ToCharArray())
        {
            DialogueText.text += character;
            yield return new WaitForSeconds(dialogueSpeed);
        }

    }
}
