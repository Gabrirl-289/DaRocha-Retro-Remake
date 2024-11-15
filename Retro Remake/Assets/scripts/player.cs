
using UnityEngine;

public class player : MonoBehaviour
{
    public bullet bulletPrefab;

    public float reverseThrustSpeed = -1.0f;
    public float thrustSpeed = 1.0f;
    public float turnSpeed = 1.0f;

    private Rigidbody2D _rigidbody;

    private bool _thrusting;

    private bool _revThrusting;

    private float _turnDirection;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _thrusting = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        _revThrusting = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _turnDirection = 1.0f;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { _turnDirection = -1.0f; }
        else
        {
            _turnDirection = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        
            
        
    }

    private void FixedUpdate()
    {
        if (_thrusting)
        {
            _rigidbody.AddForce(this.transform.up * this.thrustSpeed);

        }

        if (_revThrusting) 
        {
            _rigidbody.AddForce(this.transform.up * this.reverseThrustSpeed);
        }


        if (_turnDirection != 0.0f)
        {
            _rigidbody.AddTorque(_turnDirection * this.turnSpeed);
        


        }
    }

    private void Shoot()
    {
      bullet bullet = Instantiate(this.bulletPrefab, this.transform.position, this.transform.rotation);
      bullet.Project(this.transform.up);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            _rigidbody.velocity =  Vector3.zero;
            _rigidbody.angularVelocity = 0.0f;

            this.gameObject.SetActive(false);

            FindObjectOfType<GameManager>().PlayerDied();
        }
    }

}