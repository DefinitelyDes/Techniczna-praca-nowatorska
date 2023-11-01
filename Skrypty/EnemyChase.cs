using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float speed = 5f; // Szybkoœæ poruszania siê przeciwnika
    public Transform target; // Gracz, na którego bêdzie szar¿owaæ przeciwnik
    public float chargeCooldown = 2f; // Czas oczekiwania miêdzy szar¿ami
    private bool canCharge = true;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // SprawdŸ odleg³oœæ miêdzy przeciwnikiem a graczem
        if (canCharge)
        {
            // SprawdŸ odleg³oœæ miêdzy przeciwnikiem a graczem
            float distanceToTarget = Vector3.Distance(transform.position, target.position);

            // Jeœli odleg³oœæ jest wiêksza ni¿ pewna wartoœæ, przemieszczaj przeciwnika w stronê gracza
            if (distanceToTarget > 1f)
            {
                // Kierunek, w którym przeciwnik ma siê poruszaæ
                Vector3 moveDirection = (target.position - transform.position).normalized;

                // Porusz przeciwnika w wyznaczonym kierunku
                transform.Translate(moveDirection * speed * Time.deltaTime);
            }
            else
            {
                // Gracz jest wystarczaj¹co blisko, wiêc przeciwnik przestaje szar¿owaæ
                // Uruchom korektê czasow¹ dla ponownej szar¿y
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
