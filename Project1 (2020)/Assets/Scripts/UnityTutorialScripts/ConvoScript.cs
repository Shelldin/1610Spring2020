using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//from unity tutorial
public class ConvoScript : MonoBehaviour
{
    public int smartness = 5;

    private void Greet()
    {
        switch (smartness)
        {
            case 10:
                print("Guten Tag meine Damen und Herrn!");
                break;
            case 5:
                print("how do you do fellow kids?");
                break;
            case 0:
                print("I am a stegosaurus!");
                break;
            default:
                print("You're too stupid for a valid message");
                break;
        }
    }
}
