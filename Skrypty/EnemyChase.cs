using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float speed = 5f; // Szybko�� poruszania si� przeciwnika
    public Transform target; // Gracz, na kt�rego b�dzie szar�owa� przeciwnik
    public float chargeCooldown = 2f; // Czas oczekiwania mi�dzy szar�ami
    private bool canCharge = true;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Sprawd� odleg�o�� mi�dzy przeciwnikiem a graczem
        if (canCharge)
        {
            // Sprawd� odleg�o�� mi�dzy przeciwnikiem a graczem
            float distanceToTarget = Vector3.Distance(transform.position, target.position);

            // Je�li odleg�o�� jest wi�ksza ni� pewna warto��, przemieszczaj przeciwnika w stron� gracza
            if (distanceToTarget > 1f)
            {
                // Kierunek, w kt�rym przeciwnik ma si� porusza�
                Vector3 moveDirection = (target.position - transform.position).normalized;

                // Porusz przeciwnika w wyznaczonym kierunku
                transform.Translate(moveDirection * speed * Time.deltaTime);
            }
            else
            {
                // Gracz jest wystarczaj�co blisko, wi�c przeciwnik przestaje szar�owa�
                // Uruchom korekt� czasow� dla ponownej szar�y
                canCharge = false;
                Invoke("ResetCharge", chargeCooldown);
            }
        }
    }
    void ResetCharge()
    {
        canCharge = true;
    }
}
