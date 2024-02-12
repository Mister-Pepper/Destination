using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sphere : MonoBehaviour
{

    private Player thePlayer;
    public TextMeshPro tm;
    public GameObject destinationGO;
    public float speed = .01f;

    // Start is called before the first frame update
    void Start()
    {

        this.thePlayer = new Player("Alex");
        tm.text = this.thePlayer.getName() + " -> " + this.thePlayer.getHp();
        this.tm.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);

    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        this.thePlayer.display();

        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, this.destinationGO.transform.position, speed);

    }
}
