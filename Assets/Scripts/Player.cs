using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Player : MonoBehaviour
{

    public Rigidbody2D _rigidbody;
    public GameObject Player1;

    public float _speed;
    public TMP_Text myText;

    public int PlayerHealth = 100;

    int damage = 10;

    

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myText.text = $"{PlayerHealth}";

        
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
        
        
        
    }

     void MovePlayer(){

        Vector3 movePosition =  Vector3.zero;

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            
            movePosition.y += 1;
        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){

            movePosition.y -=1;
        }
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){

            movePosition.x -=1;
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){

            movePosition.x +=1;
        }

        Player1.transform.position += movePosition.normalized* Time.deltaTime;

        _rigidbody.linearVelocity = movePosition.normalized*_speed;

    }
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Enemy")
        {
            PlayerHealth = PlayerHealth - damage;
            
            if(PlayerHealth > 0)
            {
                myText.text = $"{PlayerHealth}";

            }

            else if (PlayerHealth == 0)
            {
            
                myText.text = "GAME OVER!";

        
            }
            
  
        } 

    }




}
