using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace agricola
{
    public abstract class Tile
    {

        /// <summary>
        /// The type of tile.
        /// </summary>
        public TileTypes Type
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public static Tile TileFactory( TileTypes type )
        {
            switch( type )
            {
                case TileTypes.Empty:
                    return new EmptyTile();
                case TileTypes.Field:
                    return new FieldTile();
                case TileTypes.Room:
                    return new RoomTile();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    public struct FenceBorder
    {
        public bool Top;
        public bool Bottom;
        public bool Left;
        public bool Right;
    }

    public enum TileTypes
    {
        Empty,
        Field,
        Room,
        Pasture,
    }

    public class RoomTile : Tile
    {
    }

    public class EmptyTile : Tile
    {
    }

    public class FieldTile : Tile
    {
        /// <summary>
        /// Indicates whether the plants on the tile were planted this turn.
        /// </summary>
        public bool WasPlantedThisTurn
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// The number of plants on the tile.
        /// </summary>
        public int PlantCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// The type of plant on the tile.
        /// </summary>
        public PlantTypes PlantType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }

    public class PastureTile : Tile
    {
        /// <summary>
        /// The type of livestock on the tile.
        /// </summary>
        public LivestockTypes LivestockType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// The number of livestock on the tile.
        /// </summary>
        public int LivestockCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Indicates whether the tile has a stable.
        /// </summary>
        public bool HasStable
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Indicates which sides of the tile have fences.
        /// </summary>
        public FenceBorder Fence
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
