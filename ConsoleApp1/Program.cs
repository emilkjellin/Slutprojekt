using Raylib_cs;
Raylib.InitWindow(1920,1080,"");
Raylib.SetTargetFPS(60);




Texture2D Fighter1 = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\Theo AIK KUNG.png");
Fighter1.Height = 300;
Fighter1.Width = 600;


int game = 0;
string[] characters = {"NormalTheo", "AikTheo", "TyskTheo", "EldenringTheo"};
while (!Raylib.WindowShouldClose())
{



Raylib.BeginDrawing();
    
    if (game == 1)
    {
     Raylib.ClearBackground(Color.SkyBlue);
    Raylib.DrawTexture(Fighter1, 200, 100, Color.White);
    Raylib.DrawText("NormieTheo", 200,400,100,Color.White);
    
     if (Raylib.GetMouseX() > 200 && Raylib.GetMouseX() < 800 && Raylib.GetMouseY() > 100 && Raylib.GetMouseY() < 430)
    {
        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            game = 2;
            characters = "NormalTheo";
        }
   
    }
    }

if (game == 0)
{
    Raylib.ClearBackground(Color.Black);
    Raylib.DrawText("Start" , 900, 470, 50, Color.White);

    if (Raylib.GetMouseX() > 840 && Raylib.GetMouseX() < 1040 && Raylib.GetMouseY() > 450 && Raylib.GetMouseY() < 510)
    {
        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            game = 1;
        }
   
    }
}    





Raylib.EndDrawing();
}