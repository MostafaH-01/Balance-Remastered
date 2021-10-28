using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnFall : MonoBehaviour
{
    [SerializeField]
    string objTag;

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.tag == objTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
