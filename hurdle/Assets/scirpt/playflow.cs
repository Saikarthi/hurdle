
using UnityEngine;

public class playflow : MonoBehaviour
{
    
    public int fa=0;
    public float d1;
    public Transform player;
    public Vector3 a,b;
  

    void Update()
    {
            d1 = player.position.z;
        
        b = new Vector3(0f, 0f, d1);

        transform.position = b + a;

            



    } 
    
}
