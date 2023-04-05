using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D myRigid;

    [SerializeField] float force;
    [SerializeField] float rotSpeed;

    bool forceTrue = true;

    public GameObject enemy;

    public bool isPlayer1Arrow;
    public bool isPlayer2Arrow;

    private void Awake()
    {
        myRigid = GetComponent<Rigidbody2D>();

        if(isPlayer1Arrow)
        {
            enemy = GameObject.FindWithTag("Player2");
        }
        else
        {
            enemy = GameObject.FindWithTag("Player1");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (forceTrue)
        {
            if (isPlayer1Arrow)
            {
                myRigid.AddForce(Vector3.up * force, ForceMode2D.Impulse);
                myRigid.AddForce(Vector3.right * force, ForceMode2D.Impulse);
            }
            else if(isPlayer2Arrow)
            {
                myRigid.AddForce(Vector3.up * force, ForceMode2D.Impulse);
                myRigid.AddForce(Vector3.left * force, ForceMode2D.Impulse);
            }
        }
        /*else if (myRigid.velocity.y <= 0)
        {
            this.transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Vector2.down),
            Time.deltaTime * rotSpeed);
        }

        Debug.DrawLine(transform.position, Vector2.down ,Color.red, 100f);*/
    }

    IEnumerator ShootCoroutine()
    {
        yield return new WaitForSeconds(0.03f);
        forceTrue = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player1") && isPlayer2Arrow)
        {
            Destroy(this.gameObject);
        }
        else if(collision.transform.CompareTag("Player2") && isPlayer1Arrow)
        {
            Destroy(this.gameObject);
        }
    }
}
