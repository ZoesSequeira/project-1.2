using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    int bronze = 0;
    int silver = 0;
    int bronzeSupply = 3;
    int silverSupply = 2;
    float mineNow;
    float miningSpeed = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        mineNow = miningSpeed; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>mineNow)
        {
            mineNow += miningSpeed;
            
            if (bronzeSupply > 0)
            {
                bronze++;
                bronzeSupply--;
            }
            else if (silverSupply > 0)
            {
                silver++;
                silverSupply--;
            }
            print("Bronze:" + bronze + " silver:" + silver);
        }
        
    }
}
