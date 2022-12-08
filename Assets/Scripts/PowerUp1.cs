using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp1 : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public float scaleSpeed = 2.0f;
    public float duration = 5.0f;

    void Update() {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
        // add an up and down motion to the powerup
        transform.position += new Vector3(0, Mathf.Sin(Time.time * 5) * 0.1f, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            StartCoroutine(ScalePlayer(player1));
        }
        else if (other.gameObject.CompareTag("Player2"))
        {
            StartCoroutine(ScalePlayer(player2));
        }
    }

    IEnumerator ScalePlayer(Transform player)
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        
        Vector3 targetScale = new Vector3(2.0f, 2.0f, 2.0f);
        float t = 0.0f;

        while (t < 1.0f)
        {
            t += Time.deltaTime * scaleSpeed;
            player.localScale = Vector3.Lerp(player.localScale, targetScale, t);
            yield return null;
        }

        float timer = 0.0f;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        t = 0.0f;
        Vector3 startScale = player.localScale;

        while (t < 1.0f)
        {
            t += Time.deltaTime * scaleSpeed;
            player.localScale = Vector3.Lerp(startScale, Vector3.one, t);
            yield return null;
        }

        player.localScale = Vector3.one;
        Destroy(gameObject);
    }
}
