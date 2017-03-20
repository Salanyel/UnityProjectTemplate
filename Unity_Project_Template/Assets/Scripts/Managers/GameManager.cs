using UnityEngine;

/// <summary>
/// Class used to manage the game
/// </summary>
public class GameManager : Singleton<GameManager> {

    #region Public_Attributes

    public bool m_isOnline;

    #endregion

    #region Private_Attributes

    private ENUM_GAMESTATE m_gameState;

    #endregion

    #region Unity_Methods

    void Awake()
    {
        if (!m_isOnline)
        {
            Destroy(GameObject.FindGameObjectWithTag(Tags.m_networkManager));
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Change the game state and modify all behavior in consequences
    /// </summary>
    /// <param name="p_newState">New game state</param>
    public void changeGameState(ENUM_GAMESTATE p_newState)
    {
        exitingGameState(m_gameState);

        m_gameState = p_newState;

        switch (m_gameState)
        {
            default:
                Debug.Log("/ ! \\ No game state defined for the value: " + m_gameState.ToString());
                break;
        }
    }

    /// <summary>
    /// CHange the behavior of the game state before exiting a special state
    /// This function is used to do behavior only present when exiting a specific state
    /// </summary>
    /// <param name="p_currentState"></param>
    void exitingGameState(ENUM_GAMESTATE p_currentState)
    {
        switch (p_currentState)
        {
            default:
                break;
        }
    }

    #endregion

}