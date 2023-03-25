using UnityEngine;
using System.Collections;




static class Constants
{
public static readonly Vector2 OFFSET_COLLIDE_CROUCH = new Vector2(0.1631325f, -2.12f);
public static readonly Vector2 SIZE_COLLIDE_CROUCH = new Vector2(4.27f, -4.53f);

public static readonly Vector2 OFFSET_COLLIDE_IDLE = new Vector2(0.1631325f, -0.15f);
public static readonly Vector2 SIZE_COLLIDE_IDLE = new Vector2(3.763591f, 8.12f);

public static readonly int MIN_HEIGHT = 6;

}

public class BogueDeplacement : MonoBehaviour {
    



    public float speedForce = 2f;
    public float jumpforce = 2f;

    public Vector3 boxSize;
    public float maxDistance;
    public LayerMask layerMask;
    public Animator animator;
    private Rigidbody2D _playerRigidbody;
    private SpriteRenderer _spriteRenderer;
    private Vector3 m_velocity = Vector3.zero;

    private bool _hasJumped;

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
        _GroundCheck();
    }

    private void _Crouch() {
        var verticalInput = Input.GetAxisRaw("Vertical");
        CapsuleCollider2D  capsuleCollider = GetComponent<CapsuleCollider2D>();
        var capsule_size = capsuleCollider.size;
        var capsule_offset = capsuleCollider.offset;
        

        if (verticalInput < 0) {
            if (!animator.GetBool("Is_Crouching")){
                animator.SetBool("Is_Crouching", true);
                // Update collider ... 
                capsuleCollider.size = Constants.SIZE_COLLIDE_CROUCH;
                capsuleCollider.offset = Constants.OFFSET_COLLIDE_CROUCH;
            }

        } else if (verticalInput > 0 ) {

            if (animator.GetBool("Is_Crouching")) {
                // Update collider ... 
                capsuleCollider.size = Constants.SIZE_COLLIDE_IDLE;
                capsuleCollider.offset = Constants.OFFSET_COLLIDE_IDLE;
            }
                animator.SetBool("Is_Crouching", false);
        }
    }

    private void _Jump() {
        if (Input.GetButton("Jump") && (_GroundCheck())) {
            // && (animator.GetBool("Is_Crouching"))
            var rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector3.up * jumpforce,ForceMode2D.Impulse);
            // force is jumping test here ... 
            _hasJumped = true;
            
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
    void OnDrawGizmos()
    {
        Gizmos.color=Color.red;
        Gizmos.DrawCube(transform.position-transform.up*maxDistance,boxSize);
    }
    private bool _GroundCheck()
    {
        if(Physics2D.BoxCast(transform.position,boxSize,0,-transform.up,maxDistance,layerMask))
        {
            // Si le personnage a déjà sauté alors on retourne false car le saut commence à avoir lieu 
            if ( _hasJumped) {
                return false;
            }
            return true;
        }
        else{
            if ( _hasJumped) {
                
                _hasJumped = false;
            }
            return false;
        }
    }

}