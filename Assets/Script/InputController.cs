using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    [Header("Enter The Code Here")] 
    public string Code;

    [Header("Please Ignore")]
    public InputField inputField;
    public Button submitButton;
    public GameObject safeQuestion;
    public GameObject closedSafe;
    public GameObject openedSafe;

    private void Start()
    {
        submitButton.onClick.AddListener(SubmitInput);
    }

    private void SubmitInput()
    {
        string inputValue = inputField.text;
        if(inputValue == Code)
        {
            safeQuestion.SetActive(false);
            closedSafe.SetActive(false);
            openedSafe.SetActive(true);
        }
        else
        {
            HealthBar.currentHealth -= 1;
        }
    }
}