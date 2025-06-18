using UnityEngine;

public enum Tests
{
    Monday, //0
    Tuesday, //1
    Wednesday, 
    Thursday,
    Friday,
    Saturday,
    Sunday
}
public class Testing : MonoBehaviour
{
    Tests test = Tests.Friday;
           // data type   identifier/variable
    public byte Number1,Number2;
    public int result;
    public int number = 0;

    public bool condn1,condn2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)test);
    }

    // Update is called once per frame
    void Update()
    {
Remainder(4);
    }

    private void Add()
    {
       result =  Number1 + Number2;
       Debug.Log(result);
    }

    private void Remainder(int number)
    {
      result = Number1%number;
      Debug.Log(result);
    }
}


//Awake,OnEnable,Start,Update,OnTriggerEnter,OnCollisionEnter,OnDisable;
/* Links to Documentations


https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/

https://www.tutorialspoint.com/csharp/csharp_overview.htm
https://www.tutorialspoint.com/csharp/csharp_data_types.htm
https://www.tutorialspoint.com/csharp/csharp_variables.htm
https://www.tutorialspoint.com/csharp/csharp_basic_syntax.htm
https://www.tutorialspoint.com/csharp/csharp_arithmetic_operators.htm
https://www.tutorialspoint.com/csharp/csharp_assignment_operators.htm
https://www.tutorialspoint.com/csharp/csharp_relational_operators.htm
https://www.tutorialspoint.com/csharp/csharp_logical_operators.htm
https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm
https://www.tutorialspoint.com/csharp/csharp_decision_making.htm
https://www.tutorialspoint.com/csharp/csharp_loops.htm
*/