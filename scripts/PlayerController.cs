using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{

    [HideInInspector]
    public bool facingRight = true;
    [HideInInspector]
    public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck;


    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;
    private new AudioSource audio; //añadido
    public static int coins;
    public static int lifes = 3;
    public int vidas;
    public float smoothTimeX;


    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>(); //añadido
        

    }

    Vector2 pointA;
    Vector2 pointB;
    // Update is called once per frame
    void Update()
    {
        //grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")); Linecast fue el primero
        //grounded = Physics2D.OverlapArea(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        pointA = groundCheck.position; //The position of the rectangle
        pointB.x = groundCheck.position.x + 0.01f; // sum the size of the axis X of the box collider
        pointB.y = groundCheck.position.y + 0.5f; // sum the size of the axis Y of the collider

        grounded = Physics2D.OverlapArea(pointA, pointB, 1 << LayerMask.NameToLayer("Ground"));
        //grounded = Physics2D.OverlapArea(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        bool pisarsuelo = Physics2D.OverlapArea(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        anim.SetBool("idle", pisarsuelo);

        bool fall = (rb2d.velocity.y < 0);
        anim.SetBool("fall", fall);


        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
            audio.Play();
            // object.enabled = false;
        }

        //score
        coins = PickupCoin.coins; // Indica que el valor de coins es igual a el valor de coins en el script PickupCoin
        
        if (PickupCoin.coins >= 100) { lifes++; }
        vidas = lifes;

    }

    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");

        bool Corro = (Mathf.Abs(rb2d.velocity.x) != 0); //correr
        anim.SetBool("Run", Corro);

        if (h * rb2d.velocity.x < maxSpeed)
            rb2d.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs(rb2d.velocity.x) > maxSpeed)
            rb2d.velocity = new Vector2(Mathf.Sign(rb2d.velocity.x) * maxSpeed, rb2d.velocity.y);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        if (jump)
        {
            anim.SetTrigger("jump");
            rb2d.AddForce(new Vector2(0f, jumpForce));
            jump = false;
        }


        


    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.transform.tag == "Plataforma") {
            transform.parent = other.transform;
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if (other.transform.tag == "Plataforma") {
            transform.parent = null;
        }
    }


}
