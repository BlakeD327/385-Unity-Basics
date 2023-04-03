using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;
    public SpriteRenderer destination;
    private float speed = 10f;
    
    private void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) > 5f) {

            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, 
                player.transform.position, step);
        }

        if (Vector2.Distance(transform.position, player.transform.position) > 0.7f) {

            float step = (speed/2) * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, 
                player.transform.position, step);
        }
    }    
}
