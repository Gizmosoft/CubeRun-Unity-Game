using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    // vector3 is a datatype with 3 floats
    public Vector3 offset;          // x' y' z'


      // Update is called once per frame
    void Update()
    {

        // adding offset adds: x+x' , y+y', z+z' every frame
        transform.position = player.position + offset;   // cam position will be set to player position every frame which makes it follow player

        
    }
}
