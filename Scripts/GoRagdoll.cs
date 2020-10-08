using System;
using UnityEngine;


    public class GoRagdoll : MonoBehaviour
    {
        private Rigidbody[] childRigidBodies;
        private Collider[] childColliders; 
        public bool invincible = false;
        
        void Start()
        {
            childRigidBodies = gameObject.GetComponentsInChildren<Rigidbody>();
            childColliders = gameObject.GetComponentsInChildren<Collider>();
        }
        public void GotoRagdoll()
        {
            if(!invincible)
            { 
                if (childRigidBodies != null)
                {
                    foreach(Rigidbody childRigidBody in childRigidBodies)
                    {
                        childRigidBody.isKinematic = false;
                    }
                }
                if (childColliders != null)
                {
                    foreach(Collider childCollider in childColliders)
                    {
                        childCollider.enabled = true;
                    }
                }
                gameObject.GetComponent<Collider>().enabled = false;
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
                gameObject.GetComponent<Animator>().enabled = false;
                gameObject.GetComponent<ThirdPersonCharacter>().enabled = false;
                gameObject.GetComponent<ThirdPersonUserControl>().enabled = false;
            }
        }
        public void ExitRagdoll()
        {
            invincible = false;
            if (childRigidBodies != null)
            {
                foreach(Rigidbody childRigidBody in childRigidBodies)
                {
                    childRigidBody.isKinematic = true;
                }
            }
            if (childColliders != null)
            {
                foreach(Collider childCollider in childColliders)
                {
                    childCollider.enabled = false;
                }
            }
            gameObject.GetComponent<Collider>().enabled = true;
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<ThirdPersonCharacter>().enabled = true;
            gameObject.GetComponent<ThirdPersonUserControl>().enabled = true;
        }
        public void Invincibility()
        {
            invincible = !invincible;
        }
    }

