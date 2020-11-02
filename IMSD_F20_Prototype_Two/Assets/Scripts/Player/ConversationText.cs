using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationText : MonoBehaviour
{
	//Text
	public Text InteractionText;
    public Text Conversation;
	public Text ChoiceOne;
	public Text ChoiceTwo;
	public Text ChoiceThree;

	//Conversations
	bool ConversationMode = false;

	//To stop player from moving
	CharacterController NoMove;
	Transform NoRotate;

	//Stages
	int[] ConversationStages = {1, 2, 3};
	int NextStage = 0;

    void Start()
    {
    	NoMove = GetComponent<CharacterController>();
    	NoRotate = GetComponent<Transform>();
        EmptyText();
    }

    void Update()
    {
    	if(Input.GetKeyDown(KeyCode.Q) && ConversationMode == true)
        {
        	Debug.Log("Conversation Mode Inactive");
            NoMove.enabled = true;
            //NoRotate.enabled = true;
            ConversationMode = false;
            EmptyText();
        }
        Choices();
    }

    //Gets Rid of Texts
    void EmptyText()
    {
        //Empty Texts
        InteractionText.text = "";
        Conversation.text = "";
        ChoiceOne.text = "";
        ChoiceTwo.text = "";
        ChoiceThree.text = "";
    }

    //Entering The Interaction
    void OnTriggerEnter(Collider FaceToFaceEnter)
	{
		if(FaceToFaceEnter.gameObject.tag == "Bully")
		{
			InteractionText.text = "Press E to interact";	
			ConversationMode = true;
		}
	}

	//Exiting The Interaction
	void OnTriggerExit(Collider FaceToFaceExit)
	{
        if(FaceToFaceExit.gameObject.tag == "Bully")
        {
        	Debug.Log("Conversation Mode Inactive");
        	ConversationMode = false;
        	InteractionText.text = "";
        }
	}

	//A Choice System
	void Choices()
	{

		//First Stage
		Debug.Log(ConversationStages[NextStage]);
		if(ConversationStages[NextStage] == 1 && ConversationMode == true && Input.GetKeyDown(KeyCode.E))
		{
			Debug.Log("Conversation Mode Active");
			NoMove.enabled = false;
			InteractionText.text = "Press Q to Exit";
			Conversation.text = "What is Life?";
        	ChoiceOne.text = "I don't know";
        	ChoiceTwo.text = "Your mom";
        	ChoiceThree.text = "Life is unfair";
    	} 
    	else if(ConversationStages[NextStage] == 2 && ConversationMode == true && Input.GetKeyDown(KeyCode.E))
    	{
    		Debug.Log("Conversation Mode Active");
			NoMove.enabled = false;
			InteractionText.text = "Press Q to Exit";
			Conversation.text = "";
        	ChoiceOne.text = "";
        	ChoiceTwo.text = "";
        	ChoiceThree.text = "";
    	}

		if(Input.GetKeyDown(KeyCode.Alpha1) && ConversationMode == true && ConversationStages[NextStage] == 1)
		{
			NoMove.enabled = true;
			EmptyText();
			NextStage += 1;
			ConversationMode = false;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha2) && ConversationMode == true && ConversationStages[NextStage] == 1)
		{
			NoMove.enabled = true;
			EmptyText();
			NextStage += 1;
			ConversationMode = false;
		}
		else if(Input.GetKeyDown(KeyCode.Alpha3) && ConversationMode == true && ConversationStages[NextStage] == 1)
		{
			NoMove.enabled = true;
			EmptyText();
			NextStage += 1;
			ConversationMode = false;
		}
	}
}
