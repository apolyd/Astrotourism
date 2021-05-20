using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagesHandler : MonoBehaviour
{
    public Text messageToDisplay;
    public virtual void DisplayGlobalMessage(string message)
    {
        StopAllCoroutines();
        StartCoroutine(TypeSentence(message));
        //messageCooldown = 5f;
    }

    IEnumerator TypeSentence(string sentence)
    {
        messageToDisplay.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            messageToDisplay.text += letter;
            yield return new WaitForFixedUpdate();
            //yield return new WaitForSeconds(1f);
        }
        //cooldownFlag = true;
    }
}
