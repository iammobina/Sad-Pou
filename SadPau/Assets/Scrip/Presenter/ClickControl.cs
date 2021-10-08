using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class ClickControl : MonoBehaviour
{
    public GameObject gme;
    public bool active = false;
    private SaveManager saveManager;
    public Image Myimg;
    public Sprite img_sad;
    public Sprite img_happy;
    public int Myrotate;
    public string Mystate="happy";
    public bool Myisclickeable;
    public string id;
    public LoadingProgress lodingProgress;
    public ObjectManager objmanager;

    void Start()
    {
      
        saveManager = SaveManager.instance;


        SetingObj();

    }
    void Update()
    {
        
    }


    public void ClickObj()
    {

        if (!Myisclickeable)
        {
            return;
        }

        StartCoroutine(lodingProgress.Calculater());
        saveManager.UnNextLevel();
        StartCoroutine(lodingProgress.Progress(15));
        objmanager.LoadNewItem();
        

        if (saveManager.currentLevel >= 2)
        {
            saveManager.StayLevel_0();
            StartCoroutine(Waite());
        }

        if (saveManager.currentLevel >= 3)
        {
            
            saveManager.SetScore_0();
            saveManager.SetCoin_0();
         
        }

    }



    public void SetingObj()
    {
        
        gameObject.SetActive(active);
        gameObject.transform.Rotate(0f, 0f, Myrotate);

        if (Mystate == "sad")
        {
            Myimg.sprite = img_sad;
        }
        else if (Mystate == "happy")
        {
            Myimg.sprite = img_happy;
        }
    }





    private IEnumerator Waite()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(.1f);
        }


        SceneManager.LoadScene("Start");
    }


}
