using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Potatos LLC";
        job1._jobtitle = "Potato Farmer";
        job1._startyear = 2025;
        job1._endyear = 2050;
        Job job2 = new Job();
        job2._company = "CornCorp";
        job2._jobtitle = "Corn Farmer";
        job2._startyear = 2020;
        job2._endyear = 2024;
        Resume resume1 = new Resume();
        resume1._name = "Mr. Fredrickson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.display();
    }
}