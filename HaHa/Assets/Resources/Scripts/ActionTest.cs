using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTest : MonoBehaviour {
    public GameObject temp;
    public RhythmController te;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (te.GetCurrentState()==RhythmState.NotAwailable)
        {
            Time.timeScale = 0;
        }else
        {
            Time.timeScale = 1;
        }
        

	}
    void FixedUpdate()
    {
        //temp.
    }
}
