using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{

    public abstract class SpaceshipBase : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 1.5f;

        private Weapon[] _weapons;

        public float Speed
        {
            get { return _speed; }
            protected set { _speed = value; }
        }

        public Weapon[] Weapons {
            get { return _weapons; }
        }

        protected abstract void Move();

        protected virtual void Update()
        {
            try
            {
                Move();
            }
            catch (System.NotImplementedException exception)
            {
                Debug.Log(exception.Message);
            }

            catch (System.Exception exception)
            {
                Debug.LogException(exception);
            }
        }

        protected virtual void Awake() {
            _weapons = GetComponentsInChildren<Weapon>(true);
        }

        protected void Shoot() {
            foreach (Weapon weapons in Weapons) {
                weapons.Shoot();
            }
        }

    }
}