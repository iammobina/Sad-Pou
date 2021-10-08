using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScen : MonoBehaviour
{
  
    private SaveManager saveManager;

    void Start()
    {

        saveManager = SaveManager.instance;
      


    }

        public void LoadLevel(string scene)
    {
        SceneManager.LoadScene(scene);

    }


    public void Puse(string scene)
    {
        saveManager.StayLevel_0();
        SceneManager.LoadScene(scene);

    }




}
