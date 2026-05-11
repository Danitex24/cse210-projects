using System;

class Program
{
    static void Main(string[] args)
    {
        // let me create first job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Danovate Solutions Ltd";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // let me create second job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "BYU Idaho";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // let me create resume
        Resume myResume = new Resume();
        myResume._name = "Daniel Abughdyer";

        // let me add jobs to resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // let me display resume
        myResume.Display();
    }
}