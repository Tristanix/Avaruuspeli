﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeClubShmup1.Components;
using CodeClubShmup1.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using CodeClubShmup1.Objects;

namespace CodeClubShmup1.Scenes
{
    class MenuScene : SceneParent
    {
        Button button1;

        public MenuScene()
            : base()
        {
           button1 = new Button(Resources.GetTexture("Button"),
             new Vector2(100,100),
            "Nappula!",
                Resources.GetFont("CSfont")
                    );
           button1.OnButtonPressed += onButton1Press;
        }

        public override void Update(float dt)
        {
            base.Update(dt);

            button1.Update(dt);

            if (Input.IsKeyPressed(Keys.M))
            {
                SceneSys.CloseCurrentScene();
                SceneSys.PauseCurrentScene(false);
            }
        }

        public override void Draw()
        {
            DrawSys.DrawText("GAEM TITLE", Resources.GetFont("CSfont"),
                new Vector2 (100,100),Color.Red);

            button1.Draw();
        }

        void onButton1Press()
        {
            SceneSys.CloseCurrentScene();
            SceneSys.PauseCurrentScene(false);
        }
    }
}
