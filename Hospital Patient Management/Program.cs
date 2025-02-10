using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Patient_Management
{
    internal class Program
    {
        static void ProcessPatients(List<Patient> patients)
        {
            foreach (var patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine($"Total Bill: {patient.CalculateBill()}\n");

                if (patient is IMedicalRecord medicalRecord)
                {
                    medicalRecord.AddRecord("Routine Checkup Completed.");
                    medicalRecord.ViewRecords();
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            List<Patient> patients = new List<Patient>
        {
            new InPatient("P001", "Alice", 45, "Pneumonia", 5),
            new OutPatient("P002", "Bob", 30, "Fever")
        };

            ProcessPatients(patients);
        }
    }
}
