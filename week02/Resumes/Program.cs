class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        resume._name = "Your Name";

        Job firstJob = new Job();
        firstJob._jobTitle = "Junior Data Analyst";
        firstJob._company = "Kalekt Analytics";
        firstJob._startYear = 2021;
        firstJob._endYear = 2024;
        resume._jobs.Add(firstJob);

        Job secondJob = new Job();
        secondJob._jobTitle = "Manager - Analytics";
        secondJob._company = "Kalekt Analytics";
        secondJob._startYear = 2024;
        secondJob._endYear = 2026;
        resume._jobs.Add(secondJob);

        resume.Display();
    }
}
