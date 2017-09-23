using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

class PlayerSprites
{
	public SpriteRenderer Up;
	public SpriteRenderer Down;
	public SpriteRenderer Left;
	public SpriteRenderer Right;
}

public class FightingModeInput : MonoBehaviour
{

	PlayerSprites leftPlayerSprites;
	PlayerSprites rightPlayerSprites;
	// Use this for initialization
	void Start()
	{
		leftPlayerSprites = new PlayerSprites();
		rightPlayerSprites = new PlayerSprites();
		leftPlayerSprites.Up = transform.Find("LeftPlayer").transform.GetChild(0).GetComponent<SpriteRenderer>();
		leftPlayerSprites.Down = transform.Find("LeftPlayer").transform.GetChild(1).GetComponent<SpriteRenderer>();
		leftPlayerSprites.Left = transform.Find("LeftPlayer").transform.GetChild(2).GetComponent<SpriteRenderer>();
		leftPlayerSprites.Right = transform.Find("LeftPlayer").transform.GetChild(3).GetComponent<SpriteRenderer>();

		rightPlayerSprites.Up = transform.Find("RightPlayer").transform.GetChild(0).GetComponent<SpriteRenderer>();
		rightPlayerSprites.Down = transform.Find("RightPlayer").transform.GetChild(1).GetComponent<SpriteRenderer>();
		rightPlayerSprites.Left = transform.Find("RightPlayer").transform.GetChild(2).GetComponent<SpriteRenderer>();
		rightPlayerSprites.Right = transform.Find("RightPlayer").transform.GetChild(3).GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		leftPlayerSprites.Up.color = CrossPlatformInputManager.GetButton("B1") ? Color.red : Color.white;
		leftPlayerSprites.Down.color = CrossPlatformInputManager.GetButton("X1") ? Color.red : Color.white;
		leftPlayerSprites.Left.color = CrossPlatformInputManager.GetButton("A1") ? Color.red : Color.white;
		leftPlayerSprites.Right.color = CrossPlatformInputManager.GetButton("Y1") ? Color.red : Color.white;

		rightPlayerSprites.Up.color = CrossPlatformInputManager.GetButton("B2") ? Color.red : Color.white;
		rightPlayerSprites.Down.color = CrossPlatformInputManager.GetButton("X2") ? Color.red : Color.white;
		rightPlayerSprites.Left.color = CrossPlatformInputManager.GetButton("A2") ? Color.red : Color.white;
		rightPlayerSprites.Right.color = CrossPlatformInputManager.GetButton("Y2") ? Color.red : Color.white;
	}
}
