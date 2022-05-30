using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CamLock : MonoBehaviour
{
    public float X, Y;
    public Camera CAM;
    //public GameObject player = null;
    public Transform player;
    public float yValue;

    // Start is called before the first frame update
    void Start()
    {
        CAM = GetComponent<Camera>();
        //player = GameObject.Find(Player);
    }



    // Update is called once per frame
    void Update()
    {
        X = player.transform.position.x;
        Y = player.transform.position.y;
    
        transform.position = new Vector3(X, Y, -10);
   
    }
}