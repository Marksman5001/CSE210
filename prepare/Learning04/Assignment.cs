class Assignment{
    private string _StudentName;
    private string _Topic;

    public Assignment(){
        _StudentName="None";
        _Topic="None";
    }
    public Assignment(string studentname, string topic){
        _StudentName=studentname;
        _Topic=topic;
    }
    public string GetSummary(){
        return $"{_StudentName}, {_Topic}";
    }
}