using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ToQuit()
    {
        print("Saliendo de juego...");
        Application.Quit();
    }
    
}
