using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/* Class used to save the game's current state for later.
 * Turtorial: https://www.youtube.com/watch?v=SNwPq01yHds | 14:57
 * SaveDialogBox: https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-save-files-using-the-savefiledialog-component
 * LoadDialogBox: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=netframework-4.8
 * Joe Leon
 * 2-27-20
 */

public class GameSaveManager : MonoBehaviour
{
    public static GameSaveManager instance;

    public MoluculeData Molucule;

    public AtomHolder atom;

    /*
    void Awake()
    {
        if (instance = null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Debug.Log("Wrong data! Removing data.");
            Destroy(this);

        }
        else
        {
            
            DontDestroyOnLoad(this);
        }
    }
    */
    public bool IsSaveFile()
    {
        //Checks to see if the directory already exist.
        return Directory.Exists(Application.persistentDataPath + "/SaveData");
    }

    public void SaveGame()
    {
        //If a savedata directory doesn't exist, then it will create a new folder.
        if (!IsSaveFile())
        {
            Debug.Log("Creating new folder in " + Application.persistentDataPath);
            Directory.CreateDirectory(Application.persistentDataPath + "/SaveData");
        }

        Debug.Log("Save folder located at: " + Application.persistentDataPath);
        //BinaryFormatter is used to 
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/SaveData/BCTSAVE.BCT");
        var Json = JsonUtility.ToJson(Molucule);
        file.Close();
    }

    public AtomHolder LoadGame()
    {
        string path = Application.persistentDataPath + "/SaveData/BCTSAVE.BCT";

        if (File.Exists(path))
        {
            BinaryFormatter form = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            AtomHolder atom = form.Deserialize(stream) as AtomHolder;
            stream.Close();

            return atom;
        }
        else
        {
            Debug.Log("File not found!");
            return null;
        }
    }
}
