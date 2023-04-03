using UnityEngine;

public class BombBehavior : MonoBehaviour
{
    public void DetonateBomb()
    {
        GameObject blast = Instantiate(Resources.Load("Prefabs/BlastRadius") as GameObject);
        Vector3 p = this.transform.position;
        blast.transform.position = p;
        if(this.gameObject.tag == "Destroyable") {
            Destroy(this.gameObject);
        }
        if(this.gameObject.tag == "Explodable") {
            
        }
    }
}
