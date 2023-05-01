public class Job
{
    public string _companyName = "";
    public string _jobName = "";
    public int _startYear = 0;
    public int _endYear = 0;
    
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobName} ({_companyName}) {_startYear}-{_endYear}");
    }
}