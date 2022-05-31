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
    void OnCollisionEnter2D(Collision2D collision)
    {
        X = Self.transform.position.x;
        Y = Self.transform.position.y;
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Collision")/*&& Input.GetMouseButtonDown(0)*/)
        {
           Debug.Log(" test");
           //Vector2 direction = new Vector2(-Self.transform.position.x, 0);
           //RB.AddForce(direction * 100);
            
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

        //tool.transform.up = direction;

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
        //Vector3 mousePosition = Input.mousePosition;
        //mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        //Vector2 Worldpos2D = new Vector2(mousePosition.x, mousePosition.y);
        //arm.transform.up = Worldpos2D;
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotationz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationz);

        arm.transform.localRotation = Quaternion.Euler(mousePosition.x, mousePosition.y, rotationz);
        //tool.transform.localRotation = Quaternion.Euler(mousePosition.x, mousePosition.y, rotationz);

        //if (rotationz < -90 || rotationz > 90)
        //{
        //    if (arm.transform.eulerAngles.y == 0)
        //    {
        //        arm.transform.localRotation = Quaternion.Euler(180, 0, -rotationz);
        //    }
        //    else if (arm.transform.eulerAngles.y ==180)
        //    {
        //        arm.transform.localRotation = Quaternion.Euler(180, 180, -rotationz);
        //    }
        //}
        //if (rotationz < -90 || rotationz > 90)
        //{
        //    if (tool.transform.eulerAngles.y == 0)
        //    {
        //        tool.transform.localRotation = Quaternion.Euler(180, 0, -rotationz);
        //    }
        //    else if (tool.transform.eulerAngles.y == 180)
        //    {
        //        tool.transform.localRotation = Quaternion.Euler(180, 180, -rotationz);
        //    }
        //}

    }
}
    