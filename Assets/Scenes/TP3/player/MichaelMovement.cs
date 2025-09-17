using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MichaelMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;

    [SerializeField] private float speed;

    [SerializeField] private Transform orientation;
    [SerializeField] private Rigidbody rb;

    private Vector3 moveDirection;

    
    private bool isGrounded;
    [Header("Ground Stuff")]
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private float checkToGroundDistance;
    [SerializeField] private float playerHeight;
    [SerializeField] private float groundDrag;


    
    private MyQueue<recordObject> shadowList = new MyQueue<recordObject>();
    [Header("Shadow stuff")]
    private bool shadowOn = false;

    [SerializeField] private GameObject replayObjectPrefab;
    private GameObject replayObject;

    private void Start()
    {
    }
    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + checkToGroundDistance, whatIsGround);
        Debug.DrawRay(transform.position, Vector3.down * (playerHeight * 0.5f + checkToGroundDistance), Color.red);

        MyInput();

        if (isGrounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }   
    }

    private void FixedUpdate()
    {
        MovePlayer();
        shadowList.Enqueue(new recordObject(transform.position, transform.rotation));

        if (shadowOn)
        {
            if (replayObject == null)
            {
                var tempTransform = shadowList.Dequeue();

                replayObject = Instantiate(replayObjectPrefab, tempTransform.position, tempTransform.rotation);
            }
            else
            {
                var tempTransform = shadowList.Dequeue();

                replayObject.transform.position = tempTransform.position;
                replayObject.transform.rotation = tempTransform.rotation;
            }
        }
    }

    private void MyInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal") * Time.fixedDeltaTime;
        vertical = Input.GetAxisRaw("Vertical") * Time.fixedDeltaTime;

        if (Input.GetKeyDown("space")) { shadowOn = !shadowOn; }
        if (Input.GetKeyDown("m"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("Menu"); 
        }
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * vertical + orientation.right * horizontal;

        rb.AddForce(moveDirection * speed * 10f, ForceMode.Force);
    }
}
