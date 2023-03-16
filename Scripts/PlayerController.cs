using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Stats")]
    public float moveSpeed;
    public float jumpForce;
    [Header("Camera Info")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    //privated variables
    private float rotX; //rotation X of the camera
    private Camera camera;
    private Rigidbody rb; //reference player rigid body
    
    void Awake()
    {
        //Get Components
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove(); 
        CameraLook();
        
        if(Input.GetButtonDown("Jump"))
        PlayerJump();
    }
    
    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed; //left and right movement
        float z = Input.GetAxis("Vertical") * moveSpeed; //get input for forward and backward movement
        
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;
        
        
        rb.velocity = dir;//(x,y,z) Driving movement relative to the cameras look direction
    }
    
    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
        
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX); //Clamps rotation on the X axis
        
        camera.transform.localRotation = Quaternion.Euler(-rotX,0,0);//accurately calculate rotation
        transform.eulerAngles += Vector3.up * y; //driving the camera look rotation left and right 
    }
    
    void PlayerJump()
    {
        //Ground Check
        Ray ray = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(ray, 1.1f))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    
   public void GiveHealth(int amount)
    {
        Debug.Log("Player picked up health");
    }
    
    public void GiveAmmo(int amount)
    {
        Debug.Log("Ammo Collected");
    }
}
