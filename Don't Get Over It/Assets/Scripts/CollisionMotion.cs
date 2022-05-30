using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CollisionMotion : MonoBehaviour
{
    public Rigidbody2D RB;
    public bool isGrounded;
    public Animator Anim;
    public Transform Player;
    public float scale, X, Y;
    public bool Rdirection;
    public bool Ldirection, flipped = false;
    public const float Dmass = 8.0f, Rmass = 2.0f, NDmass = -8.0f, NRmass = -2.0f;
    public bool var = false;
    public GameObject player;
    public GameObject tool;

    public Rigidbody2D selectedObject;
    Vector3 offset;
    Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        Rdirection = true;
        Time.timeScale = 1;
        GameObject player = GameObject.FindWithTag("Player");
        GameObject tool = GameObject.FindWithTag("Tool");
    } // Update is called once per frame
    void Update()
    {
        faceMouse();
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        X = Player.transform.position.x;
        Y = Player.transform.position.y;
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Collision"))
        {
           Vector2 direction = new Vector2(1,1);
           RB.AddForce(direction * 100);

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
    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);

        transform.up = direction;

       
        
    }
    void FixedUpdate()
    {

        //if (tool.rotation.z > 180)
        //    tool.rotation.z = -180;
        //else if (tool.rotation.z < -180)
        //    tool.rotation.z = 180;

        //if (tool.rotation.z > 0)
        //{
        //    tool.flipx = true;
        //}
        //else
        //{
        //    tool.flipx = false;
        //}
        //if (selectedObject)
        //{
        //    offset = selectedObject.transform.position - mousePosition;
        //    selectedObject.MovePosition(mousePosition + offset);
        //}
        //Vector2 offset = new Vector2(mousePosition.x - transform.position.x,
        //  mousePosition.y - transform.position.y);
        //transform.Translate(transform.up * Time.deltaTime);
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        Vector3 Worldpos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 Worldpos2D = new Vector2(Worldpos.x, Worldpos.y);
        transform.up = Worldpos;
    }

}
    