using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_count : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x <= -6.4f)
        {
            Destroy(this.gameObject);
            glob.score1 += 2f;
        }
        if (transform.position.x >= 6.4f)
        {
            Destroy(this.gameObject);
            glob.score2 += 2f;
        }
    }
}
