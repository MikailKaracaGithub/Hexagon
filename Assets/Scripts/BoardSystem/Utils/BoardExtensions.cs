using UnityEngine;

namespace BoardSystem.Utils
{
    public static class BoardExtensions
    {
        public static Vector3 AsVector3(Board board)
        {
           return new Vector3(board.Radius, 1, board.Radius);
        }
    }
}
