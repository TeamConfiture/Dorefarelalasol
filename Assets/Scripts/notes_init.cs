using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes_init : MonoBehaviour
{

    public GameObject notes ;

    public GameObject zones1 ;

    public GameObject zones2 ;

    public Vector3 yOffset = new Vector3(0.0f,6.0f,0.0f);

    public float timeKeeper;

    public float deltaSpawn = 4.0f;

    private bool doorSpawned;

    public float noteSpeed = 1.0f;

    //Line to read from the tab
    private int noteLine = 0; 

    public float doorWaitTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        timeKeeper = Time.time;
        doorSpawned= false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeKeeper + deltaSpawn){
            
            if (!doorSpawned)
            {
                if (noteLine < LevelsDescription.level1.Length)
                {
                    Debug.Log("Time since beginning: "+Time.time);
                    timeKeeper = Time.time;
                    GenerateNoteFromTab();
                }else{
                    GenerateDoor();
                }




                /*
                if(level_init.instance.score < level_init.instance.pointNeeded){
                    timeKeeper = Time.time;
                    GenerateNote(RandomGenIndex(),RandomGenPosition());
                }else{
                    GenerateDoor();
                }
                */
            }
        }
    }

    int RandomGenIndex(){

        return Random.Range(0,notes.transform.childCount);

    }

    int RandomGenPosition(){

        return Random.Range(0,zones1.transform.childCount+zones2.transform.childCount-1);

    }

    GameObject GenerateNote(int childIndex, int positionIndex){
        GameObject spawnLine ;
        if(positionIndex < zones1.transform.childCount){
            spawnLine = zones1.transform.GetChild(positionIndex).gameObject;
        }else{
            spawnLine = zones2.transform.GetChild(positionIndex-zones1.transform.childCount).gameObject;
        }

        Vector3 spawnPosition = spawnLine.transform.position;

        GameObject note = Instantiate(notes.transform.GetChild(childIndex).gameObject,spawnPosition += yOffset,Quaternion.identity);

        note.GetComponent<NoteBehaviour>().goal = spawnLine;
        note.GetComponent<NoteBehaviour>().speed = noteSpeed;
        note.tag = "Note";


        return note;
    }

    GameObject GenerateNoteFromTab(){
        //Debug.Log("Note id: "+LevelsDescription.level1[noteLine][0]);
        int noteIndex = LevelsDescription.level1[noteLine][0];
        int position = LevelsDescription.level1[noteLine][1];

        if (noteLine < LevelsDescription.level1.Length-1)
        {
            deltaSpawn = LevelsDescription.level1[noteLine][2]/1000.0f*noteSpeed;
        }else
        {
            deltaSpawn = doorWaitTime;
        }

        noteLine++;
        return GenerateNote(noteIndex,position);
    }

    void GenerateDoor(){
        Vector3 position1 = new Vector3(-4.0f,0.0f,0.0f);
        Vector3 position2 = new Vector3(4.0f,0.0f,0.0f);

        Instantiate(notes,position1,Quaternion.identity);
        Instantiate(notes,position2,Quaternion.identity);
        doorSpawned = true;
    }
}