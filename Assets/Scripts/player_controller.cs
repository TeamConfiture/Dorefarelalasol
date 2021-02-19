using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public bool hasEntered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasEntered)
        {
            if(this.gameObject == level_init.instance.player1 && (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.A))){
                MoveLeft1();
            }
            if(this.gameObject == level_init.instance.player1 && Input.GetKeyDown(KeyCode.D)){
                MoveRight1();
            }

            if(this.gameObject == level_init.instance.player2 && Input.GetKeyDown(KeyCode.LeftArrow)){
                MoveLeft2();
            }
            if(this.gameObject == level_init.instance.player2 && Input.GetKeyDown(KeyCode.RightArrow)){
                MoveRight2();
            }
        }
    }

    void MoveLeft1(){

        if(level_init.instance.currentIndexP1 > 0){
            level_init.instance.currentIndexP1--;
            level_init.instance.player1.transform.position = level_init.instance.zonesTab1[level_init.instance.currentIndexP1].position;
        }else{
            Debug.Log("P1 Can't go further left");
        }
    }

    void MoveRight1(){

        if(level_init.instance.currentIndexP1 < level_init.instance.zonesTab1.Length-1){
            level_init.instance.currentIndexP1++;
            level_init.instance.player1.transform.position = level_init.instance.zonesTab1[level_init.instance.currentIndexP1].position;
        }else{
            Debug.Log("P1 Can't go further right");
        }
    }

    void MoveLeft2(){

        if(level_init.instance.currentIndexP2 > 0){
            level_init.instance.currentIndexP2--;
            level_init.instance.player2.transform.position = level_init.instance.zonesTab2[level_init.instance.currentIndexP2].position;
        }else{
            Debug.Log("P2 Can't go further left");
        }
    }

    void MoveRight2(){

        if(level_init.instance.currentIndexP2 < level_init.instance.zonesTab2.Length-1){
            level_init.instance.currentIndexP2++;
            level_init.instance.player2.transform.position = level_init.instance.zonesTab2[level_init.instance.currentIndexP2].position;
        }else{
            Debug.Log("P2 Can't go further right");
        }
    }
}
