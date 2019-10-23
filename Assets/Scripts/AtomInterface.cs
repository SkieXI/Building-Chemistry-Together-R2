using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface AtomInterface
{
    //An array for storing new objects created in the Factory Pattern.
    GameObject FactoryMethod(object[] parameters);


}
