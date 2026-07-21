
namespace Chess;
// Board is represented using 64 bit board
class Board
{
    public ulong WhitePawns {get; set;} 
    public ulong WhiteKnights {get; set;} 
    public ulong WhiteBishops {get; set;}
    public ulong WhiteRooks {get; set;}
    public ulong WhiteQueens {get; set;}
    public ulong WhiteKing {get; set;}

    public ulong BlackPawns {get; set;}
    public ulong BlackKnights {get; set;}
    public ulong BlackBishops {get; set;}
    public ulong BlackRooks {get; set;}
    public ulong BlackQueens {get; set;}
    public ulong BlackKing {get; set;}
    public ulong WhitePieces { get; set; }
    public ulong BlackPieces { get; set; }
    public ulong AllPieces { get; set; }

    public void InitBoard()
    {
        WhitePawns   = 0x000000000000FF00ul;
        WhiteRooks   = 0x0000000000000081ul;
        WhiteKnights = 0x0000000000000042ul;
        WhiteBishops = 0x0000000000000024ul;
        WhiteQueens  = 0x0000000000000008ul;
        WhiteKing    = 0x0000000000000010ul;

        BlackPawns   = 0x00FF000000000000ul;
        BlackRooks   = 0x8100000000000000ul;
        BlackKnights = 0x4200000000000000ul;
        BlackBishops = 0x2400000000000000ul;
        BlackQueens  = 0x0800000000000000ul;
        BlackKing    = 0x1000000000000000ul;
    }
}