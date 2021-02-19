using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLvl : MonoBehaviour
{
    private bool _hasEntered = false;
    private GameObject[] _playersTab;
    [SerializeField] private float speed = 1;
    private Vector3 _startingPos;
    float startTime;
    float animationCompleteness;

    private GameObject _targetedPlayer; 
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        startTime = Time.time;
        _playersTab = GameObject.FindGameObjectsWithTag("Player");
    }
    private void Update() 
    {
        if(_targetedPlayer != null && _hasEntered == false)
        {
            Vector3 velocity = (this.transform.position - _targetedPlayer.transform.position) * speed;
            //Vector3 velocity = Vector3.zero;
           _targetedPlayer.transform.position = Vector3.SmoothDamp (_targetedPlayer.transform.position, this.transform.position, ref velocity,1.0f);
           if (Vector3.Equals(this.transform.position,_targetedPlayer.transform.position ))
           {
               Debug.Log("L'oiseau est dans le nid");
               _hasEntered = true;
           }
        }

    }
///<sumary>atribute a plyer to door so that the animation of player getting thrue the door can begin</summary>
///<param name="player"> 1 for sol (P1) 2 for fa (P2) 0 for none (nothing will happen) </param>
    public void setPlayer(GameObject player)
    {
         _targetedPlayer = player;
         _startingPos =  _targetedPlayer.transform.position;
    }
    public bool getHasEntered() { return _hasEntered; }
    // Start is called before the first frame update
    private GameObject getPlayerWithName(string name)
    {
        foreach (GameObject i in _playersTab)
        {
            if ( i.name == name)
            {
                return i;
            }
            else
            {

            }
        }
        return null;
    }
}
