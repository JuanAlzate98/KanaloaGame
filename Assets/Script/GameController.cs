using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject GameOverText;
    public bool Gameover;
    public float scrollSpeed = -1.5f;
    private int Score;
    public Text ScoreText;
    // Start is called before the first frame update


    private void Awake()
    {
        
        if (GameController.instance ==null )  
        {
            GameController.instance = this;
        }else if(GameController.instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("GameController ha sido instanciado por segunda vez,esto no deberia pasar");
        }
    }


  
   public void TorScore()
    {
        if (Gameover) return;
        Score++;
        ScoreText.text = "Score : " + Score;
        SoundSystem.instance.PlayScore();
    }

    // Update is called once per frame
    
    public void TorDie()
    {
        GameOverText.SetActive(true);
        Gameover = true;
    }
    private void OnDestroy()
    {
        if(GameController.instance ==this)
        {
            GameController.instance = null;
        }
    }

}
