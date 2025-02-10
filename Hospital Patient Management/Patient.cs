using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Patient_Management
{
    // Abstract class Patient
    abstract class Patient
    {
        private string patientId;
        private string name;
        private int age;
        private string diagnosis;
        private List<string> medicalHistory; // Encapsulation: Protects medical history

        public string PatientId
        {
            get { return patientId; }
            private set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        protected Patient(string patientId, string name, int age, string diagnosis)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
            this.diagnosis = diagnosis;
            this.medicalHistory = new List<string>();
        }

        public abstract double CalculateBill(); // Abstract method

        public virtual void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID: {patientId}, Name: {name}, Age: {age}, Diagnosis: {diagnosis}");
        }

        protected void AddToMedicalHistory(string record)
        {
            medicalHistory.Add(record);
        }

        protected void ViewMedicalHistory()
        {
            Console.WriteLine($"Medical History of {name}:");
            foreach (var record in medicalHistory)
            {
                Console.WriteLine($"- {record}");
            }
        }
    }

    // Interface IMedicalRecord
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    // InPatient subclass (Fixed charge + per-day charge)
    class InPatient : Patient, IMedicalRecord
    {
        private int numberOfDays;
        private double dailyCharge = 2000; // Fixed charge per day
        private double roomCharge = 5000;  // Room rent

        public InPatient(string patientId, string name, int age, string diagnosis, int numberOfDays)
            : base(patientId, name, age, diagnosis)
        {
            this.numberOfDays = numberOfDays;
        }

        public override double CalculateBill()
        {
            return (dailyCharge * numberOfDays) + roomCharge;
        }

        public void AddRecord(string record)
        {
            AddToMedicalHistory(record);
        }

        public void ViewRecords()
        {
            ViewMedicalHistory();
        }
    }

    // OutPatient subclass (Fixed consultation fee)
    class OutPatient : Patient, IMedicalRecord
    {
        private double consultationFee = 1000;

        public OutPatient(string patientId, string name, int age, string diagnosis)
            : base(patientId, name, age, diagnosis)
        {
        }

        public override double CalculateBill()
        {
            return consultationFee;
        }

        public void AddRecord(string record)
        {
            AddToMedicalHistory(record);
        }

        public void ViewRecords()
        {
            ViewMedicalHistory();
        }
    }

}
