global using Raylib_cs;

Raylib.InitWindow(800, 600, "Världens bästa spel");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
  // LOGIK
  // GRAFIK
  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.WHITE);

  Raylib.EndDrawing();
}