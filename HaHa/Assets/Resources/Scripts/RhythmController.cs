using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RhythmState
{
    Available,
    NearlyAvailable,
    NotAwailable
}
public class RhythmController : MonoBehaviour {
    /*这个类用来管理鼓点节奏
     *其他类会通过查询这个类的状态来判断当前处于什么状态：是否可以操作玩家
     * 
     */
    public GameObject sphere;
    public GameObject target;
    public RhythmState currentState;
    public float lastTime;
	// Use this for initialization
	void Start () {
   //     sphere.GetComponent<Rigidbody>().velocity = new Vector3(1,0,0);
        currentState = RhythmState.NotAwailable;
        lastTime = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
   //     Debug.Log("sdf");
        sphere.transform.position += (Time.realtimeSinceStartup-lastTime) * new Vector3(3, 0, 0);

        Vector3 delta = target.transform.position - sphere.transform.position;
        if (delta.magnitude < 2)
        {
            if (delta.magnitude < 1)
            {
                currentState = RhythmState.Available;
            }else 
                currentState = RhythmState.NearlyAvailable;

        }else
        {
            currentState = RhythmState.NotAwailable;
        }
        lastTime = Time.realtimeSinceStartup;

	}
    public RhythmState GetCurrentState()
    {
        return currentState;
    }
}
