using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceShooter { 

public class CharControl : SpaceshipBase {
            
        public const string HorizontalAxis = "Horizontal";
        public const string VerticalAxis = "Vertical";
                
        private Vector3 GetInputVector()
        {                    
            float HorizontalInput = Input.GetAxis(HorizontalAxis);
            float VerticalInput = Input.GetAxis(VerticalAxis);

            return new Vector3(HorizontalInput, VerticalInput, 0);    
        }


        void Shoot() {


        }

        protected override void Move()
        {
            Vector3 inputVector = GetInputVector();
            Vector2 movementVector = inputVector * Speed;

            transform.Translate(movementVector * Time.deltaTime);
        }
    }
}