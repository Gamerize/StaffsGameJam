using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkTrigger : MonoBehaviour
{
    [SerializeField] private int m_TalkNum;
    private bool m_Talked = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && m_Talked == true)
        {
            FindObjectOfType<AudioManager>().playAudio("Talk " + m_TalkNum);
            m_Talked = false;
        }
    }
}
