using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[Serializable]
public class Root 
{
    public List<Pau> Pau;

    public List<Pau> Pau1
    {
        get => Pau;
        set => Pau = value;
    }
}

