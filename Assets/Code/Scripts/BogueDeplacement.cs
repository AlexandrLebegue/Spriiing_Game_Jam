using UnityEngine;
using System.Collections;

public class BogueDeplacement : MonoBehaviour {
 
    public float speedForce = 2f;
    public float jumpForce = 2f;
    public Animator animator;
    private Rigidbody2D _playerRigidbody;
    private SpriteRenderer _spriteRenderer;
    private Vector3 m_velocity = Vector3.zero;

    [SerializeField] private bool CheckOnGround;
    [Range(0, 1)] [SerializeField] private float m_MouvementSmoothing = .05f;
    [SerializeField] private float max_velocity;

    void Start () {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _playerRigidbody = GetComponent<Rigidbody2D>();
        CheckOnGround = false;
    }
 
    void Update () {
        _Move();
        _Jump();
    }

    private void _Jump() {
        if (Input.GetButton("Jump") && CheckOnGround == true){
            CheckOnGround = false;
            _playerRigidbody.velocity = new Vector2(0f, jumpForce*10f);
        }
    }

    private void _Move(){
        var horizontalInput = Input.GetAxisRaw("Horizontal");
      
            if (horizontalInput < 0) {
                _spriteRenderer.flipX = true;
                
            }else {
                _spriteRenderer.flipX = false;  
            }

            if (horizontalInput == 0) {
                animator.SetBool("Is_Walking", false);
            } else {
                animator.SetBool("Is_Walking", true);
                Vector3 targetVelocity = new Vector2(horizontalInput*speedForce, _playerRigidbody.velocity.y);
                _playerRigidbody.velocity = Vector3.SmoothDamp(_playerRigidbody.velocity, targetVelocity, ref m_velocity, m_MouvementSmoothing, max_velocity);
            }
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag == "Plateforme") {
            Debug.Log("eee");
            CheckOnGround = true;
        }
    }

}