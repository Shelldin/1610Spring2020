
using System;
using UnityEngine;
using UnityEngine.Events;

public class EnumsSwitches : MonoBehaviour
{

    public UnityEvent startingEvent,
        playingEvent,
        pausingEvent,
        endingEvent;

    public UnityEvent idleEvent,
        walkEvent,
        runEvent,
        jumpEvent,
        attackEvent;
    
    public enum GameStates
    {
        Starting,
        Playing,
        Pausing,
        Ending,
    }

    public GameStates currentGameState;

    public enum PlayerStates
    {
        Idle,
        Walk,
        Run,
        Jump,
        Attack
    }

    public PlayerStates currentPlayerState;

    public void ChangeStateToPlaying()
    {
        currentGameState = GameStates.Playing;
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
            case PlayerStates.Attack:
                attackEvent.Invoke();
                break;
            default:
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
            default:
                throw new ArgumentOutOfRangeException();
        }
        
    }
}
