using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameEvent;

public class GridSquare : MonoBehaviour
{

    public int SquareIndex { get;  set; }

    private AlphabetData.LetterData _normalLetterData;
    private AlphabetData.LetterData _selectedLetterData;
    private AlphabetData.LetterData _correctLetterData;

    private SpriteRenderer _displayedImage;

    private bool _selected;
    private bool _clicked;
    private int _index = -1;
    private bool _correct;

    public void SetIndex(int index)
    {
        _index = index;
    }

    public int GetIndex() 
    { 
        return _index; 
    }

    void Start()
    {
        _selected = false;
        _clicked = false;
        _correct = false;
        _displayedImage= GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        GameEvent.OnEnableSquareSelection += OnEnableSquareSelection;
        GameEvent.OnDisableSquareSelection += OnDisableSquareSelection;
        GameEvent.OnSelectSquare += SelectSquare;
        GameEvent.OnCorrectWord += CorrectWord;
    }

    private void OnDisable()
    {
        GameEvent.OnEnableSquareSelection -= OnEnableSquareSelection;
        GameEvent.OnDisableSquareSelection -= OnDisableSquareSelection;
        GameEvent.OnSelectSquare -= SelectSquare;
        GameEvent.OnCorrectWord -= CorrectWord;
    }

    private void CorrectWord(string word, List<int> squareIndex)
    {
        if(_selected && squareIndex.Contains(_index))
        {
            _correct = true;
            _displayedImage.sprite = _correctLetterData.image;
        }

        _selected = false;
        _clicked = false;
    }

    public void OnEnableSquareSelection()
    {
        _clicked = true;
        _selected = false;
    }
    public void OnDisableSquareSelection()
    {
        _clicked = false;
        _selected = false;
        if (_correct == true)
            _displayedImage.sprite = _correctLetterData.image;
        else
            _displayedImage.sprite = _normalLetterData.image;
    }

    private void SelectSquare(Vector3 position)
    {
        if(this.gameObject.transform.position == position)
        {
            _displayedImage.sprite = _selectedLetterData.image;
        }
    }

    public void SetSprite(AlphabetData.LetterData normalLetterData, AlphabetData.LetterData selectedLetterData, 
        AlphabetData.LetterData correctLetterData)
    {
        _normalLetterData=normalLetterData;
        _selectedLetterData=selectedLetterData;
        _correctLetterData=correctLetterData;

        GetComponent<SpriteRenderer>().sprite = _normalLetterData.image;
    }

    private void OnMouseDown()
    {
        OnEnableSquareSelection();
        GameEvent.EnableSquareSelectionMethod();
        CheckSquare();
        _displayedImage.sprite = _selectedLetterData.image;
    }

    private void OnMouseEnter()
    {
        CheckSquare();
    }

    private void OnMouseUp()
    {
        GameEvent.OnClearSelectionMethod();
        GameEvent.DisableSquareSelectionMethod();

    }

    public void CheckSquare()
    {
        if(!_selected && _clicked)
        {
            _selected = true;
            GameEvent.OnCheckSquareMethod(_normalLetterData.letter, gameObject.transform.position, _index);
        }
    }

}
