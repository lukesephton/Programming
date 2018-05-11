using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Breakout
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5f; // Speed that the ball travels

        private Vector3 velocity; // Velocity of the ball (Direction 
                                  // Use this for initialization
        public void Fire(Vector3 direction)
        {
            // Velocity iis direction * speed; 
            velocity = direction * speed;
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            ContactPoint2D contact = collision.contacts[0];
            // Calculate reflection of contact
            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            // Apply new reflect value
            velocity = reflect.normalized * speed;
        }
        // Use this for initalization
        
        void Update()
        {
            // Move the ball
            transform.position += velocity * Time.deltaTime;
        }
    }
}
