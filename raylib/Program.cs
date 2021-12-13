using System;

using Raylib_cs;


Raylib.InitWindow(800, 600, "Topsdownspel");
Raylib.SetTargetFPS(60);


Rectangle playerRect = new Rectangle(30, 90, 32, 32);


float speed = 10.5f;

Texture2D playerImage = Raylib.LoadTexture("tank.png");

while (Raylib.WindowShouldClose() == false)
{
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        playerRect.x += speed;

    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        playerRect.x -= speed;

    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        playerRect.y -= speed;

    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        playerRect.y += speed;

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.BROWN);
    //  Raylib.DrawRectangle(30, 45, 50, 80, Color.BEIGE LIME);
    Raylib.DrawRectangleRec(playerRect, Color.LIME);
    Raylib.DrawTexture(playerImage, (int)playerRect.x, (int)playerRect.y, Color.WHITE);

    Raylib.EndDrawing();

}
