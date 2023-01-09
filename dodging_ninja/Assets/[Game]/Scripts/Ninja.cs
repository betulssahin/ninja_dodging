using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;   
using UnityEngine.UI;

public class Ninja : MonoBehaviour
{
    float health = 100.0f;
    float current_health = 100.0f;
    public Image health_heart;
    public GameObject finish_panel;
    public GameObject win_panel;

    float currentTime = 0.0f;
    float stratingTime = 60.0f;
    TextMeshProUGUI countdown_txt;

    
    private float xPosition;
    private float yPosition;

    Rigidbody _rigidbody;  
    public float jump_force;
    
    private bool isJumping;  

    public Animator anim; 
    public float speed;  

    void Start()
    {
   
     _rigidbody=GetComponent<Rigidbody>();  

     currentTime = stratingTime;
     countdown_txt = GameObject.Find("Canvas/countdown_txt").GetComponent<TextMeshProUGUI>(); 

    
    
    
    }
                                                                           
     

                                                                            



   private void OnCollisionEnter(Collision collision){
         if(collision.gameObject.tag == "obstacle"){
          

            Destroy(collision.gameObject);

            current_health -= 10.0f;
            health_heart.fillAmount = current_health / health;

            if(current_health<=0){
                finish_panel.SetActive(true);
                Time.timeScale = 0.0f;
            }

          

     
                                                                                                            
    }

   

    if (collision.gameObject.CompareTag("ground"))
    {
        isJumping = false;
    }

    }





    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0,0,speed*Time.deltaTime);

            anim.SetTrigger("run");
            transform.eulerAngles= new Vector3(transform.eulerAngles.x,90.0f,transform.eulerAngles.z);
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(0,0,speed*Time.deltaTime);
            anim.SetTrigger("run");
            transform.eulerAngles= new Vector3(transform.eulerAngles.x, -90.0f,transform.eulerAngles.z);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping ) 
        {
            anim.SetTrigger("jump");
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.velocity = Vector3.up * jump_force * Time.deltaTime;
            isJumping = true;

        }

        anim.SetTrigger("idle");


        xPosition = Mathf.Clamp(transform.position.x, -7.0f, 7.0f );
        yPosition = Mathf.Clamp(transform.position.y, -6.0f, 6.0f);
        transform.position = new Vector3(xPosition,yPosition, transform.position.z);

        
       currentTime -=1*Time.deltaTime;
        countdown_txt.text = currentTime.ToString();


          if ( currentTime < 0.0f)
            {
                Time.timeScale = 0.0f;

                if(current_health > 0){
                    win_panel.SetActive(true);
                     Time.timeScale = 0.0f;
                }else{
                    finish_panel.SetActive(true);
                    Time.timeScale = 0.0f;
                }
                
            }
        
        
       


     }

    

}
