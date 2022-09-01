using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
   
    //AudioSourceコンポーネントを入れる
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //AudioSourceコンポーネント取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != "UnityChan")
        {
            audioSource.Play();
        }
        
    }
}
