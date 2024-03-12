using Raylib_cs;
Raylib.InitWindow(1920,1080,"");
Raylib.SetTargetFPS(60);




Texture2D Fighter1 = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\Theo AIK KUNG.png");
Fighter1.Height = 300;
Fighter1.Width = 600;
Texture2D Fighter2 = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\Theo AIK KUNGEN (1).png");
Fighter2.Height = 320;
Fighter2.Width = 600;

int game = 0;
string[] characters = {"NormalTheo", "AikTheo", "TyskTheo", "EldenringTheo"};
characters[0] = "NormalTheo";
characters[1] = "AikTheo";
characters[2] = "TyskTheo";
characters[3] = "EldenringTheo";
bool gubbe1 = false;
while (!Raylib.WindowShouldClose())
{



Raylib.BeginDrawing();
    if (game == 2)
    {
        Raylib.ClearBackground(Color.White);
        Raylib.DrawRectangle(700, 800, 300, 100, Color.DarkBlue);
        Raylib.DrawText("Fight", 750,800,100,Color.White);
        int fighter1_hp = 100;
        int fighter2_hp = 100;
         if (Raylib.GetMouseX() > 200 && Raylib.GetMouseX() < 800 && Raylib.GetMouseY() > 100 && Raylib.GetMouseY() < 430)
        {
            if (Raylib.IsMouseButtonDown(MouseButton.Left))
            {
            
            }
   
        }
    
        if (gubbe1 == true)
        {
             Raylib.DrawTexture(Fighter1, 300, 400, Color.White);
        }
    }
    if (game == 1)
    {
     Raylib.ClearBackground(Color.SkyBlue);
    Raylib.DrawTexture(Fighter1, 200, 100, Color.White);
    Raylib.DrawTexture(Fighter2, 1100, 90, Color.White);
    Raylib.DrawText("NormieTheo", 200,400,100,Color.White);
    Raylib.DrawText("Aik Theo",1180,400,100,Color.White);

     if (Raylib.GetMouseX() > 200 && Raylib.GetMouseX() < 800 && Raylib.GetMouseY() > 100 && Raylib.GetMouseY() < 430)
    {
        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            game = 2;
           gubbe1 = true; 
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