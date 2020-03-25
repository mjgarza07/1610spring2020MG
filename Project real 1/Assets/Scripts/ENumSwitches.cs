using UnityEngine.Events;

using UnityEngine;


public class ENumSwitches : MonoBehaviour
{
    public UnityEvent idleEvent, walkEvent, runEvent, jumpEvent;
    
    public UnityEvent startingEvent, playingEvent, inStoreEvent, pausingEvent, endingEvent;
    
    public enum GameStates
    
    {
        Starting,
        Playing,
        InStore,
        Pausing,
        Ending,
    }

    public GameStates currentGameState;
    
    public enum PlayerStates
    {
        Idle,
        Walk,
        Run,
        Jump
    }

    public PlayerStates currentPlayerState;
   
    public void ChangeStateToStarting ()
    {
        currentGameState = GameStates.Starting;
    }
   
    public void ChangeStateToPlaying ()
    {
        currentGameState = GameStates.Playing;
    }
    public void ChangeStateToPausing ()
    {
        currentGameState = GameStates.Pausing;
    }
    public void ChangeStateToInStore ()
    {
        currentGameState = GameStates.InStore;
    }
    public void ChangeStateToEnding()
    {
        currentGameState = GameStates.Ending;
    }

    void Update()
    {
        switch (currentPlayerState)
        {
            case PlayerStates.Idle:
                idleEvent.Invoke();
                break;
            case PlayerStates.Walk:
                walkEvent.Invoke();
                break;
            case PlayerStates.Run:
                runEvent.Invoke();
                break;
            case PlayerStates.Jump:
                jumpEvent.Invoke();
                break; 
            default:
                print("I am any");
                break;

        }

        switch (currentGameState)
        {
            case GameStates.Starting:
                startingEvent.Invoke();
                break;
            case GameStates.Playing:
                playingEvent.Invoke();
                break;
            case GameStates.Pausing:
                pausingEvent.Invoke();
                break;
            case GameStates.Ending:
                endingEvent.Invoke();
                break;
        }
    }
    
    
    
}



