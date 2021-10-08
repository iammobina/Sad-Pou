using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Pau 
{
    public List<ObjPau> ObjPau;

    public int Level;

    public List<ObjPau> ObjPau1
    {
        get => ObjPau;
        set => ObjPau = value;
    }


    public int Level1
    {
        get => Level;
        set => Level = value;
    }


}
