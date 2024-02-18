class Scripture
{
    private List<Word> words;
    private List<string> Moroni  = new List<string> { "Behold", "I", "would", "exhort", "you", "that", "when", "ye", "shall", "read", "these", "things", "if", "it", "be", "wisdom", "in", "God", "that", "ye", "should", "read", "them,", "that", "ye", "would", "remember", "how", "merciful", "the", "Lord", "hath", "been", "unto", "the", "children", "of", "men,", "from", "the", "creation", "of", "Adam", "even", "down", "until", "the", "time", "that", "ye", "shall", "receive", "these", "things,", "and", "ponder", "it", "in", "your", "hearts.", "And", "when", "ye", "shall", "receive", "these", "things,", "I", "would", "exhort", "you", "that", "ye", "would", "ask", "God,", "the", "Eternal", "Father,", "in", "the", "name", "of", "Christ,", "if", "these", "things", "are", "not", "true;", "and", "if", "ye", "shall", "ask", "with", "a", "sincere", "heart,", "with", "real", "intent,", "having", "faith", "in", "Christ,", "he", "will", "manifest", "the", "truth", "of", "it", "unto", "you,", "by", "the", "power", "of", "the", "Holy", "Ghost" };

    public void Hidewords()
    {
        var rnd = new Random();

        for(int i = 0; i > 2; i++ )
        {
            words[rnd.Next(0, words.Count())].Ishidden(false);
        }
    }

    public void AddWords()
    {
        foreach(string script in Moroni)
        {
            var addingword = new Word(script);
            words.Add(addingword);
        }
    }

    public void DisplayScripture()
    {
        foreach(Word word in words)
        {
            Console.WriteLine(word.displaystring());
        }
    }
}
// I will have this done by next monday the 19th
