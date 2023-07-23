using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed;
    [SerializeField] private float _horizontalSpeed;

    private void Update()
    {
        Vector3 velocity =  new Vector3();


        velocity.z = _forwardSpeed;
        velocity.x = Input.GetAxis("Horizontal") * _horizontalSpeed; // sol sa� i�in -1 ile 1 aras�nda float de�i�ken tutar yumu�ak ge�i� ayar�n� imput managerden ayarlayabiliriz.

        transform.position += velocity*Time.deltaTime;
        
        
        //Transform tr = GetComponent<Transform>(); // transform.blabla = GetComponent<Transform>() transform i�in kolay bir kullan�m unity bize sa�l�yor.
        //transform.position ile localposition aras�ndaki fark position d�nyaya g�re olan konumu localposition parenti ile aras�ndaki kontrol. e�er bir objenin parenti yoksa ikisi ayn� �ey.
    }//euler angles xyz den olu�an bir a�� temsil eder. euler angleslar�n s�k�nt�lar� olabiliyor o y�zden quaternionlar� �ok karma��k matematiksel i�lemler i�in bazen kullanmay� tercih ediyoruz. 
}
