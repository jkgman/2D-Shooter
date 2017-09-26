using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceShooter
{
    public class Health : MonoBehaviour, IHealth
    {

        [SerializeField]
        private float _minHealth = 0;

        [SerializeField]
        private float _maxHealth = 100f;

        [SerializeField]
        private float _startHealth = 100f;

        private float _currentHealth;

        void Awake()
        {
            _currentHealth = _startHealth;
        }

        public void DecreaseHealth(float healthDecrease)
        {
            if (_currentHealth - healthDecrease > _minHealth)
            {
                _currentHealth -= healthDecrease;
            }
            else {
                _currentHealth = _minHealth;
            }
        }

        public void IncreaseHealth(float healthIncrease)
        {
            if (_currentHealth + healthIncrease < _maxHealth)
            {
                _currentHealth += healthIncrease;
            }
            else
            {
                _currentHealth = _maxHealth;
            }
        }
    }
}