using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISfxManager : MonoBehaviour
{
    public AudioClip click;
    public AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        //AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playClickSound()
    {
        AS.clip = click;
        AS.Play();
    }
}
