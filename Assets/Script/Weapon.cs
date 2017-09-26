﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceShooter
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField]
        private float _cooldownTime = 0.5f;

        [SerializeField]
        private Projectile _projectilePrefab;

        private float _timeSinceShot = 0;
        private bool _isInCooldown = false;

        // Update is called once per frame
        void Update()
        {
            if (_isInCooldown == true) {
                _timeSinceShot += Time.deltaTime;
                if (_timeSinceShot >= _cooldownTime ) {
                    _isInCooldown = false;
                }
            }
        }

        public bool Shoot()
        {
            
            if (_isInCooldown) {
                return false;
            }
            Projectile projectile = Instantiate(_projectilePrefab,transform.position,transform.rotation);
            projectile.Launch(transform.up);
            
            _isInCooldown = true;
            _timeSinceShot = 0;

            return true;
        }
    }
}
