using System.Diagnostics;

class Word
{
    private string word;
    
    public void Ishidden(bool show)
    {
        if(show == false)
        {
            word = word.Replace("a", "_").Replace("b", "_" ).Replace("c", "_" ).Replace("d", "_" ).Replace("e", "_" ).Replace("f", "_" ).Replace("g", "_" ).Replace("h", "_" ).Replace("i", "_" ).Replace("j", "_" ).Replace("k", "_" ).Replace("l", "_" ).Replace("m", "_" ).Replace("n", "_" ).Replace("o", "_" ).Replace("p", "_" ).Replace("q", "_" ).Replace("r", "_" ).Replace("s", "_" ).Replace("t", "_" ).Replace("u", "_" ).Replace("v", "_" ).Replace("w", "_" ).Replace("x", "_" ).Replace("y", "_" ).Replace("z", "_" ).Replace("A", "_" ).Replace("B", "_" ).Replace("C", "_" ).Replace("D", "_" ).Replace("E", "_" ).Replace("F", "_" ).Replace("G", "_" ).Replace("H", "_" ).Replace("I", "_" ).Replace("J", "_" ).Replace("K", "_" ).Replace("L", "_" ).Replace("M", "_" ).Replace("N", "_" ).Replace("O", "_" ).Replace("P", "_" ).Replace("Q", "_" ).Replace("R", "_" ).Replace("S", "_" ).Replace("T", "_" ).Replace("U", "_" ).Replace("V", "_" ).Replace("W", "_" ).Replace("X", "_" ).Replace("Y", "_" ).Replace("Z", "_" );
        }
    }
    public Word(string word)
    {
        this.word = word;
    }
    
    
    public string displaystring()
    {
        return word;
    }
}
