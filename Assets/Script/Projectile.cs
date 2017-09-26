using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
    public class Projectile : MonoBehaviour, IDamageProvider
    {
        [SerializeField]
        private int _damage;

        [SerializeField]
        private float _speed;

        private Rigidbody2D _rigidbody;
        private Vector2 _direction;
        private bool _isLaunched = false;

        public int GetDamage() {
            return _damage;
        }

        protected virtual void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _isLaunched = true;
            if (_rigidbody == null) {
                Debug.LogError("no rigid body on projectile");
            }
        }

        protected void FixedUpdate()
        {
            if (!_isLaunched)
            {
                return;
            }
            Vector2 velocity = _direction * _speed;
            Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
            Vector2 newPosition = currentPosition + velocity * Time.fixedDeltaTime;
            _rigidbody.MovePosition(newPosition);
        }

        public void Launch(Vector2 direction) {
            _direction = direction;

        }
    }
}
