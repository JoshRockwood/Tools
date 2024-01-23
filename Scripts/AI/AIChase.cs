using UnityEngine;

public class AIChase : MonoBehaviour
{
   public GameObject player;
   public float speed;
   public float distanceBetween;
   private float distance;
   public string playerTag = "Player";
   private bool hasTouchedPlayer = false;

   void Update()
   {
    if (!hasTouchedPlayer)
        {
            MoveEnemy();
        }
   }

   void MoveEnemy()
   {
    GameObject player = GameObject.FindGameObjectWithTag(playerTag);

    distance = Vector3.Distance(transform.position, player.transform.position);
    Vector3 direction = player.transform.position - transform.position;
    direction.Normalize();

    if (distance < distanceBetween)
    {
        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
   }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasTouchedPlayer = true;
        }
    }
}
