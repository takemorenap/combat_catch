using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_board : MonoBehaviour
{
    public Text s1, s2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        s1.text = "玩家1分数：" + glob.score1;
        s2.text = "玩家2分数：" + glob.score2;
    }
}
