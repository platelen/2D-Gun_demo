using UnityEngine;


public class Bullet : MonoBehaviour
{
    [SerializeField] float _speed, _lifeTime;
    [SerializeField] private int _damage = 1;
    public GameObject explosion;

    private void Start()
    {
        Destroy(gameObject, _lifeTime);
    }

    public void Launch(float num)
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * _speed, ForceMode2D.Impulse);
        
    }
    void OnExplode()
    {
        Quaternion randomRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
        Instantiate(explosion, transform.position, transform.rotation);
    }

    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == "Player" && collision.gameObject.tag == "Enemy")
        {
            Health hp = collision.gameObject.GetComponent<Health>();
            hp.TakeDamage(_damage);
            //Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Wall")
        {
            OnExplode();
            Destroy(gameObject);
        }      

    }

}
