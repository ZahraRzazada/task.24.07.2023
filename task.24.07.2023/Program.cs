#region TASK2
using task._24._07._2023;

static void Check()
{
    int num1 = 34;
    int num2 = 45;
    int GivenNumber = 17;
    int result1 = num1 - GivenNumber;
    int result2 = num2 - GivenNumber;
    if (Math.Abs(result1) > Math.Abs(result2))
    {
        Console.WriteLine("Num2 17 ye daha yaxindir");
    }
    else
    {
        Console.WriteLine("Num1 17 ye daha yaxindir");
    }
}
Check();
#endregion

#region TASK2
Student student = new Student("Zahra", "Rzazada", "ENG-30",false,96);
student.Task3();
student.Task2();
student.Task4();



#endregion


