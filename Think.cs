public class MyBot : IChessBot
{
   static readonly Dictionary<PieceType, int> PieceVals = new Dictionary<PieceType, int> {
{PieceType.Pawn, 130},
{PieceType.Knight, 290},
{PieceType.Bishop, 340},
{PieceType.Rook, 490},
{PieceType.Queen, 890},
{PieceType.King, 0},
{PieceType.None, 0}

   };
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves();
        return moves[0];
    }
}
