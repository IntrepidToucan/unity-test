using UnityEngine;

namespace Source.Scripts

{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] private GameObject leader;
        [SerializeField] private Vector3 offset = new(0, 0, -10);
        
        private void LateUpdate()
        {
            transform.position = leader.transform.position + offset;
        }
    }
}
