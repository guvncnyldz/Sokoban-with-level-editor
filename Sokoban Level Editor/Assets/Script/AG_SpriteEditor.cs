using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AG_SpriteEditor : MonoBehaviour
{

	public static AG_SpriteEditor Instance;


	[Header("Game Asset")] 
	public Sprite sp_playerSpawnPoint;

	public Sprite sp_null;
	public Sprite sp_boxSpawnPoint;
	public Sprite sp_box;
	public Sprite sp_player;
	public Sprite sp_wall;
	void Start ()
	{
		Instance = this;
	}
	
}
