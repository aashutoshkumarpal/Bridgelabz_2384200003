using System;
using System.Collections.Generic;

namespace ObjectModeling
{
    public class Patient
    {
        public string Name { get; }
        private List<Doctor> consultedDoctors;

        public Patient(string name)
        {
            Name = name;
            consultedDoctors = new List<Doctor>();
        }

        public void AddDoctor(Doctor doctor)
        {
            if (!consultedDoctors.Contains(doctor))
            {
                consultedDoctors.Add(doctor);
            }
        }

        public void DisplayConsultedDoctors()
        {
            Console.WriteLine($"\nPatient: {Name}");
            if (consultedDoctors.Count == 0)
            {
                Console.WriteLine("   No consultations yet.");
            }
            else
            {
                foreach (var doctor in consultedDoctors)
                {
                    Console.WriteLine($"   Consulted with: Dr. {doctor.Name} ({doctor.Specialization})");
                }
            }
        }
    }

    public class Doctor
    {
        public string Name { get; }
        public string Specialization { get; }
        private List<Patient> patients;

        public Doctor(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
            patients = new List<Patient>();
        }

        public void Consult(Patient patient)
        {
            if (!patients.Contains(patient))
            {
                patients.Add(patient);
                patient.AddDoctor(this);
            }
            Console.WriteLine($"Dr. {Name} ({Specialization}) is consulting Patient {patient.Name}.");
        }

        public void DisplayPatients()
        {
            Console.WriteLine($"\nDr. {Name} ({Specialization})");
            if (patients.Count == 0)
            {
                Console.WriteLine("   No patients yet.");
            }
            else
            {
                foreach (var patient in patients)
                {
                    Console.WriteLine($"   Patient: {patient.Name}");
                }
            }
        }
    }

    public class Hospital
    {
        public string HospitalName { get; }
        private List<Doctor> doctors;
        private List<Patient> patients;

        public Hospital(string hospitalName)
        {
            HospitalName = hospitalName;
            doctors = new List<Doctor>();
            patients = new List<Patient>();
        }

        public void AddDoctor(Doctor doctor)
        {
            if (!doctors.Contains(doctor))
            {
                doctors.Add(doctor);
            }
        }

        public void AddPatient(Patient patient)
        {
            if (!patients.Contains(patient))
            {
                patients.Add(patient);
            }
        }

        public void DisplayHospitalInfo()
        {
            Console.WriteLine($"\nHospital: {HospitalName}");

            Console.WriteLine("\nDoctors:");
            if (doctors.Count == 0)
            {
                Console.WriteLine("   No doctors available.");
            }
            else
            {
                foreach (var doctor in doctors)
                {
                    doctor.DisplayPatients();
                }
            }

            Console.WriteLine("\nPatients:");
            if (patients.Count == 0)
            {
                Console.WriteLine("   No patients admitted.");
            }
            else
            {
                foreach (var patient in patients)
                {
                    patient.DisplayConsultedDoctors();
                }
            }
        }
    }

    public class HospitalDemo
    {
        public void InputMethod()
        {
            // Creating a hospital
            Hospital myHospital = new Hospital("City Hospital");

            // Creating doctors
            Doctor docSmith = new Doctor("Smith", "Cardiologist");
            Doctor docJones = new Doctor("Jones", "Neurologist");

            // Creating patients
            Patient patientAlice = new Patient("Alice");
            Patient patientBob = new Patient("Bob");

            // Adding doctors to hospital
            myHospital.AddDoctor(docSmith);
            myHospital.AddDoctor(docJones);

            // Adding patients to hospital
            myHospital.AddPatient(patientAlice);
            myHospital.AddPatient(patientBob);

            // Consultations (Association)
            docSmith.Consult(patientAlice);
            docJones.Consult(patientAlice);
            docSmith.Consult(patientBob);

            // Displaying hospital information
            myHospital.DisplayHospitalInfo();
        }
    }
}
