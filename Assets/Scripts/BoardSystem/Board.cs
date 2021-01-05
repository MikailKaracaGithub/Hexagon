using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BoardSystem
{ 
public class Board : MonoBehaviour
 {
        private Dictionary<Position, Tile> _tiles = new Dictionary<Position, Tile>();
        public IList<Tile> Tiles => _tiles.Values.ToList();
        private void Start()
        {
            var radius = 5;
            for (var i = 0; i < radius; i++)
            {
                for (var r = -i; r <= i; r++)
                    for (var g = -i; g <= i; g++)
                        for (var b = -i; b <= i; b++)
                            if (Math.Abs(r) + Math.Abs(g) + Math.Abs(b) == i * 2 && r + g + b == 0)
                            {
                                Debug.Log(r + "," + g + "," + b);
                                _tiles.Add(new Position { X = r, Y = g, Z = b }, new Tile(r, g, b));
                            }
                Debug.Log("Coordinates have been generated");
                Debug.Log(Tiles.Count());

            }
        }

    }
}
