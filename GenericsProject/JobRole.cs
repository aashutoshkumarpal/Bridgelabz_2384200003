using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    // Step 1: Define an Abstract Class for Job Roles
    abstract class JobRole
    {
        public string JobTitle { get; set; }
        public string RequiredSkills { get; set; }

        public JobRole(string jobTitle, string requiredSkills)
        {
            JobTitle = jobTitle;
            RequiredSkills = requiredSkills;
        }

        public abstract void DisplayJobDetails();
    }

    // Step 2: Implement Concrete Job Role Classes (e.g., SoftwareEngineer, DataScientist)
    class SoftwareEngineer : JobRole
    {
        public string ProgrammingLanguages { get; set; }

        public SoftwareEngineer(string jobTitle, string requiredSkills, string programmingLanguages)
            : base(jobTitle, requiredSkills)
        {
            ProgrammingLanguages = programmingLanguages;
        }

        public override void DisplayJobDetails()
        {
            Console.WriteLine($"Job Title: {JobTitle}");
            Console.WriteLine($"Required Skills: {RequiredSkills}");
            Console.WriteLine($"Programming Languages: {ProgrammingLanguages}");
        }
    }

    class DataScientist : JobRole
    {
        public string Tools { get; set; }

        public DataScientist(string jobTitle, string requiredSkills, string tools)
            : base(jobTitle, requiredSkills)
        {
            Tools = tools;
        }

        public override void DisplayJobDetails()
        {
            Console.WriteLine($"Job Title: {JobTitle}");
            Console.WriteLine($"Required Skills: {RequiredSkills}");
            Console.WriteLine($"Tools: {Tools}");
        }
    }

    // Step 3: Generic Class for Resume Processing
    class Resume<T> where T : JobRole
    {
        private List<T> resumes = new List<T>();

        // Generic Method to Add a Resume
        public void AddResume(T resume)
        {
            resumes.Add(resume);
        }

        // Generic Method to Display Resumes
        public void DisplayResumes()
        {
            foreach (var resume in resumes)
            {
                resume.DisplayJobDetails();
                Console.WriteLine();
            }
        }

        // Generic Method to Validate and Process Resumes Dynamically
        public static T ProcessResume(string jobTitle, string requiredSkills, string additionalInfo)
        {
            // Dynamically create a resume based on job role
            if (typeof(T) == typeof(SoftwareEngineer))
            {
                return (T)(object)new SoftwareEngineer(jobTitle, requiredSkills, additionalInfo);
            }
            else if (typeof(T) == typeof(DataScientist))
            {
                return (T)(object)new DataScientist(jobTitle, requiredSkills, additionalInfo);
            }
            else
            {
                throw new InvalidOperationException("Invalid job role.");
            }
        }
    }

    // Step 4: Main Program to Run the Resume Screening System
    class Program7
    {
        static void Main()
        {
            // Process and add resumes for different job roles

            // Software Engineer Resume
            Resume<SoftwareEngineer> softwareEngineerResumes = new Resume<SoftwareEngineer>();
            SoftwareEngineer softwareEngineerResume = Resume<SoftwareEngineer>.ProcessResume("Software Engineer", "C#, .NET", "C#, JavaScript");
            softwareEngineerResumes.AddResume(softwareEngineerResume);

            // Data Scientist Resume
            Resume<DataScientist> dataScientistResumes = new Resume<DataScientist>();
            DataScientist dataScientistResume = Resume<DataScientist>.ProcessResume("Data Scientist", "Machine Learning, Python", "TensorFlow, Pandas");
            dataScientistResumes.AddResume(dataScientistResume);

            // Display the resumes
            Console.WriteLine("Software Engineer Resumes:");
            softwareEngineerResumes.DisplayResumes();

            Console.WriteLine("Data Scientist Resumes:");
            dataScientistResumes.DisplayResumes();
        }

    }
}