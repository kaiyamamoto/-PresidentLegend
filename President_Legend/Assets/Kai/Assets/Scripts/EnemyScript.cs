using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    public float enemy_speed;
    public GameObject Star;
    bool hit_flag = false;

	// Update is called once per frame
	void Update ()
    {
        if (hit_flag)
        {
            Enemy_huttobu();
        }
        else
        {
           Enemy_move();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") 
        {
            Debug.Log(other.gameObject.name);
            hit_flag = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag =="destroy")
        {
            Instantiate(Star,new Vector2(5.0f,3.0f),Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    public void Enemy_move()
    {
        this.transform.position += new Vector3(-enemy_speed * Time.deltaTime, 0.0f, 0.0f);
    }

    public void Enemy_huttobu()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(150.0f, 100.0f));
        this.transform.Rotate(new Vector3(0.0f, 0.0f, -130.0f));
    }
}

