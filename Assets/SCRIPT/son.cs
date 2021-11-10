using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class son : MonoBehaviour
{
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().PlayOneShot(sound);
    }
}
