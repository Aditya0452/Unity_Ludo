using UnityEngine;

public class PlayerPiece : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool moveNow;
    public bool isReady;
    public int numberOfStepsToMove;
    public int numberOfStepsAllreadyMove;

    public PathObjectParent pathParent;

    private void Awake()
    {
        // Updated to use the recommended method to find the object
        pathParent = Object.FindFirstObjectByType<PathObjectParent>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
