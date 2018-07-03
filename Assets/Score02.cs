using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score02 : MonoBehaviour {

    public Text scoreText;

    private int score;

    // Use this for initialization
    void Start () {

        Initialize();

    }

// Update is called once per frame
void Update () {

        scoreText.text = score.ToString();

    }

    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;

        // ハイスコアを取得する。保存されてなければ0を取得する。
        //score = PlayerPrefs.GetInt(score, 0);
    }

    public void AddPoint(int point)
    {
        score = score + point;
    }
}
