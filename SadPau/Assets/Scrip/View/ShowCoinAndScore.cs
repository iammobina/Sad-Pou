using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ShowCoinAndScore : MonoBehaviour
{
    public Text txt_score;
    public Text txt_coin;
    private SaveManager saveManager;
    public GameObject button;
    public AudioSource audioSourceSecen;


    void Start()
    {
        saveManager = SaveManager.instance;
        txt_score.text = saveManager.GetSaveScore() + "";
        txt_coin.text = saveManager.GetSaveCoin() + "";
        

        button.transform.DOMoveY(90, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
