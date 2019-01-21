using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

    bool game_pause = false;

	void Start ()
    {
	    	
	}

    int face_shape = 1;
    int face_bottom = 1;
    int eye = 1;
    int nose = 1;
    int hair = 1;
	
    public void ChangeFace()
    {
        
    }

	void Update ()
    {
		if(game_pause == false)
        {
            GameRun();
        }
	}

    private void GameRun()
    {
        GetGold();
    }

    private void GetGold()
    {

    }

}
