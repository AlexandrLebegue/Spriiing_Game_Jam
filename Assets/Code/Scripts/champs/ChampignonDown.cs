using UnityEngine;
using System.Collections;

public class ChampignonDown : MonoBehaviour {

    public Animator animator;
    Vector3 startPosition = Vector3.zero;
    public float speed = 2f;

    [SerializeField] private Rigidbody2D door;
    [SerializeField] private float down;

    void Start () {}
 
    void Update () {
        if (animator.GetBool("contact_with_bogue")){
            gameObject.transform.position += new Vector3(0, 0, -1);
            MoveDoor();
        }
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag == "Player") {
           animator.SetBool("contact_with_bogue", true);
        }
    }

    private void MoveDoor(){
        door.position = Vector3.MoveTowards(transform.position,
                                             new Vector3(transform.position.x,
                                                         startPosition.y + -down,
                                                         transform.position.z),
                                             speed * Time.deltaTime);
    }

}