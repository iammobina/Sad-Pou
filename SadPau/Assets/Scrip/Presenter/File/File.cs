using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class File : MonoBehaviour
{

    public static File instance = null;
    private Root root;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);


        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }

    }


    void Start()
    {
        TextAsset SourceFileSpeak = (TextAsset)Resources.Load<TextAsset>("Pau.json");
        string root_file = SourceFileSpeak.text;
        root = JsonUtility.FromJson<Root>(root_file);
       // Debug.Log("file" + root.Pau1[1].ObjPau.Count);
    }



    public Root root1
    {
        get => root;
        set => root = value;
    }



    void Update()
    {
        
    }
}
