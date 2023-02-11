using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static Player GetPlayer()
    {
        return singleton;
    }

    private static Player singleton;

    void Awake()
    {
        singleton = this;
    }
}
