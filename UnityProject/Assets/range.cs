using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class range : MonoBehaviour
{


    private rabbit parent;
    // Use this for initialization
    void Start()
    {
        parent = GetComponentInParent<rabbit>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {


            parent.Target = collision.transform;

        }

    }
    private void OnTriggerExit2D(Collider2D collision)

    {

        if (collision.tag == "Player")
        {

            parent.Target = null;
        }

    }



}


