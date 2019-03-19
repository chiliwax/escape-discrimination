using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _moveVelocity = new Vector2(1, 1);
    [SerializeField]
    private float _jumpVelocity;
    [SerializeField]
    private float _speed = 1;
    [SerializeField]
    private float _jumpForce = 4000;
    private bool _grounded = true;

    public void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Jump();
    }

    public void Move()
    {
        var moveVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveVelocity *= _speed;
        _rb.MovePosition(_rb.position + moveVelocity);
    }

    public void Jump()
    { 
        if (Input.GetButtonDown("Jump"))
        { 
            //_rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);

            _rb.velocity += Vector2.up * _jumpVelocity;
            Debug.Log(_rb.velocity);
            _grounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _grounded = true;
    }
}
