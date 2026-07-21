using Raylib_cs;
using Chess;
namespace Game;

class GameRender
{
    private readonly int screenWidth;
    private readonly int screenHeight;
    private readonly int cellSize;

    private readonly Color black;
    private readonly Color white;

    private List<Texture2D> textures;
    public GameRender(int _screenWidth, int _screenHeight, int numCell)
    {
        screenWidth = _screenWidth;
        screenHeight = _screenHeight;
        cellSize = screenHeight/numCell;

        black = Color.Black;
        white = Color.Brown;

        textures = new();
    }

    public void DrawChessBoard()
    {
        for(int row = 7; row >= 0; row--)
        {
            for(int col = 0; col <= 7; col ++)
            {
                Color cellColor = black;
                if((row + col) % 2 == 0)
                    cellColor = white;
                Raylib.DrawRectangle(row * cellSize, col * cellSize, cellSize, cellSize, cellColor);
            }
        }
    }

    public void DrawBitBoard(ulong piece, Image image)
    {
        for(int row = 0; row <= 7; row++)
        {
            for(int col = 0; col <= 7; col ++)
            {
                int square = row * 8  + col;
                ulong set = (piece >> square) & 1ul;
                if(set == 1)
                {
                    Texture2D texture = Raylib.LoadTextureFromImage(image);
                    Raylib.DrawTexture(texture, col * cellSize, row * cellSize, Color.Beige);
                    textures.Add(texture);
                }
            }
        }
    }

    public void Unload()
    {
        foreach(var tex in textures)
        {
            Raylib.UnloadTexture(tex);
        }
    }
}