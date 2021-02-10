using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;
    public PlayerMovement pMovement;


    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
        pMovement.forwardForce = 0f;
        pMovement.sidewaysForce = 0f;
    }


    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Debug.Log("Game Over!");
            
            // Invoke calls a function with a specified delay
            Invoke("restart", restartDelay);
        }
    }

    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
