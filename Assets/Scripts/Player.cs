using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float runSpeed;
    private float initialSpeed;

    private Rigidbody2D rigid;
    private bool _isRunning;
    private Vector2 _direction;
    private bool _isRolling;
    private bool _isCutting;
    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    public bool isRunning
    {
        get { return _isRunning; }
        set { _isRunning = value; }
    }

    public bool isRolling
    {
        get { return _isRolling; }
        set { _isRolling = value; }
    }

    public bool IsCutting
    {
        get { return _isCutting; }
        set { _isCutting = value; }
    }

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        initialSpeed = speed;
    }

    private void Update()
    {
        onInput();
        onRun();
        onRolling();
        OnCutting();
    }

    private void FixedUpdate()
    {
        onMove();
    }

    #region movement

    void onInput()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void onMove()
    {
        rigid.MovePosition(rigid.position + _direction * speed * Time.fixedDeltaTime);
    }

    void onRun()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
            _isRunning = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = initialSpeed;
            _isRunning = false;
        }
    }

    void onRolling()
    {
        //botão direito do mouse
        if (Input.GetMouseButtonDown(1))
        {
            speed = runSpeed;
            _isRolling = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            speed = initialSpeed;
            _isRolling = false;
        }
    }

    void OnCutting()
    {
        if (Input.GetMouseButtonDown(0))
        {
            IsCutting = true;
            speed = 0f;
        }

        if (Input.GetMouseButtonUp(0))
        {
            IsCutting = false;
            speed = initialSpeed;
        }
    }

    #endregion
}
