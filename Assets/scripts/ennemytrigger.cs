using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemytrigger : MonoBehaviour
{
    public GameObject ennemy;
    public GameObject objective;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trig")
        {
            ennemy.SetActive(true);
            objective.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
