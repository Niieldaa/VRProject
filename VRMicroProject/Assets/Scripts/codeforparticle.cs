using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
public class codeforparticle : MonoBehaviour
{
    public GameObject ammoPrefab;   
    public Transform spawnPoint;   

    private void Start()
    {
        GetComponent<XRSimpleInteractable>()
            .selectEntered
            .AddListener(OnPressed);
    }

    private void OnPressed(SelectEnterEventArgs args)
    {
        if (ammoPrefab != null && spawnPoint != null)
        {
            Instantiate(ammoPrefab, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
