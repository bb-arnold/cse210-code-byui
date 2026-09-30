using System;

class Word
{
    private string _word;
    private string _wordDisplay;

    public Word(string word)
    {
        _word = word;
        _wordDisplay = word;
    }

    public string GetWord()
    {
        return _wordDisplay;
    }

    public void HideWord()
    {
        //clear the _wordDisplay variable
        _wordDisplay = "";

        //Iterate through each letter in word, add a _ to 
        //_wordDisplay for every letter in _word
        foreach (char letter in _word)
        {
            _wordDisplay += "_";
        } 
    }

    public Boolean IsHidden()
    {
        if(_word == _wordDisplay)
        {
            return false;
        }
        else
        {
            return true;
        }
    } 
}