using UnityEngine;
using System.Collections;

public class SignPost : ActionItem {

    public string[] SignDialogue;
    public string SignName;
    public override void Interact()
    {
        DialogueSystem.Instance.AddNewDialogue(SignDialogue, SignName);
        Debug.Log("Interacting with sign post");
    }
}
