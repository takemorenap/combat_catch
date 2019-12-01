using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goods_generate : MonoBehaviour
{
    float time_count = 0f;
    int loopt = 0;
    public GameObject good;
    // Start is called before the first frame update
    void Start()
    {
  //     Random.InitState(0);
    }

    // Update is called once per frame
    void Update()
    {
        time_count += Time.deltaTime;
        if (time_count >= 1f)
        {
            float tx=0, ty=0;
            int flag = 0;
            time_count = 0f;
            while (flag == 0 && loopt < 1000)
            {
                ++loopt;
                flag = 1;
                Random.InitState(loopt);
                tx = Random.Range(-6f, 6f);
                ty = Random.Range(-4.2f, 4.2f);
                for (int i = 0; i < glob.size; ++i)
                {
                    if (glob.goods[i] == null)
                    {
                        continue;
                    }
                    float cx = glob.goods[i].transform.position.x, cy = glob.goods[i].transform.position.y;
                    if (((tx - 0.5f < cx && tx > cx) || (tx + 0.5f > cx && tx < cx)) && ((ty - 0.5f < cy && ty > cy) || (ty + 0.5f > cy && ty < cy))) 
                    {
                        flag = 0;
                        break;
                    }
                }
            }
            glob.goods[glob.size] = Instantiate(good);
            ++glob.size;
            float cx1 = glob.goods[glob.size - 1].transform.position.x, cy1 = glob.goods[glob.size - 1].transform.position.y;

            glob.goods[glob.size - 1].transform.Translate(new Vector2(tx - cx1, ty - cy1));
        }
          
      /*  if (time_count >= 1f)
        {
            float tx, ty;
            time_count = 0f;
            float is_minusx = 1f, is_minusy = 0f;
            if (Random.value < 0.5f)
            {
                is_minusx = -1f;
            }
            if (Random.value < 0.5f)
            {
                is_minusy = -1f;
            }
            tx = Random.value * 7f * is_minusx;
            ty = Random.value * 4f * is_minusy;
            glob.goods[glob.size] = Instantiate(good);
            ++glob.size;
            Debug.Log("!");
            float cx1 = glob.goods[glob.size - 1].transform.position.x, cy1 = glob.goods[glob.size - 1].transform.position.y;

            glob.goods[glob.size - 1].transform.Translate(new Vector2(tx - cx1, ty - cy1));
        }*/
    }
}
