using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class BoardData : ScriptableObject
{
    [System.Serializable]
    public class SearchingWord
    {
        public string word;
        public string questions;
    }

    [System.Serializable]
    public class BoardRow
    {
        public int size;
        public string[] Row;

        public BoardRow() { }
        public BoardRow(int size)
        {
            CreateRow(size);
        }

        public void CreateRow(int _size)
        {
            size = _size;
            Row = new string[size];
            ClearRow();
        }

        public void ClearRow()
        {
            for(int i = 0;i < size;i++)
            {
                Row[i] = string.Empty;
            }
        }
    }

    public int Columns = 0;
    public int Rows = 0;

    public BoardRow[] Board;
    public List<SearchingWord> SearchWords = new List<SearchingWord>();


    public void ClearWithEmptyString()
    {
        for(int i = 0; i < Columns; i++)
        {
            Board[i].ClearRow();
        }
    }

    public void CreateNewBoard()
    {
        Board = new BoardRow[Columns];
        for(int i = 0; i < Columns; i++)
        {
            Board[i] = new BoardRow(Rows);
        }
    }
}
