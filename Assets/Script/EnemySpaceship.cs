using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{

    public class EnemySpaceship : SpaceshipBase
    {
        private float _reachedDistance = 0.5f;

        [SerializeField]
        private GameObject[] _movementTargets;

        private int _currentMovementTargetIndex = 0;

        public Transform CurrentMovementTarget
        {
            get
            {
                return _movementTargets[_currentMovementTargetIndex].transform;
            }

        }
        public void setMovementTargets(GameObject[] movementTargets)
        {
            _movementTargets = movementTargets;
            _currentMovementTargetIndex = 0;
        }

        protected override void Move()
        {

            if (_movementTargets == null || _movementTargets.Length == 0)
            {
                return;
            }

            updateMovementTarget();

            Vector3 direction = (CurrentMovementTarget.position - transform.position).normalized;

            transform.Translate(direction * Speed * Time.deltaTime);
        }

        private void updateMovementTarget()
        {
            if (Vector3.Distance(transform.position, CurrentMovementTarget.position) < _reachedDistance)
            {
                if (_currentMovementTargetIndex >= _movementTargets.Length - 1)
                {
                    _currentMovementTargetIndex = 0;
                }

                else
                    _currentMovementTargetIndex++;
            }
        }
    }

}