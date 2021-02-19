using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_init : MonoBehaviour
{
    public static level_init instance = null ;

    // Player1 character prefeb on left
    public GameObject characterSol ;

    // Player2 character prefeb on right
    public GameObject characterFa ;

    // Player1 character
    public GameObject player1 ;

    // Player2 character
    public GameObject player2 ;

    //Parent of player1 character possible position 
    public Transform zonesP1 ;

    //Parent of player2 character possible position 
    public Transform zonesP2 ;

    //array of player1 character possible position initialized with the parent  (just realized the arrays are useless)
    public Transform[] zonesTab1 ;

    //array of player2 character possible position initialized with the parent
    public Transform[] zonesTab2 ;

    public int currentIndexP1;

    public int currentIndexP2;

    public TextMesh scoreboard ;

    public int score ;

    public int pointNeeded;


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
        if (characterSol != null && characterFa != null && zonesP1 != null && zonesP2 != null)
        {
            zonesTab1 = new Transform[zonesP1.childCount];                              ///////////////////////////
            for (int i = 0; i < zonesP1.childCount; i++)                                //
            {                                                                           //Array1 initialisation
                zonesTab1[i] = zonesP1.GetChild(i);                                     //
            }                                                                           ///////////////////////////

            zonesTab2 = new Transform[zonesP2.childCount];                              ///////////////////////////
            for (int i = 0; i < zonesP2.childCount; i++)                                //
            {                                                                           //Array2 initialisation
                zonesTab2[i] = zonesP2.GetChild(i);                                     //
            }                                                                           ///////////////////////////

            player1 = Instantiate(characterSol);
            player2 = Instantiate(characterFa);

            currentIndexP1 = zonesTab1.Length/2;
            currentIndexP2 = zonesTab2.Length/2;

            player1.transform.position = zonesTab1[currentIndexP1].position;           //Player1 character position set at the middle position (odd number)
            player2.transform.position = zonesTab2[currentIndexP2].position;           //Player2 character position set at the middle position (odd number)

            Debug.Log("correctly executed");
        }else{
            Debug.Log("Char and/or zones not specified");
        }

        ScoreReset();
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
        UnityEngine.SceneManagement.SceneManager.LoadScene(zonesP1.gameObject.scene.name);
        
    }

    public void ScoreUpdate(){
        score++;
        scoreboard.text =score+"/"+pointNeeded;

    }

    public void ScoreReset(){
        score = 0;
        scoreboard.text =score+"/"+pointNeeded;

    }


}
