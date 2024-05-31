using UnityEngine;

namespace Source.Scripts

{
    public class Driver : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 8f;
        [SerializeField] private float steerSpeed = 120f;
    
        // Start is called before the first frame update
        private void Start()
        {
            Debug.Log("Hello driver!");
        }

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(0, 0, -Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime);
            transform.Translate(0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, 0);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("Ouch");
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log(other.name);
        }
    }
}
