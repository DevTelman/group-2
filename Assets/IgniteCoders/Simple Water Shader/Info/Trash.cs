using UnityEngine;

public class Trash : MonoBehaviour
{
    public AudioClip destroySound;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)

     
    {
        if (other.CompareTag ("Player"))
        {
           if (audioSource != null && destroySound !=null)
            {
                audioSource.PlayOneShot(destroySound);
                GameManager.instance.AddTrash();
            }
            Destroy(gameObject);
            Debug.Log("Trash Claimed");
        }
        
    
        
    }
}
