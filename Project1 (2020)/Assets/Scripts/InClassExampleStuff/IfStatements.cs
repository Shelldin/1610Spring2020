
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 10,
        b = 4,
        c = 14;

    public string password = "OU812";

    public bool canRun = true;

    void Start()
    {
        if (a + b == c)
        {
          print("that is true");  
        }

        if (password == "OU812")
       
        {
            print("that is the correct password.");
        }

        if (canRun)
        {
            print("we can run");
        }
    }

    void Update()
    {
        
    }
}
