using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{

    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject _prefabToSpawn;

        private float Timer;

        public void Awake()
        {
            Timer = Time.time + 0.5f;
        }
        public GameObject Spawn()
        {
            GameObject spawnedsObject = Instantiate(_prefabToSpawn, transform.position, transform.rotation);

            return spawnedsObject;
        }

        public void FixedUpdate()
        {
            //if (Timer < Time.time)
            //{
            //    Spawn();
            //    Timer = Time.time + 0.5f;
            //}

        }
    }
}
