using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class NoteBehaviour : MonoBehaviour
{

    public GameObject goal = null;

    public float speed =10.0f;

    AudioSource audioData;

    public Renderer rend;  // renderer variable

    public BoxCollider2D poly;

    private Vector3 delta;

    // Start is called before the first frame update
    void Start()
    {
        delta = new Vector3(0f,-3f,0f);
        if (goal == null)               //Used to prevent error form door spawn at the moment (commit 518afd5cefe7c79ec89f0c854c23438e2dc45f00)
        {
            Destroy(gameObject);
        }
        else
        {
            audioData = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {   

        this.transform.position = Vector3.MoveTowards(this.transform.position,goal.transform.position+delta,speed * Time.deltaTime);
        
        
    }

    IEnumerator DestroyLater()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag != "Note")
        {
            if (collision.tag != "Player")
            {
                Destroy(gameObject);
            }
            else
            {
                level_init.instance.ScoreUpdate();
                audioData.Play(0);

                //Debug.Log("Touched by player");

                rend = GetComponent<SpriteRenderer>(); // gets sprite renderer

                rend.enabled = false; // sets to false if hit.

                poly = GetComponent<BoxCollider2D>();

                poly.enabled = false;

                StartCoroutine(DestroyLater()); // destroy one the sound is played
            }
           
        }

    }
}

