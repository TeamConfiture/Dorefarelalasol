using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
            MoveUp();
        }
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)){
            MoveDown();
        }
    }

    void MoveUp(){

        if(level_init.instance.currentIndex > 0){
            level_init.instance.currentIndex--;
            this.transform.position = level_init.instance.zonesTab[level_init.instance.currentIndex].position;
        }else{
            Debug.Log("Can' go up further");
        }
    }

    void MoveDown(){

        if(level_init.instance.currentIndex < level_init.instance.zonesTab.Length-1){
            level_init.instance.currentIndex++;
            this.transform.position = level_init.instance.zonesTab[level_init.instance.currentIndex].position;
        }else{
            Debug.Log("Can' go down further");
        }
    }
}
