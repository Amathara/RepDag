namespace opgavesæt;

public class PassedOrNot
{
    private char grade;

    public PassedOrNot(char grade)
    {
        this.grade = grade;
    }

    public bool hasPassed()
    {
        char[] arr = { 'A', 'B', 'C', 'D', 'F' };
        int indexGradeToPass = Array.IndexOf(arr, 'C');
        
        return Array.IndexOf(arr, grade) <= indexGradeToPass;
    }
}