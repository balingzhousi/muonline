﻿using Client.Data;
using Client.Main.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Threading.Tasks;

namespace Client.Main.Objects.Worlds.Lorencia
{
    public class StrawObject : ModelObject
    {
        public StrawObject()
        {
            LightEnabled = true;
        }

        public override async Task Load()
        {
            var idx = (Type - (ushort)ModelType.Straw01 + 1).ToString().PadLeft(2, '0');
            Model = await BMDLoader.Instance.Prepare($"Object1/Straw{idx}.bmd");
            await base.Load();
        }

        public override void DrawMesh(int mesh)
        {
            if (Type == 102)
            {
                BlendState = new BlendState
                {
                    ColorSourceBlend = Blend.One,
                    ColorDestinationBlend = Blend.Zero,
                    AlphaSourceBlend = Blend.One,
                    AlphaDestinationBlend = Blend.Zero,
                    ColorBlendFunction = BlendFunction.Add,
                    AlphaBlendFunction = BlendFunction.Add
                };

                GraphicsDevice.DepthStencilState = new DepthStencilState
                {
                    DepthBufferEnable = true,
                    DepthBufferWriteEnable = true,
                    DepthBufferFunction = CompareFunction.LessEqual
                };
            }

            base.DrawMesh(mesh);

            BlendState = Blendings.Alpha;
            GraphicsDevice.DepthStencilState = DepthStencilState.Default;
        }
    }
}
