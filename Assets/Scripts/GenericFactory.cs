using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    //This is a interface.
    [SerializeField]
    private T prefab;

    //This is designed to take a prefab and create new objects based on the Factory design Pattern.
    public T GetNewInstance()
    {
        //Makes a new instance of the prefab assigned to the script.
        return Instantiate(prefab);
    }

}
