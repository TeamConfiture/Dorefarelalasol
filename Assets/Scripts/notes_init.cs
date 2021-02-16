﻿using System.Collections;
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
            if(level_init.instance.score < level_init.instance.pointNeeded && !doorSpawned){
                timeKeeper = Time.time;
                GenerateNote(RandomGenIndex(),RandomGenPosition());
            }else{
                GenerateDoor();
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
        Vector3 spawnLine;
        if(positionIndex < 3){
            spawnLine = zones1.transform.GetChild(positionIndex).position;
        }else{
            spawnLine = zones2.transform.GetChild(positionIndex-3).position;
        }

        return Instantiate(notes.transform.GetChild(childIndex).gameObject,spawnLine += yOffset,Quaternion.identity);
    }

    void GenerateDoor(){
        Vector3 position1 = new Vector3(-4.0f,0.0f,0.0f);
        Vector3 position2 = new Vector3(4.0f,0.0f,0.0f);

        Instantiate(notes,position1,Quaternion.identity);
        Instantiate(notes,position2,Quaternion.identity);
    }
}