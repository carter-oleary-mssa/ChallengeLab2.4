class Student
{
    public string StudentId { get; set; }
    public string StudentName { get; set; }
    public int[] Marks { get; set; }

    public Student(string studentId, string studentName, int[] marks)
    {
        StudentId = studentId;
        StudentName = studentName;
        Marks = marks;
    }

    public int TotalMarks()
    {
        int sum = 0;
        foreach(int i in Marks)
        {
            sum += i;
        }
        return sum;
    }

    public decimal GetPercentage()
    {
        return Convert.ToDecimal(TotalMarks() / Marks.Length);
    }

    public string GetDivision()
    {
        string s = GetPercentage() switch {
            >= 70 => "First",
            >= 60 => "Second, Upper",
            >= 50 => "Second, Lower",
                _ => "Third"
        };
        return s;
    }
}

