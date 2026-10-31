using System.Collections;
using UnityEngine;

public class BluePlayerPiece : PlayerPiece
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    //Update is called once per frame
    //public void MovePlayer()
    //{
    //   for(int i = 0; i < 5; i++)
    //   {
    //        transform.position = pathParent.CommonPathPoint[i].transform.position;
    //    }
    //}

    public void OnMouseDown()
    {
        if(!isReady) // If the piece is not ready, return
        {
            isReady = true; // Set the piece as ready
            transform.position = pathParent.CommonPathPoint[0].transform.position; // Move to the first point
            numberOfStepsAllreadyMove = 1; // Reset the number of steps already moved
            return;
        }
        // Start the coroutine to move the piece
        StartCoroutine(MoveStep_enm());
    }

    IEnumerator MoveStep_enm()
    {
        numberOfStepsToMove = 5; // Set the number of steps to move
        for (int i = numberOfStepsAllreadyMove; i < (numberOfStepsAllreadyMove+numberOfStepsToMove); i++)
        {
            transform.position = pathParent.CommonPathPoint[i].transform.position;
            yield return new WaitForSeconds(0.35f); // Wait for 1 second before moving to the next point
        }
        numberOfStepsAllreadyMove += numberOfStepsToMove; // Increase the number of steps already moved
    }
}
