using UnityEngine;
using UnityEngine.UI;

public class magia : MonoBehaviour
{
    public GameObject explosion;
    public Text texto;

    public float speed = 4;
    public void PointerClick()
    {
        Instantiate(explosion,transform.position,transform.rotation);
        Destroy(gameObject);
        texto.text=""; 
    }
}
