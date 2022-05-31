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
        //if (Y < -3)
        //{
        //    transform.position = new Vector3(X, -3, -10);
        //}
        //if (X<0)
        //{
        //    transform.position = new Vector3(0, Y, -10);
        //}
        //else
        //{
            transform.position = new Vector3(X, Y, -10);
        //}
    }
}