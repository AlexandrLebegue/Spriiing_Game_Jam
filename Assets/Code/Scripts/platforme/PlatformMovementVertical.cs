using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementVertical : MonoBehaviour
{
 
    [SerializeField] float offsetTop = 0, offsetBottom = 0, speed = 1;
    [SerializeField] bool hasReachedTop= false, hasReachedBottom = false;
    Vector3 startPosition = Vector3.zero;
 
    void Awake() {
        startPosition = transform.position;
    }
 
    void FixedUpdate() {
        if (!hasReachedTop) {
            if (transform.position.y < startPosition.y + offsetTop) {
                Move(offsetTop);      
            }
            else if (transform.position.y >= startPosition.y + offsetTop) {
                hasReachedTop = true;
                hasReachedBottom = false;
            }
        }
        else if (!hasReachedBottom) {
            if (transform.position.y > startPosition.y + offsetBottom) {
                Move(offsetBottom); 
            }
            else if (transform.position.y <= startPosition.y + offsetBottom) {
                hasReachedTop = false;
                hasReachedBottom = true;
            }
        }
    }

    void Move(float offset) {
        transform.position = Vector3.MoveTowards(transform.position,
                                             new Vector3(transform.position.x,
                                                         startPosition.y + offset,
                                                         transform.position.z),
                                             speed * Time.deltaTime);
        }
}