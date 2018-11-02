using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    private float speed = -0.2f;
    private float deadLine = -10;
    private AudioSource audioSource;
    public AudioClip block;

    

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.Translate(this.speed, 0, 0);
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="groundTag"||collision.gameObject.tag=="CubeTag")
        {



            audioSource.PlayOneShot(block);
        }
    }
}
