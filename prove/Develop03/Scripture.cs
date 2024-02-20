using Microsoft.VisualBasic;

class Scripture
{
    private List<Word> words;
    private string theref = "Moroni 10:3-4"; 
    
     public Scripture()
    {
        words = new List<Word>();
    }
    private List<string> Moroni  = new List<string> { "Behold", "I", "would", "exhort", "you", "that", "when", "ye", "shall", "read", "these", "things", "if", "it", "be", "wisdom", "in", "God", "that", "ye", "should", "read", "them,", "that", "ye", "would", "remember", "how", "merciful", "the", "Lord", "hath", "been", "unto", "the", "children", "of", "men,", "from", "the", "creation", "of", "Adam", "even", "down", "until", "the", "time", "that", "ye", "shall", "receive", "these", "things,", "and", "ponder", "it", "in", "your", "hearts.", "And", "when", "ye", "shall", "receive", "these", "things,", "I", "would", "exhort", "you", "that", "ye", "would", "ask", "God,", "the", "Eternal", "Father,", "in", "the", "name", "of", "Christ,", "if", "these", "things", "are", "not", "true;", "and", "if", "ye", "shall", "ask", "with", "a", "sincere", "heart,", "with", "real", "intent,", "having", "faith", "in", "Christ,", "he", "will", "manifest", "the", "truth", "of", "it", "unto", "you,", "by", "the", "power", "of", "the", "Holy", "Ghost" };
    private List<int> numberline = new List<int> {
97, 3, 72, 25, 48, 89, 70, 56, 8, 11, 64, 49, 36, 67, 24, 92, 16, 79, 20, 41, 
6, 32, 73, 15, 58, 46, 101, 113, 118, 85, 14, 75, 44, 105, 55, 109, 100, 30, 37, 
4, 81, 112, 60, 68, 7, 23, 99, 119, 28, 110, 63, 93, 12, 90, 50, 115, 83, 95, 
87, 19, 33, 59, 77, 2, 86, 21, 76, 66, 27, 80, 38, 91, 17, 98, 31, 45, 74, 
34, 114, 26, 57, 40, 22, 78, 5, 103, 65, 35, 18, 102, 10, 29, 82, 47, 69, 13, 
84, 52, 53, 116, 61, 88, 39, 96, 51, 62, 9, 107, 54, 71, 94, 111, 42, 108, 43,
120, 1, 104, 121, 0, 117, 106};

    private int count = 0;
    public void Hidewords()
    {
        var rnd = new Random();
        if(count < 122)
        words[numberline[count]].Ishidden(false);
        //words[rnd.Next(0, words.Count())].Ishidden(false);
        //var rndindex = rnd.Next(0, words.Count());
        //var h = words[rndindex].displaystring();
        //String newword = new String('_', h.Length);
        //words[rndindex] = new Word(newword);
        count++;
        
    }

    public void AddWords()
    {
        foreach(string script in Moroni)
        {
            var addingword = new Word(script);
            words.Add(addingword);
        }
    }
   
    

    public void DisplayScripture(Reference newrf)
    {
        Console.Write(newrf.Displayrefference());
        foreach(Word word in words)
        {
            Console.Write($" {word.displaystring()}");
            
        }
        Console.WriteLine();
    }
}
