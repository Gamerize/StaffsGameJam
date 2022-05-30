using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sauron : MonoBehaviour
{
    public float X;
    public Camera CAM;
    public Transform player;
    //public GameObject player = null;
    // Start is called before the first frame update
    void Start()
    {
        CAM = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        X = player.transform.position.x;

        transform.position = new Vector3(X, 0, -10);
    }
}
