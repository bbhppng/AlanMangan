using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    PlayerControls controls;
    public float speed = 5f;
    public float jumpForce = 15f;
    private bool isFacingRight = true;
    public Vector3 originalScale;
    public bool isFlat;
    float direction = 0;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    public void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();
        controls.Main.Move.performed += ctx => 
        {
            direction = ctx.ReadValue<float>();
        };
    }
        
    void Start()
    {
        
    }
   
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direction * speed * Time.deltaTime, rb.velocity.y);
    }
}
