using UnityEngine;
using System.Collections;

public class OpeningDoor : MonoBehaviour {

    public float     finalAngle = 90;
    public float     speed      = 4;
    public bool      rotating;
    public Transform pivot;

    public void FixedUpdate() {
        if (!rotating) return;

        transform.RotateAround(pivot.position, transform.up, speed);

        if (speed < 0) {
            if (transform.eulerAngles.y <= finalAngle)
                rotating = false;
        } else {
            if (transform.eulerAngles.y >= finalAngle)
                rotating = false;
        }
    }


    public void OnCollisionEnter(Collision hit) {
        print("Collided");
        if (hit.gameObject.tag == "Player") {
            print("Player");
            if (!rotating)
                rotating = true;
        }
    }
}
