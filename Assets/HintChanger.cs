using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class HintChanger : MonoBehaviour
{
    public Canvas[] hintCanvas;
    private int count = 0;

    public void changeHint()
    {
        count++;
        for(int i = 0; i < hintCanvas.Length; i++)
        {
            if (i == count)
            {
                hintCanvas[i].gameObject.SetActive(true);
            }
            else
            {
                hintCanvas[i].gameObject.SetActive(false);
            }
        }
    }
}
