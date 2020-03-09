using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedFlapToRestart : MonoBehaviour
{
    public GameObject FlapToRestart;
    public float  delay =1f;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Invoke("EnableFlapToRestart", delay);
    }

    // Update is called once per frame
    void EnableFlapToRestart()
    {
        FlapToRestart.SetActive(true);
    }
}
