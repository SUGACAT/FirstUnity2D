using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;
    [SerializeField] float moveSpeed;

    public int playerHp;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if (GameManager.instance.Dead)
        {
            GameManager.instance.GameEnd();

            Destroy(this.gameObject); return;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dir_x = Input.GetAxisRaw("Horizontal");
        float dir_y = Input.GetAxisRaw("Vertical");

        Vector2 vel = new Vector2(dir_x, dir_y);
        rigid.velocity = vel * moveSpeed;
    }
}
