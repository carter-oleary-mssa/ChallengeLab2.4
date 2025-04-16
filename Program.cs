string rollNumber, name;

Console.Write("Input the Roll Number of the student: ");
rollNumber = Console.ReadLine();
Console.Write("Input the Name of the Student: ");
name = Console.ReadLine();
Console.Write("Input the marks of Physics, Chemistry, and Computer Application: ");
string[] temp = Console.ReadLine().Split(' ');
int[] marks = new int[temp.Length];
for (int i = 0; i < temp.Length; i++)
{
    marks[i] = int.Parse(temp[i]);
}

Student s = new(rollNumber, name, marks);


Console.WriteLine($"Roll No: {s.StudentId}");
Console.WriteLine($"Name of Student: {s.StudentName}");
Console.WriteLine($"Marks in Physics: {s.Marks[0]}");
Console.WriteLine($"Marks in Chemistry: {s.Marks[1]}");
Console.WriteLine($"Marks in Computer Application: {s.Marks[2]}");
Console.WriteLine($"Total Marks = {s.TotalMarks()}");
Console.WriteLine($"Percentage = {s.GetPercentage().ToString("f")}");
Console.WriteLine($"Division = {s.GetDivision()}");

