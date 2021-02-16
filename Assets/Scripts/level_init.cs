using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_init : MonoBehaviour
{
    // Player character
    public GameObject character ;

    //Parent of player character possible position 
    public Transform zones ;

    //array of player character possible position initialized with the parent
    public Transform[] zonesTab ;

    // Start is called before the first frame update
    void Start()
    {
        //SAN check
        if (character != null && zones != null)
        {
            zonesTab = new Transform[zones.childCount];                                 ///////////////////////////
            for (int i = 0; i < zones.childCount; i++)                                  //
            {                                                                           //Array initialisation
                zonesTab[i] = zones.GetChild(i);                                        //
            }                                                                           ///////////////////////////

            GameObject player = Instantiate(character);

            player.transform.position = zonesTab[zonesTab.Length/2].position;           //Player character position set at the middle position (odd number)

            Debug.Log("correctly executed");
        }else{
            Debug.Log("Char and/or zones not specified");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
