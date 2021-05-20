using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDMessages : MonoBehaviour
{
    public Text messageToDisplay;
    public float messageCooldown;
    public const float cooldown = 5f;
    public bool cooldownFlag, hasPanel;
    // Start is called before the first frame update
    void Start()
    {
        messageCooldown = cooldown;
        cooldownFlag = false;
        //DisplayGlobalMessage("HUD INITIALIZATION PROCESS SUPER TEST");
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownFlag)
        {
            messageCooldown -= Time.deltaTime;
            if(messageCooldown <= 0)
            {
                messageToDisplay.text = " ";
                //messageCooldown = cooldown;
                cooldownFlag = false;
            }
        }
    }

    public virtual void DisplayGlobalMessage(string message)
    {
        StopAllCoroutines();
        StartCoroutine(TypeSentence(message));
        messageCooldown = cooldown;
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
        cooldownFlag = true;
    }

}
