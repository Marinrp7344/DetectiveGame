using UnityEngine;
using System.Collections.Generic;
public class TranscriptMenu : MonoBehaviour
{
    public static TranscriptMenu Instance;
    public List<CharacterConversation> characters;
    public CharacterConversation chosenCharacter;


    private void Start()
    {
        Instance = this;    
    }

    public void SelectCharacter()
    {
    }

    public void UpdateDropdownMenu()
    {

    }

    public void UnselectCharacters()
    {

    }
}

[System.Serializable]
public class CharacterConversation
{
    public Character.CharacterType character;
    public int characterID;
    public List<Conversations> Conversations = new List<Conversations>();
    public bool hadConversation;
}


[System.Serializable]
public class Conversations
{
    public List<ConversationLines> lines = new List<ConversationLines>();
    public string conversationName;
    public bool unlocked;
}


[System.Serializable]
public class ConversationLines
{
    public Character.CharacterType spokenByCharacter;
    public Character.CharacterType informationRelatedToCharacter;
    public bool incriminating;
    public InformationData information;
    public InformationData.InformationType infoType;
    public string line;
}

