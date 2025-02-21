class WritingAssignment : Assignment{
    private string _title;

    public WritingAssignment(){
        _title="none";
    }

    public WritingAssignment(string studentname, string topic, string title)
    : base(studentname, topic)
    {
        _title=title;
    }

    public string GetWritingInfo(){
        return _title;
    }
}