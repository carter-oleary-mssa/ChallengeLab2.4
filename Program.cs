string rollNumber, name;

Console.Write("Input the Roll Number of the student: ");
rollNumber = Console.ReadLine();
Console.Write("Input the Name of the Student: ");
name = Console.ReadLine();
Console.Write("Input the marks of Physics, Chemistry, and Computer Application: ");
string[] temp = Console.ReadLine().Split(' ');
int[] marks = new int[temp.Length];
int sum = 0;
for(int i  = 0; i < temp.Length; i++)
{
    marks[i] = int.Parse(temp[i]);
    sum += marks[i];
}

Console.WriteLine($"Roll No: {rollNumber}");
Console.WriteLine($"Name of Student: {name}");
Console.WriteLine($"Marks in Physics: {marks[0]}");
Console.WriteLine($"Marks in Chemistry: {marks[1]}");
Console.WriteLine($"Marks in Computer Application: {marks[2]}");
Console.WriteLine($"Total Marks = {sum}");
Console.WriteLine($"Percentage = {Convert.ToDecimal(sum/marks.Length).ToString("f")}");
Console.WriteLine("Division = First");

