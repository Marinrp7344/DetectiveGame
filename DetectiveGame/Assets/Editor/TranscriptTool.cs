using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEditor;
public class TranscriptTool : MonoBehaviour
{


    [MenuItem("Tools/Transcript/Link Conversations")]
    public static void LinkConversation()
    {
        DialogueDatabase dialougeManager = DialogueManager.instance.initialDatabase;
        TranscriptMenu transcriptMenu = FindAnyObjectByType<TranscriptMenu>();
        Debug.Log(transcriptMenu.gameObject.name);
        foreach (Conversation conversation in dialougeManager.conversations)
        {
            foreach(CharacterConversation character in transcriptMenu.characters)
            {
                if (conversation.dialogueEntries[0].ActorID == character.characterID)
                {
                    AddConversationLines(character, conversation);
                }
            }
            
        }
    }

    public static void AddConversationLines(CharacterConversation character, Conversation conversation)
    {
        Conversations newConvo = new Conversations();
        foreach(DialogueEntry entry in conversation.dialogueEntries)
        {
            ConversationLines newLine = new ConversationLines();
            newLine.line = entry.DialogueText;
            newConvo.lines.Add(newLine);
        }

        character.Conversations.Add(newConvo);
    }
}
