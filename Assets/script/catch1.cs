using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catch1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount >= 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Transform kid = transform.GetChild(0);
                Destroy(kid.gameObject);
            }
        }
        if (this.GetComponent<BoxCollider2D>() == null && transform.childCount < 1)
        {
            Debug.Log("!!!");
            this.gameObject.AddComponent<BoxCollider2D>();
        }
        if (this.GetComponent<BoxCollider2D>() != null && transform.childCount >= 1)
        {
            Debug.Log("222");
            BoxCollider2D bb = GetComponent<BoxCollider2D>();
            Destroy(bb);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "goods" && transform.childCount < 1)
        {
            col.gameObject.transform.parent = this.transform;
            BoxCollider2D c = col.collider.GetComponent<BoxCollider2D>();
            Destroy(c);
        }
    }
}
