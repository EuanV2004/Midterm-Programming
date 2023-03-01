using UnityEngine;

namespace Torn.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        [SerializeField] float maxPos;

        int playerDirection;
        int wallStopper = 1;
        private Rigidbody2D rb;
        private float gravityScale;   


        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            gravityScale = rb.gravityScale;
        }

        void Update()
        {
            Walk();    
        }

        void Walk()
        {
            if (Input.GetKey(KeyCode.D)) // detect while walking is the player input
            {
                playerDirection = 1;

                transform.position += transform.right * Time.deltaTime * movementSpeed * wallStopper; // Time.deltaTime, it does not depend on the performance of your computer
                transform.rotation = Quaternion.Euler(0, 0, 0); // set the rotation of game object
            }
            if (Input.GetKey(KeyCode.A))
            {
                playerDirection = -1;

                transform.position += transform.right * Time.deltaTime * movementSpeed * wallStopper;
                transform.rotation = Quaternion.Euler(0, 180, 0); //change y rotation to 180
            } 

            float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
        }

        public int ReturnPlayerDirection()
        {
            return playerDirection;
        }
    }
}