using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indestructable : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
 
}
