using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public GameManager Gm;
    public GameObject BulletPrefab;
    public float Speed = 10f;
    public float XLimit = 7f;
    public float ReloadTime = 0.5f;

    private float _elapseTime = 0f;


    void Update()
    {
        _elapseTime += Time.deltaTime;

        float xInput = Input.GetAxis("Horizontal");
        transform.Translate(xInput * Speed * Time.deltaTime, 0f, 0f);

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -XLimit, XLimit);
        transform.position = position;

        if (Input.GetButtonDown("Jump") && _elapseTime > ReloadTime)
        {
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3 (0.5f, 1.2f, 0);
            Vector3 spawnPosSecond = transform.position;
            spawnPosSecond += new Vector3(-0.5f, 1.2f, 0);
            Instantiate(BulletPrefab, spawnPos, Quaternion.identity);
            Instantiate(BulletPrefab, spawnPosSecond, Quaternion.identity);

            _elapseTime = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Gm.PlayeSubtrackLive();
        Destroy(collision.gameObject);
    }


}
