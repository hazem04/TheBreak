using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomKeys : MonoBehaviour
{
    private int random;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0, 3);
        if (random == 0)
            key1.SetActive(true);
        else if (random == 1) key2.SetActive(true);
        else key3.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
