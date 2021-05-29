using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private CharacterController con;
    private Vector3 diection;
    public GameManager gameManager;

    //0: left 1: middle 2:right
    private int desiredLen = 1;

    // distance bet two len
    public float distancelen = 4;

    public float forwardSpeed;
    // Start is called before the first frame update

    public float jumpForce;
    public float earthGravit=-5;
    public float maxSpeed;
    void Start()
    {
        con = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        diection.z = forwardSpeed;
        if(forwardSpeed < maxSpeed)
        {
            forwardSpeed += 1 * Time.deltaTime;
        }
      

        if (con.isGrounded)
        {
            diection.y = -1;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
            }
        }
        else
        {
            diection.y += earthGravit * Time.deltaTime;
        }
        //select the len

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLen++;
            if (desiredLen == 3)
                desiredLen = 2;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLen--;
            if (desiredLen == -1)
                desiredLen = 0;
        }

        //where whould be in future

        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (desiredLen == 0)
        {
            targetPosition += Vector3.left * distancelen;
        }
        else if (desiredLen == 2)
        {
            targetPosition += Vector3.right * distancelen;
        }
        transform.position = targetPosition;
        con.center = con.center;
        con.Move(diection * Time.deltaTime);
    }
    private void FixedUpdate()
    {
       
    }

   private void Jump()
    {
        diection.y = jumpForce;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
        
            if (hit.transform.tag == "Obstacle")
            {
                gameManager.GameOver();
              gameManager.isGameActive = true;
            
            }
        

    }
}
