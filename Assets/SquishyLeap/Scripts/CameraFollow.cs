using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    #region Editor Fields
    [SerializeField]
    private Transform _player;
    #endregion


    public void Update()
    {
        if(_player.transform.position.y > this.transform.position.y)
        {
            var newPosition = new Vector3(this.transform.position.x, _player.transform.position.y, this.transform.position.z);
            this.transform.position = newPosition; 
        }
    }
}
