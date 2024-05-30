using UnityEngine;

namespace Source.Scripts

{
    public class Driver : MonoBehaviour
    {
        private float _speed = 0.01f;
    
        // Start is called before the first frame update
        private void Start()
        {
            Debug.Log("Hello driver!");
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(0, 0, 0.1f);
            transform.Translate(0, _speed, 0);
        }
    }
}
