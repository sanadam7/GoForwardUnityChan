using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour
{
   
    //AudioSource�R���|�[�l���g������
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //AudioSource�R���|�[�l���g�擾
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
