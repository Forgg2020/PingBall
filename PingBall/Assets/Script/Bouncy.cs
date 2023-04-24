using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace BouncyNameSpace
{
    public class TagCollisionTriiger : MonoBehaviour
    {
        protected virtual string CollisionTag { get; } = "Player";


        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag(CollisionTag))
            {
                onCollisionPlayer(other);
            }
            else if(other.gameObject.CompareTag("Space"))
            {
                onCollisionPlayer(other);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag(CollisionTag))
            {
                onTriggerPlayerOut(other);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(CollisionTag))
            {
                onTriggerPlayer(other);
            }
        }
        protected virtual void onCollisionPlayer(Collision other)
        {

        }
        protected virtual void onTriggerPlayer(Collider other)
        {

        }
        protected virtual void onTriggerPlayerOut(Collider other)
        {

        }
    }
}