using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Player : MonoBehaviour
{
    Rigidbody2D rb; // обратились к риджитбади.
    public float speed;
    public float jumpHeight;
    public Transform groundCheck;
    bool isGrounded;
    Animator anim;
    int currHp;
    int maxHp = 1;
    public Main main;
    public bool key = true;
    bool canTP = true;
    int fire = 0;
    public int directionInput;
    public bool facingRight = true;
    SpriteRenderer sprite;
    public SoundEffector soundEffector;
    public AudioSource fit;
    public AudioSource jump;
  
    


    
    void Start()
    {
       

        rb = GetComponent<Rigidbody2D>(); // присваиваем rb класс Rigidbody2D на герое.
        anim = GetComponent<Animator>();
        currHp = maxHp;
        sprite = GetComponent<SpriteRenderer>();
       
    }

   
    void Update()
    {

        

        if (currHp == 0)
        {
            
            rb.isKinematic = true;
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            anim.SetInteger("State", 3);
            
            
           
        }
        else {
            CheckGround();
            
            if (directionInput == 0 && (isGrounded))
                anim.SetInteger("State", 1);



            else
            {
                FlipA();
                if (isGrounded)
                    anim.SetInteger("State", 4);
            }

        }


      

    }




   







    public void Jump()
    {
        if (isGrounded)
        {
           
            rb.AddForce(transform.up * jumpHeight, ForceMode2D.Impulse);
           
        }


    }



    private void FixedUpdate()// тут работаем с физикой
    {
        rb.velocity = new Vector2(directionInput * speed, rb.velocity.y);

       
    }
    
    void FlipA()
    {
        if (directionInput > 0)
            sprite.flipX = false;
        if (directionInput < 0)
            sprite.flipX = true;


    }

    void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.2f); // обратились ко всем колайдерам в кругу, радиус 0,2ф.
        isGrounded = colliders.Length > 1;
        if (!isGrounded)
            anim.SetInteger("State", 2);
    }



    public void RecountHp(int deltaHp)
    {
        currHp = currHp + deltaHp;
        Invoke("Lose", 0.9f);
        soundEffector.PlayDieS();


    }

    public void Move(int InputAxis)
    {
        directionInput = InputAxis;
        
    }
    void Lose()
    {
        main.GetComponent<Main>().Lose();
        
        

    }
   

    private void OnTriggerEnter2D(Collider2D collision) // ключ, телепорт
    {
      
        if (collision.gameObject.tag == "telport")
        {
            if (collision.gameObject.GetComponent<Teleport>().isOpen && canTP)
            {
                collision.gameObject.GetComponent<Teleport>().TPort(gameObject);
                canTP = false;
                StartCoroutine(TPwait());
            }
            else if (key)

                collision.gameObject.GetComponent<Teleport>().Unlock();
        }

       

    }

    IEnumerator TPwait()
    {
        yield return new WaitForSeconds(1f);
        canTP = true;
    }

   



    
    private void OnTriggerExit2D(Collider2D collision)
    {
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        


    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
        
        
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        
      
    }

   

    public int GetFire()
    {
        return fire;
    }
   
}
