using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float deltaX;
    [SerializeField] private float speed = 7f;

    private void FixedUpdate() {
        transform.position += Vector3.forward * Time.fixedDeltaTime * speed;
        deltaX = transform.position.x;
        deltaX = Mathf.Clamp(deltaX, -2f, 2f);

        transform.position = new Vector3(deltaX, transform.position.y, transform.position.z);

        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            Vector3 touchPos = touch.position;

            if(touchPos.x < Screen.width/2){
                transform.position += Vector3.left * Time.fixedDeltaTime * speed;
            }
            else if(touchPos.x > Screen.width/2){
                transform.position += Vector3.right * Time.fixedDeltaTime * speed;
            }
        }
    }
}
