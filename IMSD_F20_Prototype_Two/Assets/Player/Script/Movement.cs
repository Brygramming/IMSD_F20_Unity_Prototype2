using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public CharacterController PlayerController;

	Vector3 PlayerMovement;
	public float PlayerX;
	public float PlayerZ;

    void Start()
    {
        PlayerController = GetComponent<CharacterController>();
        PlayerMovement = transform.right * PlayerX + transform.forward * PlayerZ;
    }

    void Update()
    {
    	if(Input.GetKey(KeyCode.W))
    	{
    		transform.position += PlayerMovement;
    		Debug.Log("Forward");
    	}
    	else if(Input.GetKey(KeyCode.S))
    	{
    		transform.position += -PlayerMovement;
    		Debug.Log("Backwards");
    	}
    	else if(Input.GetKey(KeyCode.D))
    	{
    		Debug.Log("Right");
    	}
    }
}
