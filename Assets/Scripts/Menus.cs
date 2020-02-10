using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    Dropdown dropDownMenu;
    public Text stuff;

    public void Start()
    {
        dropDownMenu = GetComponent<Dropdown>();
        //dropDownMenu.onValueChanged.AddListener(delegate {
        //    DropdownValueChanged(dropDownMenu);
        //});

    }

    // Update is called once per frame
    void Update()
    {
        //This method quits the game.
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
    //This method also quits the game.
    static void QuitGame()
    {
        Debug.Log("Quiting the app.");
        Application.Quit();
    }

}
