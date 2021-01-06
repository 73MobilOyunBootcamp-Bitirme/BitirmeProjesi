using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float mousex = 0;
    public float speed = 5;
    public float min = -3.5f;
    public float max = 3.5f;

    public Vector3 newpos;

    void Update()
    {
        MovePlayer();
    }
    private void MovePlayer()
    {
        if (Input.GetMouseButton(0))
        {
            newpos = this.transform.position;
            mousex = Input.mousePosition.x;
            newpos.x = (mousex * (((max - min) / 2) / (Screen.width / 2)) + min);

            newpos.x = Mathf.Clamp(newpos.x, min, max);

            this.transform.position = Vector3.Lerp(this.transform.position, newpos, Time.deltaTime * speed);

        }
    }
}
