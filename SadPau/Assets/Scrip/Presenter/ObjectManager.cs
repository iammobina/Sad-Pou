using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    private File file;
    private ClickControl[] clickControls;
    private SaveManager saveManager;
    
    void Start()
    {
        file = File.instance;
        saveManager = SaveManager.instance;
        clickControls = FindObjectsOfType<ClickControl>();

       // Debug.Log("clickControls" + clickControls.Length);

        SetActive();


    }

    public void SetActive()
    {
        

            for (int i = 0; i < file.root1.Pau[saveManager.currentLevel].ObjPau.Count; i++)
            {
                for (int j = 0; j < clickControls.Length; j++)
                {
                    if (file.root1.Pau[saveManager.currentLevel].ObjPau[i].id.Equals(clickControls[j].id))
                    {
                        clickControls[j].active = true;
                        clickControls[j].Mystate = (file.root1.Pau[saveManager.currentLevel].ObjPau[i].satate);
                        clickControls[j].Myrotate = (file.root1.Pau[saveManager.currentLevel].ObjPau[i].rotate);
                        clickControls[j].Myisclickeable = (file.root1.Pau[saveManager.currentLevel].ObjPau[i].isClick);

                       // Debug.Log("Fa  " + clickControls[j].Mystate);
                        //listClickcontrol.Add(clickControls[j]);
                    }
                }
            }

      


    }

   public void LoadNewItem()
    {

        if (saveManager.currentLevel == 1)
        {
            Debug.Log("saveManager.currentLevel " + saveManager.currentLevel);

            for (int i = 0; i < file.root1.Pau[saveManager.currentLevel].ObjPau.Count; i++)
            {
                for (int j = 0; j < clickControls.Length; j++)
                {
                    if (file.root1.Pau[saveManager.currentLevel].ObjPau[i].id.Equals(clickControls[j].id))
                    {
                        clickControls[j].active = true;
                        clickControls[j].Mystate = (file.root1.Pau[saveManager.currentLevel].ObjPau[i].satate);
                        clickControls[j].Myrotate = (file.root1.Pau[saveManager.currentLevel].ObjPau[i].rotate);
                        clickControls[j].Myisclickeable = (file.root1.Pau[saveManager.currentLevel].ObjPau[i].isClick);

                        clickControls[j].SetingObj();

                       // Debug.Log(" " + clickControls[j].Mystate);
                        //listClickcontrol.Add(clickControls[j]);
                    }
                }
            }


        }

    }




    void Update()
    {

    }
}
