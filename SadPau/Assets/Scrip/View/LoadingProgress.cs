using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingProgress : MonoBehaviour
{
    public Transform loadingBarImage;
    public Text txt_score;
    public Text txt_coin;
    public float TargetAmount = 100.0f;
    public float CurrentAmount = 0.0f;
    private SaveManager saveManager;
    public float Speed = 20;
    public bool load = true;

    void Start()
    {
        CurrentAmount = 0.0f;
        saveManager = SaveManager.instance;
    }

    // Update is called once per frame
    void Update()
    {

        if (load)
        {
            StartCoroutine(Progress(Speed));
        }

    }


    public IEnumerator Progress(float Speeds)
    {
        load = false;
        CurrentAmount = 0.0f;

        while (CurrentAmount < TargetAmount)
        {
            CurrentAmount += Speeds * Time.deltaTime;
            loadingBarImage.GetComponent<Image>().fillAmount = (float)CurrentAmount / 100.0f;

            // Debug.Log(""+CurrentAmount);
            yield return new WaitForSeconds(.01f);
        }

        if (saveManager.currentLevel == 0)
        {
            saveManager.StayLevel_0();
            SceneManager.LoadScene("Start");
            saveManager.SetScore_0();
            saveManager.SetCoin_0();
        }

        else if (saveManager.currentLevel == 1)
        {
            saveManager.StayLevel_0();
            SceneManager.LoadScene("Start");
            saveManager.SetScore_0();
            saveManager.SetCoin_0();
        }



        yield return null;
    }






    public IEnumerator Calculater()
    {
        int coin = saveManager.GetSaveCoin();
        int score = saveManager.GetSaveScore();

        if (0.0 <CurrentAmount && CurrentAmount <= 16.0f)
        {
            for (int i = 1; i < 6; i++)
            {
                coin = coin + 1;
                txt_coin.text = coin + "";
                score = score + (1 * 2);
                txt_score.text = score + "";
                yield return new WaitForSeconds(.1f);

               // Debug.Log("OOOOOOOOOOOOOO:" + 1);
            }

        }


        if (16.0f < CurrentAmount && CurrentAmount <= 50.0f)
        {

            for (int i = 1; i < 4; i++)
            {
                coin = coin + 1;
                txt_coin.text = coin + "";
                score = score + (1 * 2);
                txt_score.text = score + "";

                yield return new WaitForSeconds(.1f);
               // Debug.Log("OOOOOOOOOOOOOO:" + 2);
            }

        }


        if (50.0f <CurrentAmount && CurrentAmount <= 90.0f)
        {

            for (int i = 1; i < 3; i++)
            {
                coin = coin + 1;
                txt_coin.text = coin + "";
                score = score + (1 * 2);
                txt_score.text = score + "";

                yield return new WaitForSeconds(.1f);
              //  Debug.Log("OOOOOOOOOOOOOO:" + 3);
            }

        }

        saveManager.SetScore(score);
        saveManager.SetCoinPluse(coin);

    }


    

}    
   
