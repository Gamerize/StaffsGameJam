using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCheck : MonoBehaviour
{
    float xDist, yDist;
    public float X1, Y1, X2, Y2, X, Y, reduce;
    public Transform Hoe;
    public Transform Character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X1 = Hoe.transform.position.x;
        Y1 = Hoe.transform.position.y;
        X2 = Character.transform.position.x;
        Y2 = Character.transform.position.y;
        Y = Y1 - Y2;
        X = X1 - X2;
        if (((X*X) + (Y*Y)) > 0.2159)
        {
            reduce = Mathf.Sqrt((((X * X) + (Y * Y)) - 0.2159f) / 2);
            if (X >= 0)
            {
                if (Y >= 0)
                    transform.position = new Vector3(X, Y, 0);
                else
                    transform.position = new Vector3(X, -Y, 0);
            }
                
            else
            {
                if (Y >= 0)
                    transform.position = new Vector3(-X, Y, 0);
                else
                    transform.position = new Vector3(-X, -Y, 0);
            }
        }
    }
}
