// See https://aka.ms/new-console-template for more information

using OOPConsoleApp.DesignAndBuildClass;
using OOPConsoleApp.WorkWithMethods;

// 1. reverse array
// ReverseArray.Main();

// 2. Fibonacci
// Fibonacci.Get(10);

// OOP design and build class:
// 1. demonstrate 4 principle:


// 2. Abstraction
Instructor instructor = new Instructor();
Student student = new Student(1, "Sue", "123@ucr.edu", "99223394984");
instructor.Perform();
student.Perform();

Intern intern = new Intern();
FullTimeEmployee fte = new FullTimeEmployee();
Employee e = new FullTimeEmployee();
intern.GetInfo();
fte.GetInfo();
e.GetInfo();

// 3. Encapsulation: use access modifier like private to achieve data hiding

// 4. Inheritance: where both undergradStudent and GradStudent were inherited from Student class
UndergradStudent undergradStudent = new UndergradStudent(2, "Charlie", "charlie@gmail.com", "9928843989");
GradStudent gradStudent = new GradStudent(3, "David", "david@ucla.edu", "78327889");
undergradStudent.CheckGrades();
gradStudent.CheckGrades();

// 5. polymorphism: in the example of abstraction, we override the abstract methods GetInfo() in the derived class
Console.WriteLine(Addition.AddNumbers(1,2,3,4));