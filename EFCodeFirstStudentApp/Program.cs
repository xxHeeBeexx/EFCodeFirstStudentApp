using System;
using System.Linq;

namespace EfCodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                Console.WriteLine("=== EF Code First CRUD Demo ===");

                // 1️⃣ ADD a student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrolledOn = DateTime.Now
                };
                db.Students.Add(student);
                db.SaveChanges();
                Console.WriteLine($"Added Student: {student.FirstName} {student.LastName}");

                // 2️⃣ LIST students after adding
                Console.WriteLine("\nStudents after adding:");
                foreach (var s in db.Students.ToList())
                {
                    Console.WriteLine($"{s.Id}: {s.FirstName} {s.LastName} - {s.EnrolledOn}");
                }

                // 3️⃣ UPDATE first student
                var firstStudent = db.Students.FirstOrDefault();
                if (firstStudent != null)
                {
                    firstStudent.LastName = "Smith";
                    db.SaveChanges();
                    Console.WriteLine($"\nUpdated Student ID {firstStudent.Id} LastName to {firstStudent.LastName}");
                }

                // 4️⃣ LIST students after update
                Console.WriteLine("\nStudents after update:");
                foreach (var s in db.Students.ToList())
                {
                    Console.WriteLine($"{s.Id}: {s.FirstName} {s.LastName} - {s.EnrolledOn}");
                }

                // 5️⃣ DELETE first student
                var studentToDelete = db.Students.FirstOrDefault();
                if (studentToDelete != null)
                {
                    db.Students.Remove(studentToDelete);
                    db.SaveChanges();
                    Console.WriteLine($"\nDeleted Student ID {studentToDelete.Id}");
                }

                // 6️⃣ LIST students after delete
                Console.WriteLine("\nStudents after delete:");
                var studentsLeft = db.Students.ToList();
                if (studentsLeft.Any())
                {
                    foreach (var s in studentsLeft)
                    {
                        Console.WriteLine($"{s.Id}: {s.FirstName} {s.LastName} - {s.EnrolledOn}");
                    }
                }
                else
                {
                    Console.WriteLine("No students in database.");
                }

                Console.WriteLine("\nDone. Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
