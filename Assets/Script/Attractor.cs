using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    public Rigidbody rb;

    public GameObject matahari;
    private Vector3 matahariPosition;
    public GameObject orbit;
    private Vector3 orbitPosition;

    private float bumiMass = 10.0f;
    private float matahariMass = 1000000000.0f;

    Vector3 startVelocity = new Vector3(5f, 0f, 0f);

    public Vector3 calculateForce()
    {
        //find position of the obj
        matahariPosition = matahari.transform.position;
        orbitPosition = orbit.transform.position;

        //jarak antara obj (r)
        float distance = Vector3.Distance(matahariPosition, orbitPosition);

        //jarak pangkat(r^2)
        float distanceSquared = distance * distance;

        //Nilai konstant dari Gravitasi (G)
        float G = 6.67f * Mathf.Pow(10, -11);

        //F=G*m*m/r^2
        float force = G * matahariMass * bumiMass / distanceSquared;

        //merubah gaya dorong dari nilai kedalam 3D Vector dengan arah
        Vector3 forceWithDirection = (force * (matahariPosition - orbitPosition));
        
        return (forceWithDirection);
    }

    void Start()
    {
        rb.AddForce(startVelocity, ForceMode.VelocityChange);
    }

    void Update()
    {
        rb.AddForce(calculateForce(), ForceMode.Impulse);
    }

}
