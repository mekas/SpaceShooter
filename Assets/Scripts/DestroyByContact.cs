using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExplosion;
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }

        if(other.tag == "Player")
        {
            Instantiate(playerExplosion, transform.position, transform.rotation);
        }
        Instantiate(explosion, transform.position, transform.rotation);
        
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
