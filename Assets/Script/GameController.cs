using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject GameOverText;
    public bool Gameover;
    public float scrollSpeed = -1.8f;
    public float[] incrementScroll = new float[5] { -0.1f, 2.0f, -2.1f, -2.2f, -2.3f };
    //public float scrollSpeedIncrement = -0.2f;
    public float maxScrollSpeed = -10f;
    public int Score = 0;
    public Text ScoreText;
    

    public object NotificationCenter { get; private set; }

    // Start is called before the first frame update


    private void Awake()
    {

        if (GameController.instance == null)
        {
            GameController.instance = this;
        } else if (GameController.instance != this)
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
        //if(Score >=2)
        //{
        //    ScrollingObject.AccederScroll.Rb2D.velocity = new Vector2(incrementScroll[0],0); ;
        //}
        SoundSystem.instance.PlayScore();
    }

    
    
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
