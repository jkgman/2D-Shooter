using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class CharControl : MonoBehaviour
    {
        public float speed = 3f;
        private Vector3 getMovementVector() {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            return new Vector3(x,y,0);
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(getMovementVector()* Time.deltaTime * speed);
        }
    }
}
