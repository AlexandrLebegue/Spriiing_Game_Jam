using UnityEngine;
using System.Collections;

public class ChampignonUp : MonoBehaviour {

    public Animator animator;

    [SerializeField] private Rigidbody2D door;

    void Start () {}
 
    void Update () {
        if (animator.GetBool("contact_with_bogue")){
            Destroy(gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
            MoveDoor();
        }
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag == "Player") {
           animator.SetBool("contact_with_bogue", true);
        }
    }

    private void MoveDoor(){
        door.position += new Vector2(0f, 0.2f);
    }

}