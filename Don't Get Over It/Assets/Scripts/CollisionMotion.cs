using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CollisionMotion : MonoBehaviour
{
    public Rigidbody2D RB;
    //public bool isGrounded;
    //public Animator Anim;
    public Transform Self;
    public float scale, X, Y;
    public GameObject player;
    public GameObject arm;
    public GameObject tool;

    public Rigidbody2D selectedObject;
    Vector3 offset;
    Vector3 mousePosition;


    // Start is called before the first frame update
    void Start()
    {
        //RB = GetComponent<Rigidbody2D>();
        //Anim = GetComponent<Animator>();
        Time.timeScale = 1;
        GameObject player = GameObject.FindWithTag("Player");
        GameObject arm = GameObject.FindWithTag("Arm");
        GameObject tool = GameObject.FindWithTag("Tool");
    } // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Q))
        //{
        //    Vector2 direction = new Vector2(
        //    mousePosition.x,
        //    mousePosition.y);
        //    RB.AddForce(direction * 1000);
        //    player.position.y = direction;
        //}
        //faceMouse();
        //if (isGrounded == true && Input.GetKey(KeyCode.Q))
        //{
        //    isGrounded = false;
        //    if (flipped == false)
        //    {
        //        RB.gravityScale = NRmass;
        //        flipped = true;
        //    }
        //    if (flipped == true)
        //    {
        //        RB.gravityScale = Rmass;
        //        flipped = false;
        //    }
        //}
        //else if (flipped == false)
        //{
        //    RB.gravityScale = Rmass;
        //}
        //else if (flipped == true)
        //{
        //    RB.gravityScale = NRmass;
        //}

    }
    void OnCollisionExit2D(Collision2D collision)
    {
        X = Self.transform.position.x;
        Y = Self.transform.position.y;
        float angle = Mathf.Atan2(X, Y) * Mathf.Rad2Deg;
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Collision")/*&& Input.GetMouseButtonDown(0)*/)
        {
            Vector2 rotationzdirection = new Vector2(X,Y);
            if (angle > 0)
            {
                Vector2 direction = new Vector2(angle / 20, angle/10);
                RB.AddForce(direction / 10, ForceMode2D.Impulse);

            }
            else if (angle < 0)
            {
                Vector2 direction = new Vector2(-angle / 20, angle/10);
                RB.AddForce(direction / 10, ForceMode2D.Impulse);

            }
            else
            {
                Debug.Log("Hi");
            }
        }

    }
    //    else
    //    {
    //        isGrounded = false;
    //    }
    //    if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Wall"))
    //    { 
    //        isGrounded = true;
    //    }

    //}
    //void faceMouse()
    //{
    //    Vector3 mousePosition = Input.mousePosition;
    //    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

    //    Vector2 direction = new Vector2(
    //        mousePosition.x - transform.position.x,
    //        mousePosition.y - transform.position.y);

    //    transform.up = direction;



    //}
    void FixedUpdate()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x,
            mousePosition.y);

      
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotationz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationz);

        arm.transform.localRotation = Quaternion.Euler(mousePosition.x, mousePosition.y, rotationz);
        

    }
}
    