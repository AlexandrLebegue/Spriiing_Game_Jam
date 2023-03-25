using UnityEngine;
using System.Collections;

public class BogueDeplacement : MonoBehaviour {
 
    public float speedForce = 5f;
    public float jumpForce = 5f;
    
    private Animation _anim;
    private Rigidbody2D _playerRigidbody;
    private SpriteRenderer _spriteRenderer;

    [SerializeField] private bool CheckOnGround;

    void Start () {
        _anim = GetComponent<Animation>();
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
        _playerRigidbody.AddForce(new Vector2(horizontalInput * speedForce, 0f));
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag == "Plateforme") {
            Debug.Log("eee");
            CheckOnGround = true;
        }
    }

}