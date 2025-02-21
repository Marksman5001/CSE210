class MathAssignemnt : Assignment{

    private string _TextbookSection;
    private string _problems;

    public MathAssignemnt(){
        _TextbookSection="none";
        _problems="none";
    }
    public MathAssignemnt(string studentname, string topic, string textbooksection, string problems)
        : base(studentname, topic)
    {
        
        _TextbookSection=textbooksection;
        _problems=problems;
    }
    public string GetHomeworkList(){
        return $"{_TextbookSection}; {_problems}";
    }
} 