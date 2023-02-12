using System;

class Reference
{
    private string _book = "1 Corinthians";
    private string _chapter = "13";
    private string _verse = "4";
    private string _endVerse = "8";

    public string DisplayReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    public string DisplayFullReference()
    {
        return $"{_book} {_chapter}:{_verse} - {_endVerse}";
    }
}