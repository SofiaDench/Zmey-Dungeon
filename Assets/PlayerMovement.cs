using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;
    public Vector3 playerVelocity;
    public float playerSpeed = 2;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.Move(move * Time.deltaTime * playerSpeed);

        if(move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        //characterController.Move(playerVelocity * Time.deltaTime);
    }
}
