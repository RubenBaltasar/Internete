using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public static CheckpointController instance;


    [Header("Componentes (checkpoints)")]
    public Checkpoint[] checkpoints;

    public Vector3 puntoReaparecion;

    private void Awake()
    {
        instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // esta en desuso
        //checkpoints = FindObjectsOfType<Checkpoint>();
        checkpoints = FindObjectsByType<Checkpoint>(FindObjectsSortMode.None);

        puntoReaparecion = PlayerHealtController.instance.transform.position;
    }

    // para desactivar checkpoints
    public void DesactivarCheckPoints()
    {
        for ( int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].ResetCheckpoint();
        }
    }

    public void SetpuntoReaparecion(Vector3 newPuntoReaparecion)
    {
        puntoReaparecion = newPuntoReaparecion;
    }
}
