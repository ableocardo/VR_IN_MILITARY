using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class COMPORT : MonoBehaviour
{
      SerialPort sp= new SerialPort("COM6", 38400);
    public static string s;



    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }
    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                
                sp.Write(s);
            }
            catch (System.Exception)
            {
                //return null;
            }
        }
    }

}