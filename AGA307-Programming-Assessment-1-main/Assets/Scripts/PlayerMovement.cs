 using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;

    Vector3 velocity;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;
    public Gun[] guns;
    public int currentGun = 0;


    public float jumpHeight = 30f;

    void Start()
    {
        SwitchWeapons(0);
    
    }

    private void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); 


        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }    

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);


        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        for(int i = 0; i < guns.Length; i++)
        {
            string key = (i + 1).ToString();
            if (Input.GetKeyDown(key))
                SwitchWeapons(i);
        }     

    }
    void SwitchWeapons(int targetWeapon)
    {
        for(int i = 0; i < guns.Length; i++)
        {
            if (i == targetWeapon)
                guns[i].gameObject.SetActive(false);

            guns[targetWeapon].gameObject.SetActive(true);

            currentGun = targetWeapon;
        }
            
            
    }
}
