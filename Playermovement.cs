using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public int playerspeed = 10;
    private bool facingRight = false;
    public int playerjumpPower = 750;
    private float moveX;
    public Playermovement player;

    RaycastHit2D hitRay;
    private bool isTouchingGround;


    public Vector3 startposition;
   
    //  public GameManager theGameManager;

    // public Animator animator;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Playermove();

     

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag == "killbox")
    //    {
    //        theGameManager.RestartGame();
    //    }
    //}

    void Playermove()
    {
        if(player.transform.position.y  < 7.0)
        {
            print("HI");
            this.transform.position = startposition;
        }
        //controls
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        //Animations
        //player Direction
        if (moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerspeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
       // transform.position = startposition;

    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerjumpPower);
    }

    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {

            other.gameObject.SetActive(false);
            ScoreCounter.scoreValue += 1;
        }

        if(other.gameObject.CompareTag("Block"))
        {
            other.gameObject.SetActive(false);
        }

        //if(other.gameObject.CompareTag("killbox"))
        //{
        //    print("HI");
        //    startposition = transform.position;
        //}
    }

           
        

}


    //private Vector3 CheckCeilingRays(Vector3 pos)
    // {
    //     RaycastHit2D ceilLeft = Physics2D.Raycast(original, Vecotr2.up, Velocity)

    //     RaycastHit2D hitRay = ceilLeft;
    // }



