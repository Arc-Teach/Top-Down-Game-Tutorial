using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //This initializes a variable for moveSpeed
    //When you declare a variable, you have to include the type
    //float means a decimal
    //Declare: Make a variable with a name
    //Assign: Give the variable a value
    //Initialize: Declare + Assign
    //Float: A short decimal value (Floating-Point)
    //Int: A non-decimal number (Integer)
    //Bool: only True or False (Boolean)
    //String: Text in quotes "String"
    [SerializeField]  private float moveSpeed = 5f;
    //To declare others:
    //private bool flag = True;
    //private int num = 6;
    //private string text = "Hello, world!";
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;

    //Inspector shows the properties of a game object
    //Hierarchy shows a list of game objects
    //Scene View shows where the game objects are placed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    //Scripts are attached to GameObjects
    //They modify properties while the game is running
    //Modifying properties == assigning variables
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed; 
    }

    //Use this to get user input
    public void Move(InputAction.CallbackContext context)
    {
        animator.SetBool("IsWalking",true);

        if(context.canceled)
        {
            animator.SetBool("IsWalking",false);
            animator.SetFloat("LastInputX",moveInput.x);
            animator.SetFloat("LastInputY",moveInput.y);
        }
        
        moveInput = context.ReadValue<Vector2>();

        animator.SetFloat("InputX",moveInput.x);
        animator.SetFloat("InputY",moveInput.y);
    }
}