using UnityEngine;
using System.Collections;

public class MichelApparait : MonoBehaviour {

    public Animator animator;

    [SerializeField] private Rigidbody2D mousse;

    void Start () {}
 
    void Update () {
        if (animator.GetBool("contact_with_bogue")){
            MoveDoor();
        }
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag == "Player") {
           animator.SetBool("contact_with_bogue", true);
        }
    }

    private void MoveDoor(){
        mousse.position = new Vector3(mousse.position.x, mousse.position.y, 0f);
    }

}