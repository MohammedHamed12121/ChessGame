using Raylib_cs;

const int screenWidth = 900;
const int screenHeight = screenWidth;
const int pieces = 8;
const int cellSize = screenHeight / pieces;

Raylib.InitWindow(screenWidth, screenHeight, "Chess Game");

Raylib.SetTargetFPS(60);               

while (!Raylib.WindowShouldClose())    
{
    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.RayWhite);


    Raylib.EndDrawing();
}

Raylib.CloseWindow();        // Close window and OpenGL context


