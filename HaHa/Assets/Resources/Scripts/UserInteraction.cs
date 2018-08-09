using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction{
    Front,
    Left,
    Right,
    Back
}
public class UserInteraction : MonoBehaviour {

    /*这个类是用来封装各个玩家对角色的操纵的
     * 
     */
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Move(Direction.Left);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Move(Direction.Right);
        }
	}
    private void Move(Direction direction)
    {//操作玩家进行移动
        
    }
    private void Attack()
    {

    }
}
