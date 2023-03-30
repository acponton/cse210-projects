using System;

public class Scripture
{  

private static string _scripture = "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

//     private string _word1 = "God";
//     private string _word2 = "so";
//     private string _word3 = "loved";
//     private string _word4 = "the";
//     private string _word5 = "world";
//     private string _word6 = "that";
//     private string _word7 = "he";
//     private string _word8 = "gave";
//     private string _word9 = "his";
//     private string _word10 = "only";
//     private string _word11 = "begotten";
//     private string _word12 = "Son";
//     private string _word13 = "that";
//     private string _word14 = "whosoever";
//     private string _word15 = "believeth";
//     private string _word16 = "in";
//     private string _word17 = "him";
//     private string _word18 = "should";
//     private string _word19 = "not";
//     private string _word20 = "perish";
//     private string _word21 = "but";
//     private string _word22 = "have";
//     private string _word23 = "everlasting";
//     private string _word24 = "life";

    public Scripture()
    {

    }
    
    // public string DisplayFullScripture()
    // {
    //     return $"{_word1} {_word2} {_word3} {_word4} {_word5}, {_word6} {_word7} {_word8} {_word9} {_word10} {_word11} {_word12},\n{_word13} {_word14} {_word15} {_word16} {_word17} {_word18} {_word19} {_word20}, {_word21} {_word22} {_word23} {_word24}.";
    // }
    
	    
    public string[] _splitScripture = _scripture.Split(' ');
    public List<int> _splitScriptureIndex = new List<int>();


    public string DisplayFullScripture()
    {
        return $"{_scripture}";
    }
    
}