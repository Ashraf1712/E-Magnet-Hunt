using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputCheck : MonoBehaviour
{
    public InputField inputField;
    public Sprite[] sprites;

    void Update()
    {
        if (!string.IsNullOrEmpty(inputField.text))
        {
            this.GetComponent<Button>().interactable = true;
            this.GetComponent<Image>().sprite = sprites[1];
        }
        else
        {
            this.GetComponent<Button>().interactable = false;
            this.GetComponent<Image>().sprite = sprites[0];
        }
    }
}
