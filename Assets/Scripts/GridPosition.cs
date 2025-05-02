using UnityEngine;
using UnityEngine.EventSystems;

public class GridPosition : MonoBehaviour
{
    [SerializeField] private int x;
    [SerializeField] private int y;
    private void OnMouseDown()
    {
        Debug.Log("Click");
    }
}
