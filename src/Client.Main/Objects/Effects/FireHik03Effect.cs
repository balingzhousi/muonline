﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Client.Main.Objects.Effects
{
    public class FireHik03Effect : SpriteObject
    {
        public override string TexturePath => $"Effect/firehik03.jpg";

        public FireHik03Effect()
        {
            BlendState = BlendState.Additive;
            LightEnabled = true;
            Light = Vector3.One;
            IsTransparent = true;
            DepthState = DepthStencilState.Default;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
