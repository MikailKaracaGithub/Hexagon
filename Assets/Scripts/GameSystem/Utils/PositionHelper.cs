using BoardSystem;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultPositionHelper", menuName = "GameSystem/PositionHelper")]
public class PositionHelper : ScriptableObject
{
    [SerializeField]
    private Vector3 _tileSize = Vector3.one;
    public Vector3 TileSize => _tileSize;
    public Vector3 ToWorldPosition(Board board, Position boardPosition)
    {
        var boardSize = Vector3.Scale(board.AsVector3(), TileSize);
        var boardOffset = (TileSize - boardSize) / 2;
        boardOffset.y = 0;

        var tilePosition = boardOffset + Vector3.Scale(boardPosition.AsVector3(), TileSize);

        return tilePosition;
    }
}
