using UnityEngine;

public class Unit : MonoBehaviour
{
    public int LifePoints;

    public float Speed = 20f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(rb.position + Vector2.right * Speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(rb.position + Vector2.left * Speed * Time.deltaTime);
        }
    }

    public void TakeDamage(int damage)
    {
        LifePoints -= damage;
        if (LifePoints <= 0)
            Die();
    }

    private void Die()
    {
        Debug.Log("AAA " + this.name + " TOVOKNULSIA");
        EventAggregator.UnitDied.Publish(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage(100);
    }

}



//public class Unit : MonoBehaviour
//{

//    public int LifePoints = 100;

//    public float Speed = 20f;
//    Rigidbody2D rb;

//    public void TakeDamage(int damage)
//    {
//        LifePoints -= damage;
//        Debug.Log("Your HP: " + LifePoints);
//        if (LifePoints <= 0)
//            Die();
//    }

//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//    }

//    void FixedUpdate()
//    {
//        if (Input.GetKey(KeyCode.D))
//        {
//            rb.MovePosition(rb.position + Vector2.right * Speed * Time.deltaTime);
//        }

//        if (Input.GetKey(KeyCode.A))
//        {
//            rb.MovePosition(rb.position + Vector2.left * Speed * Time.deltaTime);
//        }
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        TakeDamage(100);
//    }

//    private void Die()
//    {
//        Mediator.UnitDied.Publish(this);
//        Debug.Log("Publish to MEDIATOR, AAAA chel tovoknulsia \n" + this);
//    }

//}

//public float Speed = 20f;
//Rigidbody2D rb;

//void Start()
//{
//    rb = GetComponent<Rigidbody2D>();
//}

//void FixedUpdate()
//{
//    if (Input.GetKey(KeyCode.D))
//    {
//        rb.MovePosition(rb.position + Vector2.right * Speed * Time.deltaTime);
//    }

//    if (Input.GetKey(KeyCode.A))
//    {
//        rb.MovePosition(rb.position + Vector2.left * Speed * Time.deltaTime);
//    }
//}