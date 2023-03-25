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
        _Crouch();
    }

    private void _Crouch() {
        var verticalInput = Input.GetAxisRaw("Vertical");
        CapsuleCollider2D  capsuleCollider = GetComponent<CapsuleCollider2D>();
        var capsule_size = capsuleCollider.size;
        var capsule_offset = capsuleCollider.offset;
        

        if (verticalInput < 0) {
            if (!animator.GetBool("Is_Crouching")){
                animator.SetBool("Is_Crouching", true);
                var size = capsuleCollider.size;
                capsule_size.y = capsule_size.y / 2 ;
                capsuleCollider.size = capsule_size;
                capsule_offset.y = capsule_offset.y - 0.2f; 
                capsuleCollider.offset = capsule_offset;
            }

        } else if (verticalInput > 0 ) {

            if (animator.GetBool("Is_Crouching")) {
                capsule_size.y = capsule_size.y *2 ;
                capsuleCollider.size = capsule_size;
                capsule_offset.y = capsule_offset.y + 0.2f; 
                capsuleCollider.offset = capsule_offset;
            }
                animator.SetBool("Is_Crouching", false);
            
        }
    }

    private void _Jump() {
        if (Input.GetButton("Jump") && CheckOnGround == true){
            CheckOnGround = false;
            _playerRigidbody.velocity = new Vector2(0f, jumpForce*10f);
        }
    }

    private void _Move(){
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        if (animator.GetBool("Is_Crouching")){
            // Par défaut on coupe l'animation de mouvement 
            animator.SetBool("Is_Walking", false);
            // et on return 
            return;
        }
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