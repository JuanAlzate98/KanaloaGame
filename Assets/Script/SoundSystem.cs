using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem instance;
  
    public AudioSource audioSourceScore;
    public AudioSource audioSourceSwiming;
    public AudioSource audioSourceDie;
    // Start is called before the first frame update

    private void Awake()
    {
        if(SoundSystem.instance == null)
        {
            SoundSystem.instance = this;
        }else if(SoundSystem.instance !=this)
        {
            Destroy(gameObject);
        }
       
    }
    public void PlayScore()
    {
        audioSourceScore.Play();
    }
    public void PlayDie()
    {
        audioSourceDie.Play();
       
    }
    public void PlaySwiming()
    {
        audioSourceSwiming.Play();
        
    }

   

    private void OnDestroy()
    {
        if (SoundSystem.instance ==this)
        {
            SoundSystem.instance = null;
        }
    }
}
