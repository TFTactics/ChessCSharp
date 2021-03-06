/***************************************************************
 * File: Piece.cs
 * Created By: Justin Grindal		Date: 27 June, 2013
 * Description: A class for the chess piece. It stores the type of chess piece properties
 * like type, power etc. It also contains chess piece methods like
 * get next move, move, etc
 ***************************************************************/

using System;

namespace ChessLibrary 
{
	/// <summary>
	/// A class for the chess piece. It stores the type of chess piece properties
	/// like type, location, power etc. It also contains chess piece methods like
	/// get next move, move, etc
	/// </summary>
    [Serializable]
	public class Piece
	{
		// thuộc tính lớp quân cờ
		int m_moves;            //tổng số không. di chuyển của quân cờ
		Side m_side;            // Bên cờ vua, tức là trắng / đen mà quân cờ này thuộc về
		PieceType m_type;       // loại quân cờ tức là vua, nữ hoàng, v.v.

		public enum PieceType {Empty, King, Queen, Rook, Bishop, Knight, Pawn}; // xác định các loại quân cờ có thể có

		// define attributes for the chess item
		public Piece()
		{
			this.Type = PieceType.Empty;	// default piece is empty i.e. doesn't exists
		}

		// constructore with a given piece type
		public Piece(PieceType type)
		{
			this.m_type = type;
		}

		// constructore with a given piece type and side
		public Piece(PieceType type, Side side)
		{
			this.m_type = type;
			this.m_side = side;
		}

		// Return true if the piece position is empty
		public bool IsEmpty()
		{
			return m_type==PieceType.Empty;
		}

		// Return true if the piece is pawn
		public bool IsPawn()
		{
			return m_type==PieceType.Pawn;
		}

		// Return true if the piece is knight
		public bool IsKnight()
		{
			return m_type==PieceType.Knight;
		}

		// Return true if the piece is bishop
		public bool IsBishop()
		{
			return m_type==PieceType.Bishop;
		}

		// Return true if the piece is rook
		public bool IsRook()
		{
			return m_type==PieceType.Rook;
		}

		// Return true if the piece is queen
		public bool IsQueen()
		{
			return m_type==PieceType.Queen;
		}

		// Return true if the piece is King
		public bool IsKing()
		{
			return m_type==PieceType.King;
		}

		// returns the string for the piece
		public override string ToString()
		{
			switch (m_type)
			{
				case PieceType.King:
					return "King";
				case PieceType.Queen:
					return "Queen";
				case PieceType.Bishop:
					return "Bishop";
				case PieceType.Rook:
					return "Rook";
				case PieceType.Knight:
					return "Knight";
				case PieceType.Pawn:
					return "Pawn";
				default:
					return "E";
			}
		}

		// Returns back weight of the chess peice
		public int GetWeight()
		{
			switch (m_type)
			{
				case PieceType.King:
					return 0;
				case PieceType.Queen:
					return 900;
				case PieceType.Rook:
					return 500;
				case PieceType.Bishop:
					return 325;
				case PieceType.Knight:
					return 300;
				case PieceType.Pawn:
					return 100;
				default:
					return 0;
			}
		}

		#region Class attributes set and get methods
		// Get and set the cell row
		public PieceType Type
		{
			get
			{
				return m_type;
			}
			set
			{
				m_type=value;
			}
		}

		// Get and set the piece side
		public Side Side
		{
			get
			{
				return m_side;
			}
			set
			{
				m_side=value;
			}
		}

		// Get and set the piece moves
		public int Moves
		{
			get
			{
				return m_moves;
			}
			set
			{
				m_moves=value;
			}
		}
		#endregion
	}
}
