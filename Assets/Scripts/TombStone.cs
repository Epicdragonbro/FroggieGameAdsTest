using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombStone : MonoBehaviour
{

    public GameObject CustomFrog;
    public int currentscore, closesthighscore;
    public int[] Highscorelist;
    // Start is called before the first frame update
    void Start()
    {
        if (closesthighscore == 0) closesthighscore = int.MaxValue;
        
           
            for (int i = 0; i < Highscorelist.Length; i++)
            {
                if (Highscorelist[i] > currentscore && Highscorelist[i] < closesthighscore)
                {
                    closesthighscore = Highscorelist[i];
                }
            }
        
    }

    // Update is called once per frame
    void Update()
    {

        
       
        currentscore = GameObject.Find("LevelController").GetComponent<LevelController>().DistanceMoved;

    }
}
