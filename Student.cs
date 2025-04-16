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
        switch (GetPercentage())
        {
            case decimal d when (d >= 70):
                return "First";
                break;
            case decimal d when (d >= 60):
                return "Second, Upper";
                break;
            case decimal d when (d >= 50):
                return "Second, Lower";
                break;
            default:
                return "Third";
                break;

        }
    }
}

