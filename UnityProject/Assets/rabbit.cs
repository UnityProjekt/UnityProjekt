using UnityEngine;
using System.Collections;

public class rabbit : Character
{
    private Transform target;
    public int moveSpeed;
    public int rotationSpeed;


    public Transform Target
    {
        get
        {
            return target;
        }


        set
        {


            target = value;
        }



    }



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        FollowTarget();

    }


    private void FollowTarget()
    {

        Animator animator = GetComponent<Animator>();
        if (target != null)
        {

            animator.SetFloat("x", -direction.x);
            animator.SetFloat("y", direction.y);
            direction =(target.transform.position - transform.position).normalized;
            transform.position =Vector2.MoveTowards(transform.position, target.position, -1 * Time.deltaTime);

        }
        else

            direction = Vector2.zero;





    }

}
