using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;
using System;
using System.Timers;
Raylib.InitWindow(1920, 1080, "");
Raylib.SetTargetFPS(60);

Texture2D Fighter1 = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\Theo AIK KUNG.png");
Fighter1.Height = 300;
Fighter1.Width = 600;
Texture2D Fighter2 = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\Theo AIK KUNGEN (1).png");
Fighter2.Height = 320;
Fighter2.Width = 600;
Texture2D backgroundaik = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\hockeyarena.png");
backgroundaik.Height = 1080;
backgroundaik.Width = 1920;
Texture2D Donaldopp = Raylib.LoadTexture(@"C:\Users\emil.kjellin\Documents\Programmering 1\Slutprojekt\Bilder\maxdonald.png");
Donaldopp.Height = 300;
Donaldopp.Width = 600;
int game = 0;
int fighter1_hp = 500;
int fighter2_hp = 500;
int fighter1_dmg = 100;
int fighter1_dmgz = 500;
int fighter2_dm = 100;
int Fightermovement = 75;
int attackcap = 0;
int attackcap1 = 0;
//var timer = new System.Timers.Timer(1000);
double timer = 0;
int mvmttimer = 0;
int turn = 0;
bool attacktimer = false;

string[] characters = { "" };

bool gubbe1 = false;
bool gubbe2 = false;
int movement1 = 0;


List<Texture2D> ops = new List<Texture2D>(5);
            ops.Add(Fighter1);
            ops.Add(Fighter2);
        /*Dictionary<string, Texture2D> ops = new Dictionary<string, Texture2D>();
        ops.Add("NormieTheo", Fighter1);
        ops.Add("AikTheo", Fighter2);*/

        Random randint = new Random();
        Texture2D texture = ops[randint.Next(0,2)];
    
