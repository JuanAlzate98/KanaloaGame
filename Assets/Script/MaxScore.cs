using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{

    public Text textRecord;
    public int scoreMax;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.Gameover == true && GameController.instance.Score >= PlayerPrefs.GetInt("MaxScore"))
        {
            PlayerPrefs.SetInt("MaxScore", GameController.instance.Score);
        }

        if (GameController.instance.Score >= 1)
            textRecord.text = PlayerPrefs.GetInt("MaxScore").ToString();

    }

}
