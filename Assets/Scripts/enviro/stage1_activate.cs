using System.Collections;
using UnityEngine;

public class trigger_script : MonoBehaviour
{
    public GameObject schlucht;
    public GameObject platforms;
    public float moveDistance = 3f;       // Wie weit nach oben/unten bewegen
    public float moveSpeed = 2f;          // Bewegungsgeschwindigkeit
    public float shakeDuration = 0.5f;    // Wie lange wackeln
    public float shakeAmount = 0.3f;      // Stärke des Wackelns

    private bool hasStarted = false;


    void Update()
    {
        
     playerisindernaehe();

    }

 void playerisindernaehe() {


bool kleinerabstand = Vector2.Distance(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position) < 2f;




        if (kleinerabstand && !hasStarted)
        {
            hasStarted = true;
            StartCoroutine(SchluchtShakeAndMove());
        }
        

 }

    IEnumerator SchluchtShakeAndMove()
    {
        // 1 - Wackeln (shake)
        Vector3 originalPos = schlucht.transform.position;

        float elapsed = 0.0f;
        while (elapsed < shakeDuration)
        {
            float offsetX = Random.Range(-1f, 1f) * shakeAmount;
            float offsetY = Random.Range(-1f, 1f) * shakeAmount;
            schlucht.transform.position = originalPos + new Vector3(offsetX, offsetY, 0);

            elapsed += Time.deltaTime;
            yield return null;
        }

        schlucht.transform.position = originalPos;

        // 2 - Nach oben bewegen
        Vector3 schluchtTarget = originalPos + new Vector3(0, moveDistance, 0);
        Vector3 platformsTarget = platforms.transform.position + new Vector3(0, -moveDistance, 0);

        bool moving = true;
        while (moving)
        {
            schlucht.transform.position = Vector3.MoveTowards(schlucht.transform.position, schluchtTarget, moveSpeed * Time.deltaTime);
            platforms.transform.position = Vector3.MoveTowards(platforms.transform.position, platformsTarget, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(schlucht.transform.position, schluchtTarget) < 0.01f && 
                Vector3.Distance(platforms.transform.position, platformsTarget) < 0.01f)
            {
                // Ziel erreicht
                moving = false;
            }
            yield return null;
        }
    }
}