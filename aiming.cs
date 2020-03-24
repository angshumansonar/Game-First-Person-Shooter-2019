using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiming : MonoBehaviour
{
    public Transform player, playerspin;
    float xaxixclamp = 0;

    void Update()
    {

        float rotamountx = Input.GetAxis("Mouse X") * 2.5f;
        float rotamounty = Input.GetAxis("Mouse Y") * 2.5f;

        xaxixclamp -= rotamounty;

        Vector3 rotplayerspin = playerspin.transform.rotation.eulerAngles;
        Vector3 rotplayer = player.transform.rotation.eulerAngles;

        rotplayerspin.x -= rotamounty;
        rotplayerspin.z = 0;
        rotplayer.y += rotamountx;

        if (xaxixclamp > 50)
        {
            xaxixclamp = 50;
            rotplayerspin.x = 50;
        }
        else if (xaxixclamp < -50)
        {
            xaxixclamp = -50;
            rotplayerspin.x = -50;
        }

        playerspin.rotation = Quaternion.Euler(rotplayerspin);
        player.rotation = Quaternion.Euler(rotplayer);


    }
}
