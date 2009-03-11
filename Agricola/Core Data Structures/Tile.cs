using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace agricola
{
    public abstract class Tile
    {
        private TileTypes type;

        /// <summary>
        /// The type of tile.
        /// </summary>
        public TileTypes Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }

        /// <summary>
        /// Creates a tile of the specified type.
        /// </summary>
        /// <param name="type">The type of tile to create.</param>
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
                case TileTypes.Pasture:
                    return new PastureTile();
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
        private RoomTypes roomType;

        /// <summary>
        /// Creates a new RoomTile.
        /// </summary>
        public RoomTile()
        {
            this.Type = TileTypes.Room;
        }

        /// <summary>
        /// Indicates the type of room this tile represents.
        /// </summary>
        public RoomTypes RoomType
        {
            get
            {
                return this.roomType;
            }
            set
            {
                this.roomType = value;
            }
        }
    }

    public class EmptyTile : Tile
    {
        /// <summary>
        /// Creates a new EmptyTile.
        /// </summary>
        public EmptyTile()
        {
            this.Type = TileTypes.Empty;
        }
    }

    public class FieldTile : Tile
    {
        private bool wasPlantedThisTurn = false;
        private PlantTypes plantType;
        private int plantCount;

        public FieldTile()
        {
            this.Type = TileTypes.Room;
        }

        /// <summary>
        /// Indicates whether the plants on the tile were planted this turn.
        /// </summary>
        public bool WasPlantedThisTurn
        {
            get
            {
                return wasPlantedThisTurn;
            }
            set
            {
                wasPlantedThisTurn = value;
            }
        }

        /// <summary>
        /// The number of plants on the tile.
        /// </summary>
        public int PlantCount
        {
            get
            {
                return this.plantCount;
            }
            set
            {
                this.plantCount = value;
            }
        }

        /// <summary>
        /// The type of plant on the tile.
        /// </summary>
        public PlantTypes PlantType
        {
            get
            {
                return this.plantType;
            }
            set
            {
                this.plantType = value;
            }
        }
    }

    public class PastureTile : Tile
    {
        public PastureTile()
        {
            this.Type = TileTypes.Pasture;
        }
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
