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
        velocity.x = Input.GetAxis("Horizontal") * _horizontalSpeed; // sol sað için -1 ile 1 arasýnda float deðiþken tutar yumuþak geçiþ ayarýný imput managerden ayarlayabiliriz.

        transform.position += velocity*Time.deltaTime;
        
        
        //Transform tr = GetComponent<Transform>(); // transform.blabla = GetComponent<Transform>() transform için kolay bir kullaným unity bize saðlýyor.
        //transform.position ile localposition arasýndaki fark position dünyaya göre olan konumu localposition parenti ile arasýndaki kontrol. eðer bir objenin parenti yoksa ikisi ayný þey.
    }//euler angles xyz den oluþan bir açý temsil eder. euler angleslarýn sýkýntýlarý olabiliyor o yüzden quaternionlarý çok karmaþýk matematiksel iþlemler için bazen kullanmayý tercih ediyoruz. 
}
