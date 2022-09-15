using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formation : MonoBehaviour
{
    public GameObject gold;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creating",2f,5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Creating()
    {
        Instantiate(gold,new Vector3(Random.Range(-42, 42), 1, Random.Range(-42, -42)),transform.rotation);

    }
}
