
using UnityEngine;

public class CollisionEndGame : MonoBehaviour
{
    public PlayerCollision collision;
    public PlayerMovement movement;
     /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    public void OnCollisionEnter(Collision collisionInfo)
    {
      if (collisionInfo.collider.GetComponent<Collider>().tag
       == "Obstacle")
      {
        movement.enabled = false;
        FindObjectOfType<GameManager>().EngGame(); 
      }



       // Debug.Log("We have collided with something");
    //    if  (other.GetComponent<Collider>().tag == "Obstacle")
    //    {
    //         movement.enabled = false;

    //         FindObjectOfType<GameManager>().EngGame(); 
    //    }
    }
}
