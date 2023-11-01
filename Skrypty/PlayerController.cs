using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public Rigidbody2D theRB;

    public float moveSpeed;
    private Vector2 moveInput;

    public Animator anim;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        theRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();


        //transform.position += new Vector3(moveInput.x * Time.deltaTime * moveSpeed, moveInput.y * Time.deltaTime * moveSpeed, 0f);

        theRB.velocity = moveInput * moveSpeed;

        if (moveInput.x !=0)
        {
            theRB.AddForce(new Vector2(moveInput.x * moveSpeed, 0f));
        }

        if (moveInput.x > 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        if (moveInput.x < 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        
        if(moveInput != Vector2.zero)
        {
            anim.SetBool("isMoving", true);
        } else
        {
            anim.SetBool("isMoving", false);
        }
    }
}
