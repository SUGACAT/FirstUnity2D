using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed;
    public float startAngle;

    // Start is called before the first frame update
    void Start()
    {
        startAngle = Random.Range(0, 361); 

        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, startAngle));
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.Dead) { Destroy(this.gameObject); return; }

        float scale = transform.localScale.x;
        scale -= Time.deltaTime * speed;

        this.transform.localScale = new Vector3(scale,
            scale, transform.localScale.z);

        if(scale < 0f )
            Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
