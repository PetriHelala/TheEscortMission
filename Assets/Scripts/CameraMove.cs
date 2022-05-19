using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Vector3 StartPos;
    Vector3 Destination;

    [SerializeField] GameObject Player;
    void OnTriggerEnter2D(Collider2D C){
        if(C.tag == "Player"){
            StartPos = transform.parent.position;
            Destination = new Vector3(transform.parent.position.x,
                transform.parent.position.y + 20f,
                transform.parent.position.z);

                Player.SendMessage("LockedControls", SendMessageOptions.DontRequireReceiver);
                StartCoroutine(moveCamera());
        }
    }

    IEnumerator moveCamera() {
    float totalMovementTime = 1f;
    float currentMovementTime = 0f;
    while (Vector3.Distance(transform.parent.position, Destination) > 0) {
        currentMovementTime += Time.deltaTime;
        transform.parent.position = Vector3.Lerp(StartPos, Destination, currentMovementTime / totalMovementTime);
        yield return null;
    }
}
}