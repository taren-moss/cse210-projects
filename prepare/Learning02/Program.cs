using System;

class Program
{
    static void Main(string[] args)
    {
        // creating new data for a job at Microsoft
        Job microsoft = new Job();
        microsoft._jobName = "Software Engineer";
        microsoft._companyName = "Microsoft";
        microsoft._startYear = 2019;
        microsoft._endYear = 2022;

        // creating new data for a job at Apple
        Job apple = new Job();
        apple._jobName = "Manager";
        apple._companyName = "Apple";
        apple._startYear = 2022;
        apple._endYear = 2023;

        // creating new data for a resume using above data and a name
        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._jobs.Add(microsoft);
        myResume._jobs.Add(apple);

        // this displays the information
        myResume.DisplayResume();
    }
}