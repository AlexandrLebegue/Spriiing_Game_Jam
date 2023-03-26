using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichelFollowBogue : MonoBehaviour {

    public Transform cible;
    private Transform maTransform;
    private UnityEngine.AI.NavMeshAgent agent;
    public bool poursuite;
    public float pdv = 10f;
    public bool pause;
   
    void Awake(){
        maTransform = transform;
    }

    void Start(){
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();   
        pause = false;

    }

    // Update is called once per frame
    void Update(){
        if (poursuite){
            mouvement();
        }
        if (poursuite == false && pause == true){
            miseEnAttente();
        }

    }

    private void mouvement(){
        if (pdv > 0){
            Debug.DrawLine(cible.transform.position, maTransform.position, Color.blue);
            agent.destination = cible.position;
        }
    }

    private void miseEnAttente(){
        print("NE BOUGE PLUS !!");
        agent.destination = transform.position;
    }


}
