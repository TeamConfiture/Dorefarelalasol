using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsDescription : MonoBehaviour
{

    private static int dT = 526;
    private static int sdT = 1;

    /**
     * Description of the level 1.
     * Each line is a note.
     * The first column correspond to the note (ex: 0 is re/fa#, 1 is fa#/la...) (from 0 to 50).
     * The second column correspond to the the landing column (from 0 to 7).
     * The third column correspond to the delta of time before the next note in milliseconds (from 0 to 999).
     */
    public static int[][] level1 = new int[][] {
        new int[] { 0, 2, sdT }, new int[] { 9, 2, dT - sdT },
        new int[] { 1, 2, dT },
        new int[] { 2, 2, dT },
        new int[] { 1, 2, dT },
        new int[] { 0, 2, dT },
        new int[] { 4, 2, sdT }, new int[] { 10, 6, dT - sdT },
        new int[] { 4, 2, sdT }, new int[] { 10, 6, dT - sdT },
        new int[] { 4, 2, sdT }, new int[] { 10, 6, dT - sdT },

        new int[] { 5, 2, dT },
        new int[] { 4, 2, sdT }, new int[] { 9, 6, dT - sdT },
        new int[] { 0, 2, dT },
        new int[] { 1, 2, dT },
        new int[] { 2, 2, dT },
        new int[] { 1, 2, dT },
        new int[] { 0, 2, dT },
        new int[] { 6, 2, sdT }, new int[] { 10, 6, dT - sdT },
        new int[] { 7, 2, sdT }, new int[] { 12, 6, dT - sdT },
        new int[] { 8, 2, sdT }, new int[] { 13, 6, dT - sdT },

        new int[] { 14, 2, sdT }, new int[] { 25, 6, dT - sdT },
        new int[] { 4, 2, sdT }, new int[] { 26, 6, dT - sdT },
        new int[] { 15, 2, dT },
        new int[] { 4, 2, sdT }, new int[] { 27, 6, dT - sdT },
        new int[] { 14, 2, sdT }, new int[] { 28, 6, dT - sdT },
        new int[] { 4, 2, sdT }, new int[] { 26, 6, dT - sdT },
        new int[] { 16, 2, sdT }, new int[] { 12, 6, dT - sdT },
        new int[] { 15, 2, sdT }, new int[] { 13, 6, dT - sdT },
        new int[] { 18, 2, dT },
        new int[] { 17, 2, sdT }, new int[] { 29, 6, dT - sdT },
        new int[] { 17, 2, sdT }, new int[] { 29, 6, dT - sdT },
        new int[] { 17, 2, sdT }, new int[] { 29, 6, dT - sdT },

        new int[] { 17, 2, dT },
        new int[] { 17, 2, dT },
        new int[] { 17, 2, dT },

        new int[] { 19, 2, dT },
        new int[] { 3, 2, dT },
        new int[] { 20, 2, dT },
        new int[] { 1, 2, dT },
        new int[] { 2, 2, dT },
        new int[] { 1, 2, sdT }, new int[] { 9, 6, dT - sdT },
        new int[] { 0, 2, sdT }, new int[] { 30, 6, dT - sdT },

        new int[] { 21, 2, dT },
        new int[] { 21, 2, dT },
        new int[] { 21, 2, dT },

        new int[] { 22, 2, sdT }, new int[] { 31, 6, dT - sdT },
        new int[] { 22, 2, sdT }, new int[] { 31, 6, dT - sdT },
        new int[] { 22, 2, sdT }, new int[] { 31, 6, dT - sdT },

                                 new int[] { 32, 6, dT },
        new int[] { 1, 2, dT },
        new int[] { 2, 2, dT },
        new int[] { 1, 2, sdT }, new int[] { 9, 6, dT - sdT },
        new int[] { 0, 2, sdT }, new int[] { 32, 6, dT - sdT },

        new int[] { 23, 2, dT },
        new int[] { 24, 2, dT },


    };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
