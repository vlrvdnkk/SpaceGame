using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int health = 2;
    //[SerializeField] private Animation anim;
    [SerializeField] private Transform explosion;
    [SerializeField] private AudioClip hitSound;

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.name.Contains("laser"))
        {
            LaserScript laser = theCollision.gameObject.GetComponent("LaserScript") as LaserScript;
            health -= laser.damage;
            Destroy(theCollision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(hitSound);
        }
        if (theCollision.gameObject.name.Contains("cannon base") | theCollision.gameObject.name.Contains("observatory"))
        {
            if (explosion)
            {
                GameObject exploder = ((Transform)Instantiate(explosion, this.transform.position, this.transform.rotation)).gameObject;
                Destroy(exploder, 2.0f);
            }
            Destroy(this.gameObject);
            GameController controller = GameObject.Find("GameController").GetComponent("GameController") as GameController;
            HpBar controllerhp = GameObject.Find("HPbarBase").GetComponent("HpBar") as HpBar;
            controller.KilledEnemy();
            controllerhp.DamagePlayer(25);
        }
        if (health <= 0)
        {
            if (explosion)
            {
                GameObject exploder = ((Transform)Instantiate(explosion, this.transform.position, this.transform.rotation)).gameObject;
                Destroy(exploder, 2.0f);
            }
            //anim.Play("death");
            Destroy(this.gameObject);
            GameController controller = GameObject.Find("GameController").GetComponent("GameController") as GameController;
            controller.KilledEnemy();
            controller.IncreaseScore(25);
        }
    }
}