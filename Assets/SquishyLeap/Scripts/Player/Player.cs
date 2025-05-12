using UnityEngine;

public class Player : MonoBehaviour
{

    #region Editor Regions
    [SerializeField]
    private float _speed;
    #endregion
    #region Properties
    private Rigidbody2D _playerRidgidBody;
    private float _xMovement; 
    #endregion
    void Start()
    {
        _playerRidgidBody = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        _xMovement = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        var velocity = _playerRidgidBody.linearVelocity;
        velocity.x = _xMovement *_speed;
        _playerRidgidBody.linearVelocity = velocity;

    }
}
