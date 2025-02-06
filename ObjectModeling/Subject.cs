using System;
using System.Collections.Generic;

namespace ObjectModeling
{
    public class Subject
    {
        public string SubjectName { get; }
        private List<Learner> enrolledLearners;

        public Subject(string subjectName)
        {
            SubjectName = subjectName;
            enrolledLearners = new List<Learner>();
        }

        public void EnrollLearner(Learner learner)
        {
            if (!enrolledLearners.Contains(learner))
            {
                enrolledLearners.Add(learner);
                learner.AddSubject(this);
            }
        }

        public void DisplayEnrolledLearners()
        {
            Console.WriteLine($"\nSubject: {SubjectName}");
            if (enrolledLearners.Count == 0)
            {
                Console.WriteLine("   No learners enrolled.");
            }
            else
            {
                foreach (var learner in enrolledLearners)
                {
                    Console.WriteLine($"   Learner: {learner.Name}");
                }
            }
        }
    }

    public class Learner
    {
        public string Name { get; }
        private List<Subject> subjects;

        public Learner(string name)
        {
            Name = name;
            subjects = new List<Subject>();
        }

        public void AddSubject(Subject subject)
        {
            if (!subjects.Contains(subject))
            {
                subjects.Add(subject);
            }
        }

        public void DisplayEnrolledSubjects()
        {
            Console.WriteLine($"\nLearner: {Name}");
            if (subjects.Count == 0)
            {
                Console.WriteLine("   Not enrolled in any subjects.");
            }
            else
            {
                foreach (var subject in subjects)
                {
                    Console.WriteLine($"   Subject: {subject.SubjectName}");
                }
            }
        }
    }

    public class Institution
    {
        public string InstitutionName { get; }
        private List<Learner> learners;

        public Institution(string institutionName)
        {
            InstitutionName = institutionName;
            learners = new List<Learner>();
        }

        public void AddLearner(Learner learner)
        {
            if (!learners.Contains(learner))
            {
                learners.Add(learner);
            }
        }

        public void DisplayLearners()
        {
            Console.WriteLine($"\nInstitution: {InstitutionName}");
            if (learners.Count == 0)
            {
                Console.WriteLine("No learners enrolled.");
            }
            else
            {
                foreach (var learner in learners)
                {
                    Console.WriteLine($"   Learner: {learner.Name}");
                }
            }
        }
    }

    public class InstitutionDemo
    {
        public void InputMethod()
        {
            // Creating institution
            Institution myInstitution = new Institution("Greenwood High");

            // Creating learners
            Learner learner1 = new Learner("Alice");
            Learner learner2 = new Learner("Bob");

            // Adding learners to institution (Aggregation)
            myInstitution.AddLearner(learner1);
            myInstitution.AddLearner(learner2);

            // Creating subjects
            Subject math = new Subject("Mathematics");
            Subject science = new Subject("Science");
            Subject history = new Subject("History");

            // Learners enrolling in subjects (Association)
            math.EnrollLearner(learner1);
            science.EnrollLearner(learner1);
            history.EnrollLearner(learner2);
            science.EnrollLearner(learner2);

            // Displaying institution learners
            myInstitution.DisplayLearners();

            // Displaying learner subjects
            learner1.DisplayEnrolledSubjects();
            learner2.DisplayEnrolledSubjects();

            // Displaying enrolled learners in subjects
            math.DisplayEnrolledLearners();
            science.DisplayEnrolledLearners();
            history.DisplayEnrolledLearners();
        }
    }
}

