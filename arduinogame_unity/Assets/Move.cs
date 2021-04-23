using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    // change your serial port
    SerialPort sp = new SerialPort("/dev/tty.usbmodem14101", 9600);

    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 100; // In my case, 100 was a good amount to allow quite smooth transition. 
    }

    // Update is called once per frame
    //0-100 , 101-159, 160-255 for potentiometer (potentiometer can produce value 0-255), 0, 11,22, 32, 136, 255(nothing pressed) for octokeypad
    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                // Move cube left
                if (sp.ReadByte() >= 0 && sp.ReadByte() <=8 )
                    //if (sp.ReadByte() >= 0 && sp.ReadByte() <=100 )
                {
                    print(sp.ReadByte());
                    transform.Translate(Vector3.left * Time.deltaTime * 5);
                }
                
                // dont move cube (for potentiometer)
                if (sp.ReadByte() >= 19 && sp.ReadByte() <= 255)
                //if (sp.ReadByte() >= 101 && sp.ReadByte() <=159 )

                {
                    print(sp.ReadByte());
                    transform.Translate(0, 0, 0);

                }
                // Move cube right 
                if (sp.ReadByte() >=9 && sp.ReadByte() <= 18)
                //if (sp.ReadByte() >= 160 && sp.ReadByte() <=255 )

                {
                    print(sp.ReadByte());
                    transform.Translate(Vector3.right * Time.deltaTime * 5);
               
                }
            }
            catch (System.Exception)
            {

            }

        }
    }
}
