using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    private const string _OverallLevel = "overallLevel";
    public int currentLevel=0;
    private const string _COIN = "COIN";
    private const string _Score= "Score";
    public int coins;
    public int scores;
    private void Awake()
    {
        instance = this;
        GetSaveData();
        GetSaveCoin();
        GetSaveScore();

       // Debug.Log("saveManager   c :" + currentLevel);
    }

    public int GetSaveData()
    {
        return currentLevel = PlayerPrefs.GetInt(_OverallLevel, currentLevel);
    }
    public int UnNextLevel()
    {
        currentLevel = GetSaveData();
        currentLevel++;
        PlayerPrefs.SetInt(_OverallLevel, currentLevel);
       // Debug.Log("saveManager   UnNextLevel :" + currentLevel);
        return currentLevel;
    }
 

    public int StayLevel_0()
    {
        currentLevel = 0;
        PlayerPrefs.SetInt(_OverallLevel, currentLevel);
       // Debug.Log("saveManager   UnStayLevel :" + currentLevel);


        return currentLevel;
    }


    public int GetSaveCoin()
    {
        return coins = PlayerPrefs.GetInt(_COIN, coins);
    }

    public void SetCoinPluse(int coin)
    {

        PlayerPrefs.SetInt(_COIN, coin);
        Debug.Log("coin save Pluse:" + coins);

    }


    public void SetCoin_0()
    {

        PlayerPrefs.SetInt(_COIN, 0);
        Debug.Log("coin save Pluse:" + coins);

    }


    public int GetSaveScore()
    {
        return coins = PlayerPrefs.GetInt(_Score, scores);
    }

    public void SetScore(int score)
    {
        

        PlayerPrefs.SetInt(_Score, score);
        Debug.Log("_Score Pluse:" + scores);

    }


    public void SetScore_0()
    {


        PlayerPrefs.SetInt(_Score, 0);
        Debug.Log("_Score Pluse:" + scores);

    }

}
