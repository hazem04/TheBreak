using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemy : MonoBehaviour
{
    private Animator anim;

    public GameObject lostHUD;
    public Transform target;
    public Transform targeta;
    public Transform targetb;
    public Transform targetc;
    public Transform targetd;
    public Transform targete;
    public Transform targetf;
    public Transform targetg;
    public Transform targeth;
    public Transform targeti;
    public Transform targetj;
    public Transform targetk;
    public Transform targetl;
    public Transform targetm;
    public Transform targetn;
    public Transform targeto;
    
    public UnityEngine.AI.NavMeshAgent agent;
    public AudioSource chase;
    public AudioSource attack;
    public AudioSource idle;
    public float distance;
    public bool dead;
    private float timer = 0f;
    private float chasetimer = 0f;
    private float speed = 3.5f;
    public int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        dead = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {   
            attack.Play();
            dead = true;
            Time.timeScale = 0;
            lostHUD.SetActive(true);

        }
        if (other.gameObject.tag == "zones") 
        {
            
            i = i + 1;
            timer = 0f;
        }

    }


    // Update is called once per frame
    void Update()
    {
        
        if (i > 15)
            i = 1;
        chasetimer += Time.deltaTime;
        timer += Time.deltaTime;
        distance = Vector3.Distance(target.transform.position, transform.position);
        if (dead == false)
        {
            if (distance < 12f)
            {
                if (chasetimer >= 2f)
                {
                    chase.Play();
                    chasetimer = 0f;
                }
               
                anim.SetTrigger("run");
                agent.SetDestination(target.transform.position);
            }
            else
            {

                if (timer >= 2f)
                {
                    idle.Play();
                    anim.SetTrigger("run");
                    if (i == 1)
                        agent.SetDestination(targeta.transform.position);
                    if (i == 2)
                        agent.SetDestination(targetb.transform.position);
                    if (i == 3)
                        agent.SetDestination(targetc.transform.position);
                    if (i == 4)
                        agent.SetDestination(targetd.transform.position);
                    if (i == 5)
                        agent.SetDestination(targete.transform.position);
                    if (i == 6)
                        agent.SetDestination(targetf.transform.position);
                    if (i == 7)
                        agent.SetDestination(targetg.transform.position);
                    if (i == 8)
                        agent.SetDestination(targeth.transform.position);
                    if (i == 9)
                        agent.SetDestination(targeti.transform.position);
                    if (i == 10)
                        agent.SetDestination(targetj.transform.position);
                    if (i == 11)
                        agent.SetDestination(targetk.transform.position);
                    if (i == 12)
                        agent.SetDestination(targetl.transform.position);
                    if (i == 13)
                        agent.SetDestination(targetm.transform.position);
                    if (i == 14)
                        agent.SetDestination(targetn.transform.position);
                    if (i == 15)
                        agent.SetDestination(targeto.transform.position);
                    
                }
                else
                {
                    anim.SetTrigger("idle");

                }
            }

        }
       

    }

}