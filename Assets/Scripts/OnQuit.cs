using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnQuit : MonoBehaviour
{
    public void QuiteGame()
    {
        Debug.Log("QUIT");//writes to console if QuiteGame runs correctly
        Application.Quit();
    }
}
