using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer {
    public class Projectile : MonoBehaviour
    {
        //Outlets
        Rigidbody2D _rb;

        // Start is called before the first frame update
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _rb.velocity = transform.right * 10f;
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void OnCollisionEnter2D(Collision2D other) {
            Destroy(gameObject);
        }
    }
}