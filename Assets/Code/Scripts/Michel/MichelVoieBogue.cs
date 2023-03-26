using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MichelVoieBogue : MonoBehaviour {

    private Transform laCible;

    public float distanceDetect = 4.0F; 
    public bool detecter;
    public float decroche = 3; 
    private MichelFollowBogue sComportement;

    void Start(){
        sComportement = GetComponent<MichelFollowBogue>();
        laCible = sComportement.cible;

    }

    void Update(){
        CalculDist();
    }

    private void CalculDist(){
        if (laCible) {
            float sqrLen = (laCible.position - transform.position).sqrMagnitude;
            Debug.Log(sqrLen);
            if (sqrLen < distanceDetect * distanceDetect)
            {
                detecter = true;
                ConditionComportement();
                if (IsInvoking("Timer"))
                {
                    CancelInvoke("Timer");
                }
            }
            if (sqrLen > distanceDetect && detecter)
            {
                detecter = false;
                PlusAdistance();
            }
        }
    }


    private void ConditionComportement(){
        if (detecter)
        {
            sComportement.pause = false;
            sComportement.poursuite = true;
            
        }
    }

    private void BonneDist(){
        sComportement.poursuite = true;
    }

    private void PlusAdistance(){
        Invoke("finPoursuite", decroche);
    }

    private void finPoursuite(){
        sComportement.pause = true;
        sComportement.poursuite = false;
        print("DESACTIVE LA POURSUITE !!");     
    }
}