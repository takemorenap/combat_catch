using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    public GameObject p2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, glob.move_speed2 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-glob.move_speed2 * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0, -glob.move_speed2 * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(glob.move_speed2 * Time.deltaTime, 0));
        }
    }
}
