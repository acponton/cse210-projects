using System;

public class Word : Scripture
{

    public Word()
    {
        
    }

    public void ShowScripture()
    {
        foreach(string i in _splitScripture)
        {
            Console.Write($"{i} ");
        }
    }


    public void Hidden()
    {
        string hiddenWord = " _______ ";
        int j = _splitScripture.Length;           
        Random i = new Random();
        int k = i.Next(0, j);
            if(_splitScriptureIndex.Contains(k))
            {
                Random n = new Random();
                int v = i.Next(0,j);
                _splitScripture[v] = hiddenWord;
                _splitScriptureIndex.Add(v);
            }
            else
            {
                _splitScripture[k] = hiddenWord;
                _splitScriptureIndex.Add(k);
            }
            
        foreach(string l in _splitScripture)
        {
            Console.Write($" {l}");
        }
        }


}