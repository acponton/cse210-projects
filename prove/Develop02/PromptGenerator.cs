using System;
using System.Collections.Generic;

public class PromptGenerator {

    public List<string> prompts = new List<string>()
    {
        "What was my best experience today?",
        "What experience made me feel sad today?",
        "What was the hardest thing I've gone through today and how did I get over it?",
        "How did I see the hand of the Lord in my life today?",
        "What was my favorite scripture today?"
    };

    public string RandomPrompts()
    {
        var random = new Random();
        int index = random.Next(prompts.Count);
        string randomGenerator = prompts[index];
        return randomGenerator;
    }
       
}