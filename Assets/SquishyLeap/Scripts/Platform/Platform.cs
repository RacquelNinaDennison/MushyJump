using UnityEngine;

namespace Mushy
{
    public class Platform : MonoBehaviour
    {

        #region Editor Fields
        [SerializeField]
        private float _jumpForce;
        #endregion
        public void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.rigidbody != null)
            {
                if (collision.relativeVelocity.y <= 0)
                {
                    var ridgidBody = collision.collider.GetComponent<Rigidbody2D>();
                    var velocity = ridgidBody.linearVelocity;
                    velocity.y = _jumpForce;
                    ridgidBody.linearVelocity = velocity;
                }
            }
        }
    }
}
