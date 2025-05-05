using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{get; private set;}

    public event EventHandler<OnClickedOnGridPositionEventArgs> OnClickedOnGridPosition;
    public class OnClickedOnGridPositionEventArgs : EventArgs{
        public int x;
        public int y;
    }
    private void Awake()
    {
        if(Instance !=null)
        {
            Debug.LogError("More than one Gamemanager Instance");
        }
        Instance = this;
    }
    public void ClickedOnGridPosition(int x, int y)
    {
        OnClickedOnGridPosition?.Invoke(this, new OnClickedOnGridPositionEventArgs{
            x = x,
            y = y
        });
    }
}
