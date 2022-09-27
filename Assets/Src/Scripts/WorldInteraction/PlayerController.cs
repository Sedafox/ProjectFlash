

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public int rotationSpeed;
   
     public float horizontalInput;
    public float verticalInput;
    private Vector3 movementDir;
    public Transform cameraTransform;

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController =GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

      private void PlayerMovement()
    { //abstraction
       
        
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            movementDir = new Vector3(horizontalInput, 0, verticalInput);

            movementDir.Normalize();
            float magnitude = Mathf.Clamp01(movementDir.magnitude * speed);

            //  = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles, Vector3.up) * movementDir;
            characterController.SimpleMove(movementDir*magnitude);
            

            if(movementDir!= Vector3.zero)
            {
              Quaternion toLocation = Quaternion.LookRotation(movementDir, Vector3.up);
              transform.rotation =Quaternion.RotateTowards(transform.rotation,toLocation, rotationSpeed*Time.deltaTime);
            }
           

            
         
        
    }
}
