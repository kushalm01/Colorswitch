
using UnityEngine;

public class FollowCircle : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Circle;
    
    void Update()
    {
        if(Circle.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, Circle.position.y, transform.position.z);
        }
    }
}
