using UnityEngine;
using System.Collections;

public class EnemyAI : Character {
	private Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	Rigidbody2D r2d;

    public Transform Target
	{
		get{
			return target;
		}


		set {


			target = value;
		}



	}



	void Start () {
      
    }

	// Update is called once per frame
	void Update () { 

		FollowTarget ();

	}


	private void FollowTarget()
	{

        Animator  animator = GetComponent<Animator>();
        if (target != null)
        {

            animator.SetFloat("x", direction.x);
            animator.SetFloat("y", direction.y);
            direction = (target.transform.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, target.position, 2 * Time.deltaTime);

        }
        else

            direction = Vector2.zero;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		float playerZdrowie = PlayerPrefs.GetFloat ("Zdrowie");
		playerZdrowie -= 20;
		PlayerPrefs.SetFloat ("Zdrowie", playerZdrowie);
		PlayerPrefs.SetInt ("Zaladuj", 1);
		PlayerPrefs.Save ();

		Debug.Log(PlayerPrefs.GetFloat("Zdrowie"));
		Debug.Log(PlayerPrefs.GetInt("Zaladuj"));
	}
}