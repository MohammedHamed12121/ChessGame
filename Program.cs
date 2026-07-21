using Raylib_cs;

const int screenWidth = 800;
const int screenHeight = screenWidth;
const int pieces = 8;
const int cellSize = screenHeight / pieces;
const int gap = 1;

Color black =  Color.Black;
Color brown =  Color.Brown;

string blackbishop = "assets/bishop-black.png";
string whitebishop = "assets/bishop-white.png";
string blackking = "assets/king-black.png";
string whiteking = "assets/king-white.png";
string blackknight = "assets/knight-black.png";
string whiteknight = "assets/knight-white.png";
string blackpawn = "assets/pawn-black.png";
string whitepawn = "assets/pawn-white.png";
string blackqueen = "assets/queen-black.png";
string whitequeen = "assets/queen-white.png";
string blackrook = "assets/rook-black.png";
string whiterook = "assets/rook-white.png";

Raylib.InitWindow(screenWidth, screenHeight, "Chess Game");

Image image = Raylib.LoadImage(blackbishop);
Raylib.ImageResize(ref image, cellSize - 3, cellSize -3);
Texture2D texture = Raylib.LoadTextureFromImage(image);

Raylib.SetTargetFPS(60);               

int piecePos = 5;

while (!Raylib.WindowShouldClose())    
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);

    DrawBoard(pieces, cellSize);

    Raylib.DrawTexture(texture, piecePos * cellSize, piecePos * cellSize , Color.White);




    Raylib.EndDrawing();
}

Raylib.CloseWindow();        



void DrawBoard(int numPieces, int cellSize)
{
    for(int i = 0; i < numPieces; i++)
    {
        for(int j = 0; j < numPieces; j++)
        {
            Color cellColor = black;
            if((i + j) % 2 == 0)
                cellColor = brown;
            Raylib.DrawRectangle(i * cellSize, j * cellSize, cellSize, cellSize, cellColor);
        }
    }
}