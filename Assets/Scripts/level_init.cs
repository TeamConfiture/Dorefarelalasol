using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_init : MonoBehaviour
{
    public static level_init instance = null ;

    // Player character prefeb
    public GameObject character ;

    // Player character
    private GameObject player ;

    //Parent of player character possible position 
    public Transform zones ;

    //array of player character possible position initialized with the parent
    public Transform[] zonesTab ;

    public int currentIndex;


    void Awake()
    {
        if(instance == null){
            instance = this;
        }else if(instance != this){
            //instance = this;          //if need to overwrite previous values
            Destroy(gameObject);        //if need to keep previous values               (no notable differences between the two choices so far)
        }
    }

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

            player = Instantiate(character);

            currentIndex = zonesTab.Length/2;

            player.transform.position = zonesTab[currentIndex].position;           //Player character position set at the middle position (odd number)

            Debug.Log("correctly executed");
            Debug.Log(currentIndex);
        }else{
            Debug.Log("Char and/or zones not specified");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            ResetLevel();
        }
        //Debug.Log(Time.time);
    }

    public void ResetLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(zones.gameObject.scene.name);
        
    }

    


}
