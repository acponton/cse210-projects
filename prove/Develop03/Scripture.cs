using System;

public class Scripture
{
    private string _word1;
    private string _word2;
    private string _word3;
    private string _word4;
    private string _word5;
    private string _word6;
    private string _word7;
    private string _word8;
    private string _word9;
    private string _word10;
    private string _word11;
    private string _word12;
    private string _word13;
    private string _word14;
    private string _word15;
    private string _word16;
    private string _word17;
    private string _word18;
    private string _word19;
    private string _word20;
    private string _word21;
    private string _word22;
    private string _word23;
    private string _word24;
    

    public Scripture()
    {

    }
    
    public void SetScripture()
    {
        _word1 = "God";
        _word2 = "so";
        _word3 = "loved";
        _word4 = "the";
        _word5 = "world";
        _word6 = "that";
        _word7 = "he";
        _word8 = "gave";
        _word9 = "his";
        _word10 = "only";
        _word11 = "begotten";
        _word12 = "Son";
        _word13 = "that";
        _word14 = "whosoever";
        _word15 = "believeth";
        _word16 = "in";
        _word17 = "him";
        _word18 = "should";
        _word19 = "not";
        _word20 = "perish";
        _word21 = "but";
        _word22 = "have";
        _word23 = "everlasting";
        _word24 = "life";
    }
    
    public string GetFullScripture()
    {
        return $"{_word1} {_word2} {_word3} {_word4} {_word5}, {_word6} {_word7} {_word8} {_word9} {_word10} {_word11} {_word12},
        {_word13} {_word14} {_word15} {_word16} {_word17} {_word18} {_word19} {_word20}, {_word21} {_word22} {_word23} {_word24}";
    }
    
    
}