using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    private bool m_TriggeredDialogue = true;
    [SerializeField] private int m_TalkNum; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && m_TriggeredDialogue)
        {
            m_TriggeredDialogue = false;
            FindObjectOfType<AudioManager>().playAudio("Talk " + m_TalkNum);
            Debug.Log("talk" + m_TalkNum);
        }
    }
}
