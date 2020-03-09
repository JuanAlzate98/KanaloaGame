using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D Rb2D;

    // Start is called before the first frame update

    private void Awake()
    {
        Rb2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Rb2D.velocity = new Vector2(GameController.instance.scrollSpeed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.instance.Gameover)
        {
            Rb2D.velocity = Vector2.zero;
        }
    }
}
