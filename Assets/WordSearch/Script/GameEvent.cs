using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvent
{
    public delegate void EnableSquareSelection();
    public static event EnableSquareSelection OnEnableSquareSelection;
    public static void EnableSquareSelectionMethod()
    {
        if(OnEnableSquareSelection!= null) 
            OnEnableSquareSelection();
    }

    //**********************************************************************//

    public delegate void DisableSquareSelection();
    public static event DisableSquareSelection OnDisableSquareSelection;
    public static void DisableSquareSelectionMethod()
    {
        if (OnDisableSquareSelection != null)
            OnDisableSquareSelection();
    }

    //**********************************************************************//
    public delegate void SelectSquare(Vector3 position);
    public static event SelectSquare OnSelectSquare;
    public static void OnSelectSquareMethod(Vector3 position)
    {
        if (OnSelectSquare != null)
            OnSelectSquare(position);
    }

    //**********************************************************************//

    public delegate void CheckSquare(string letter, Vector3 squarePosition, int squareIndex);
    public static event CheckSquare OnCheckSquare;
    public static void OnCheckSquareMethod(string letter, Vector3 squarePosition, int squareIndex)
    {
        if (OnCheckSquare != null)
            OnCheckSquare(letter, squarePosition, squareIndex);
    }

    //**********************************************************************//

    public delegate void ClearSelection();
    public static event ClearSelection OnClearSelection;
    public static void OnClearSelectionMethod()
    {
        if (OnClearSelection != null)
            OnClearSelection();
    }

    //**********************************************************************//
    public delegate void CorrectWord(string word, List<int> squareIndex);
    public static event CorrectWord OnCorrectWord;

    public static void CorrectWordMethod(string word, List<int> squareIndex)
    {
        if (OnCorrectWord != null)
        {
            OnCorrectWord(word, squareIndex);
        }
    }
    //**********************************************************************//


}
