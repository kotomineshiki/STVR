﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerState
{
    Idle,
    Moving,
    Attacking
}
public class PlayerActionManager : MonoBehaviour {
    /*
     *这个类管理玩家的动作
     */
    public GameObject player;
    public float speed=2f;//玩家移动的速度
    public PlayerState playerState;
    public Vector3 towards;//要移动往的方向
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerState == PlayerState.Moving)
        {
            player.transform.position += towards * speed*Time.deltaTime;
            Debug.Log("正在移动");
        }
	}
    public void PlayerMove(Direction inputDirection)
    {
        if (inputDirection == Direction.Left)
        {
            towards = new Vector3(1, 0, 0);
        }
        if (inputDirection == Direction.Right)
        {
            towards = new Vector3(-1, 0, 0);
        }
        playerState = PlayerState.Moving;//切换到运动状态 
    }
    public void ForceStop()//停止当前玩家执行的一切活动
    {
        playerState = PlayerState.Idle;
    }
}
