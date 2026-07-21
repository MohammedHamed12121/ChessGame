using Chess;
using Game;
using Raylib_cs;

const int screenWidth = 800;
const int screenHeight = screenWidth;
const int numCell = 8;
const int cellSize = screenHeight/numCell;

Image blackbishop   = Raylib.LoadImage( "assets/bishop-black.png");
Image whitebishop   = Raylib.LoadImage( "assets/bishop-white.png");
Image blackking     = Raylib.LoadImage( "assets/king-black.png");
Image whiteking     = Raylib.LoadImage( "assets/king-white.png");
Image blackknight   = Raylib.LoadImage( "assets/knight-black.png");
Image whiteknight   = Raylib.LoadImage( "assets/knight-white.png");
Image blackpawn     = Raylib.LoadImage("assets/pawn-black.png");
Image whitepawn     = Raylib.LoadImage( "assets/pawn-white.png");
Image blackqueen    = Raylib.LoadImage("assets/queen-black.png");
Image whitequeen    = Raylib.LoadImage( "assets/queen-white.png");
Image blackrook     = Raylib.LoadImage( "assets/rook-black.png");
Image whiterook     = Raylib.LoadImage( "assets/rook-white.png");

Raylib.ImageResize(ref blackbishop, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref whitebishop, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref blackking, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref whiteking, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref blackknight, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref whiteknight, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref blackpawn, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref whitepawn, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref blackqueen, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref whitequeen, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref blackrook, cellSize - 3, cellSize -3);
Raylib.ImageResize(ref whiterook, cellSize - 3, cellSize -3);

Raylib.InitWindow(screenWidth, screenHeight, "Chess Game");

Raylib.SetTargetFPS(60);               


while (!Raylib.WindowShouldClose())    
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);

    Board board = new Board();
    board.InitBoard();
    GameRender render = new GameRender(screenWidth, screenHeight, numCell);
    render.DrawChessBoard();

    render.DrawBitBoard(board.WhiteBishops, whitebishop);
    render.DrawBitBoard(board.WhiteKing, whiteking);
    render.DrawBitBoard(board.WhiteKnights, whiteknight);
    render.DrawBitBoard(board.WhitePawns, whitepawn);
    render.DrawBitBoard(board.WhiteQueens, whitequeen);
    render.DrawBitBoard(board.WhiteRooks, whiterook);
    render.DrawBitBoard(board.BlackBishops, blackbishop);
    render.DrawBitBoard(board.BlackKing, blackking);
    render.DrawBitBoard(board.BlackKnights, blackknight);
    render.DrawBitBoard(board.BlackPawns, blackpawn);
    render.DrawBitBoard(board.BlackQueens, blackqueen);
    render.DrawBitBoard(board.BlackRooks, blackrook);


    Raylib.EndDrawing();
    render.Unload();
}

Raylib.UnloadImage(blackbishop);
Raylib.UnloadImage(whitebishop);
Raylib.UnloadImage(blackking);
Raylib.UnloadImage(whiteking);
Raylib.UnloadImage(blackknight);
Raylib.UnloadImage(whiteknight);
Raylib.UnloadImage(blackpawn);
Raylib.UnloadImage(whitepawn);
Raylib.UnloadImage(blackqueen);
Raylib.UnloadImage(whitequeen);
Raylib.UnloadImage(blackrook);
Raylib.UnloadImage(whiterook);

Raylib.CloseWindow();        