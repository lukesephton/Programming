﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        public float acceleration = 10f;
        public float maxVelocity = 10f;
        public GameObject deathParticles;

        private Rigidbody rigid;
        private Vector3 spawnPoint;
        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
            spawnPoint = transform.position;
        }


        // Update is called once per frame
        void Update()
        {
            // Get input
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            // Convert input to Vector3 direction
            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            Transform cam = Camera.main.transform;
            inputDir = Quaternion.AngleAxis(cam.eulerAngles.y, Vector3.up) * inputDir;


            // Add force to Player
            rigid.AddForce(inputDir * acceleration);

            Vector3 vel = rigid.velocity;
            // Check if velocity is too high
            if (vel.magnitude > maxVelocity)
            {
                // Cap the velocity
                vel = vel.normalized * maxVelocity;
            }
            // Apply the velocity
            rigid.velocity = vel;
        }

        // Fold Code: CTRL + M + O
        // Un-Fold Code: CTRL + M + P

        // Resets the player's settings when run
        public void Reset()
        {
            // Play Explosion Particles
            // Reset player's position to start position
            transform.position = spawnPoint;
            // Reset player's velocity
        }
    }
}
