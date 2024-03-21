using System.Globalization;
using Raylib_cs;
Raylib.InitWindow(1920,1080,"");
Raylib.SetTargetFPS(60);




Texture2D Fighter1 = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\Theo AIK KUNG.png");
Fighter1.Height = 300;
Fighter1.Width = 600;
Texture2D Fighter2 = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\Theo AIK KUNGEN (1).png");
Fighter2.Height = 320;
Fighter2.Width = 600;
Texture2D backgroundaik = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\Aikbakgrund.png");
backgroundaik.Height = 1920;
backgroundaik.Width = 900;
int game = 0;
int fighter1_hp = 500;
int fighter2_hp = 500;
int fighter1_dm = 10;
int fighter2_dm = 10;
string[] characters = {"NormalTheo", "AikTheo", "TyskTheo", "EldenringTheo"};
characters[0] = "NormalTheo";
characters[1] = "AikTheo";
characters[2] = "TyskTheo";
characters[3] = "EldenringTheo";
bool gubbe1 = false;
bool gubbe2 = false;
string playername = "";
Random random = new Random();
while (!Raylib.WindowShouldClose())
{

    void Damage_Op()
    {
    fighter2_hp -= fighter1_dm;


    }   
    void Damage_player()
    {
    fighter1_hp -= fighter2_dm;
    }

Raylib.BeginDrawing();
    if (game == 2)
    {
        int turn = 0;
        int Fight = 0;
        int fighterhp2 = fighter2_hp; 

        Raylib.DrawRectangle(750, 800, 300, 100, Color.DarkBlue);
          Raylib.ClearBackground(Color.White);
        
        Raylib.DrawText("Fight", 775,800,100,Color.White);
        
        
        //Healthbar me
        Raylib.DrawRectangle(105, 97, 520, 95, Color.Gray);
        Raylib.DrawRectangle(110, 103, fighter1_hp, 80, Color.Red);
        Raylib.DrawText($"{fighter1_hp}", 220,100,75,Color.White);


        //Healthbar enemy
         Raylib.DrawRectangle(1205, 97, 520, 95, Color.Gray);
         Raylib.DrawRectangle(1210, 105, fighterhp2, 80, Color.Red);
         Raylib.DrawText($"{fighterhp2}", 1220,100,75,Color.White);
        
        if (turn == 0 && game == 2)
    {
         if (Raylib.GetMouseX() > 750 && Raylib.GetMouseX() < 1050 && Raylib.GetMouseY() > 750 && Raylib.GetMouseY() < 850)
        {
            if (Raylib.IsMouseButtonUp(MouseButton.Left))
            {
            Fight = 1;
            }
   
        }
        if (Fight == 1)
        {
             Raylib.DrawRectangle(700, 600, 300, 200, Color.DarkBlue);
             Raylib.DrawText("move_1(A)", 720,620,50,Color.White);
             if (Raylib.IsKeyPressed(KeyboardKey.A))
             {
                Damage_Op();
                turn = 1;
             }
    

       
        }
    }
       if (turn == 1 && game == 2)
       {
        
        int moveop = random.Next(1,3);
        if (moveop == 1)
        {
            Damage_player();
        }
        if (moveop == 2)
        {
            Raylib.DrawText("Opp missed his attack", 720, 300, 50,Color.White);
            
        }
        if (moveop == 3)
        {
            Damage_player();
            
        }
       }
        if (gubbe1 == true)
        {
             Raylib.DrawTexture(Fighter1, 75, 200, Color.White);
        }
        if (gubbe2 == true)
        {
            Raylib.DrawTexture(Fighter2, 75, 200, Color.White);
        }
        if (fighter2_hp == 0)
        {
            game = 3;
        }
        if (fighter1_hp == 0)
        {
            game = 3;
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
           playername = "NormieTheo";
        }
   
    }
    if (Raylib.GetMouseX() > 1100 && Raylib.GetMouseX() < 1500 && Raylib.GetMouseY() > 90 && Raylib.GetMouseY() < 330)
    {
        if (Raylib.IsMouseButtonDown(MouseButton.Left))
        {
            game = 2;
           gubbe2 = true; 
           playername = "AIKTHEO";
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

    if (game == 3)
    {
        Raylib.DrawText("Restart{Enter}" , 100, 950, 50, Color.White);
        if (fighter2_hp == 0)
        {
            Raylib.ClearBackground(Color.Black);
            Raylib.DrawText($"{playername} Vann" , 800, 470, 50, Color.White);
        }
        if (fighter1_hp == 0)
        {
            Raylib.ClearBackground(Color.Black);
            Raylib.DrawText($"{playername} Lost" , 800, 470, 50, Color.White);
        }
        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
        game = 1;
        fighter1_hp = 500;
        fighter2_hp = 500;
        gubbe1 = false;
        gubbe2 = false;
        }
    }

    


Raylib.EndDrawing();

}

