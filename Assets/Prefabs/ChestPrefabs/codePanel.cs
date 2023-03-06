using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class codePanel : MonoBehaviour
{
    [SerializeField] GameObject keypad;
    [Header("Setting")]
    [SerializeField] string correctCode;
    [SerializeField] Animator _chestAnim;
    private int codeSubstring;

    [SerializeField] Text codeText;
    string codeTextValue = "";

    private void Start()
    {
        codeSubstring = correctCode.Length;
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
        if (codeTextValue.Length > codeSubstring)
        {
            codeTextValue = codeTextValue.Substring(0, codeSubstring);
            return;
        }
        codeText.text = codeTextValue;
    }

    public void RemoveDigit()
    {
        try
        {
            codeTextValue = codeTextValue.Substring(0, codeTextValue.Length - 1);
            codeText.text = codeTextValue;
            if (codeTextValue.Length < 0)
            {
                throw new Exception();
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
            Debug.Log("error ignored");
        }

    }

    public void GreenButton()
    {
        if (codeTextValue == correctCode)
        {
            _chestAnim.SetTrigger("openChest");
            keypad.SetActive(false);
        }
        else
        {
            codeTextValue = "";
            codeText.text = codeTextValue;
        }
    }


}