Random random = new Random();
while (!Raylib.WindowShouldClose())
{
   

    Raylib.BeginDrawing();
    if (game == 0)
    {
        Raylib.ClearBackground(Color.Black);
        Raylib.DrawText("Start", 900, 470, 50, Color.White);

        if (Raylib.GetMouseX() > 840 && Raylib.GetMouseX() < 1040 && Raylib.GetMouseY() > 450 && Raylib.GetMouseY() < 510)
        {
            if (Raylib.IsMouseButtonDown(MouseButton.Left))
            {
                game = 1;

            }

        }
    }
    if (game == 1)
    {
        Raylib.ClearBackground(Color.SkyBlue);
        Raylib.DrawTexture(Fighter1, 200, 100, Color.White);
        Raylib.DrawTexture(Fighter2, 1100, 90, Color.White);
        Raylib.DrawText("NormieTheo", 200, 400, 100, Color.White);
        Raylib.DrawText("Aik Theo", 1180, 400, 100, Color.White);
        Array.Clear(characters, 0, characters.Length);
        if (Raylib.GetMouseX() > 200 && Raylib.GetMouseX() < 800 && Raylib.GetMouseY() > 100 && Raylib.GetMouseY() < 430)
        {
            if (Raylib.IsMouseButtonDown(MouseButton.Left))
            {
                game = 2;
                gubbe1 = true;
                characters[0] = "NormieTheo";
            }

        }
        if (Raylib.GetMouseX() > 1100 && Raylib.GetMouseX() < 1500 && Raylib.GetMouseY() > 90 && Raylib.GetMouseY() < 330)
        {
            if (Raylib.IsMouseButtonDown(MouseButton.Left))
            {
                game = 2;
                gubbe2 = true;
                characters[0] = "AIKTHEO";
            }

        }
    }




    if (game == 2)
    {
        
        


        if (game == 2)
        {
            timer += 1;
        }

        int Fight = 0;
        int fighterhp2 = fighter2_hp;
        
        
        
        Raylib.DrawTexture(texture, 1200, 200, Color.White);
        Raylib.DrawRectangle(750, 800, 300, 100, Color.DarkBlue);
        Raylib.ClearBackground(Color.White);
        //Raylib.DrawTexture(backgroundaik, 0, 0, Color.Black);
        Raylib.DrawText($"Time:{((timer / 100))}", 700, 100, 100, Color.Black);
        Raylib.DrawText("Fight", 775, 800, 100, Color.White);


        //Healthbar dig
        Raylib.DrawRectangle(105, 97, 520, 95, Color.Gray);
        Raylib.DrawRectangle(110, 103, fighter1_hp, 80, Color.Red);
        Raylib.DrawText($"{fighter1_hp}", 220, 100, 75, Color.White);


        //Healthbar motståndare
        Raylib.DrawRectangle(1205, 97, 520, 95, Color.Gray);
        Raylib.DrawRectangle(1210, 105, fighterhp2, 80, Color.Red);
        Raylib.DrawText($"{fighterhp2}", 1220, 100, 75, Color.White);
        
        
        
        
        
        
        
        
        if (timer < 500)
        {
            if (turn == 0 && game == 2)
            {

                if (Raylib.GetMouseX() > 750 && Raylib.GetMouseX() < 1050 && Raylib.GetMouseY() > 750 && Raylib.GetMouseY() < 850)
                {
                    if (attackcap == 0)
                    {

                        if (Raylib.IsMouseButtonUp(MouseButton.Left))
                        {
                            Fight = 1;

                        }
                    }
                }


                if (attacktimer == true)
                {
                    playermovement();
                }
                if (turn == 1)
                {
                    attacktimer = false;
                }



                if (Fight == 1)
                {
                    Raylib.DrawRectangle(700, 600, 500, 400, Color.DarkBlue);
                    Raylib.DrawText("normal punch(A)", 720, 620, 50, Color.White);

                    if (Raylib.IsKeyPressed(KeyboardKey.A))
                    {

                        Damage_Op();
                        attackcap = 1;
                        attacktimer = true;
                    }
                   
                   
                    if (movement1 == 1)
                    {
                        playermovement();

                    }
                    if (movement1 == 0)
                    {

                        Fightermovement = 75;
                    }
                    



                    if (gubbe2 == true && Fight == 1)
                    {
                        Raylib.DrawText("AIK CHANT(Z)", 720, 720, 50, Color.White);
                        //string[] move2 = {"AIK CHANT", "Gnagets Bite of 87", "Gynges snipe", "Bagendas bråkavslutare"};
                        //    move2[0] = "AIK CHANT";
                        //   move2[1] = "Gnagets Bite of 87";
                        //   move2[2] = "Gynges snipe";
                        //  move2[3] = "Bagendas bråkavslutare";
                        if (Raylib.IsKeyPressed(KeyboardKey.Z))
                        {
                            // fighter1_dm[0] = 200;
                            Damage_Opz();
                            attackcap = 1;
                            attacktimer = true;
                        }
                    }


                }
            }
        }
        if (timer > 500)
        {
            if (game == 2)
            {
                turn = 1;
                int moveop = random.Next(1, 3);
                if (attackcap1 == 0)
                {
                    if (moveop == 1)
                    {
                        Damage_player();
                        attackcap1 = 1;

                    }
                    if (moveop == 2)
                    {
                        Raylib.DrawText("Opp missed his attack", 720, 300, 50, Color.White);
                        attackcap1 = 1;
                    }
                    if (moveop == 3)
                    {
                        Damage_player();
                        attackcap1 = 1;
                    }
                }
            }
        }
        if (gubbe1 == true)
        {
            Raylib.DrawTexture(Fighter1, Fightermovement, 200, Color.White);
        }
        if (gubbe2 == true)
        {

            Raylib.DrawTexture(Fighter2, Fightermovement, 200, Color.White);
        }
        if (fighter2_hp <= 0)
        {
            game = 3;
        }
        if (fighter1_hp <= 0 )
        {
            game = 3;
        }

        if (timer == 1000 || game == 3)
        {
            timer = 0;
            attackcap = 0;
            mvmttimer = 0;
            attacktimer = false;
            turn = 0;
            movement1 = 0;

        }
    }




    if (game == 3)
    {
        Raylib.DrawText("Restart{Enter}", 100, 950, 50, Color.White);
        if (fighter2_hp <= 0)
        {
            Raylib.ClearBackground(Color.Black);
            Raylib.DrawText($"{characters[0]} Vann", 800, 470, 50, Color.White);
            texture = ops[randint.Next(0,2)];
        }
        if (fighter1_hp <= 0)
        {
            Raylib.ClearBackground(Color.Black);
            Raylib.DrawText($"{characters[0]} Lost", 800, 470, 50, Color.White);
            texture = ops[randint.Next(0,2)];
        }
        if (Raylib.IsKeyPressed(KeyboardKey.Enter))
        {
            game = 1;
            fighter1_hp = 500;
            fighter2_hp = 500;
            gubbe1 = false;
            gubbe2 = false;
            movement1 = 0;
            
        }
    }



    Raylib.EndDrawing();

}

void Damage_Op()
    {
        fighter2_hp -= fighter1_dmg;
        movement1 = 1;
    }
    void Damage_Opz()
    {
        fighter2_hp -= fighter1_dmgz;
        movement1 = 1;
    }
    void Damage_player()
    {
        fighter1_hp -= fighter2_dm;
    }
    void playermovement()
    {

        mvmttimer += 1;
        if (mvmttimer < 10)
        {
            Fightermovement += 500;

        }
        if (mvmttimer > 10)
        {
            Fightermovement = 75;
        }
    }