using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sauron : MonoBehaviour
{
    public float X;
    public Transform Tower;
    public Transform player;
    private float TowerX;

    //public GameObject player = null;
    // Start is called before the first frame update
    void Start()
    {
        TowerX = Tower.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        X = 40.7f + player.transform.position.x;

        Tower.transform.position = new Vector3(X, 41, 0);
    }
}
