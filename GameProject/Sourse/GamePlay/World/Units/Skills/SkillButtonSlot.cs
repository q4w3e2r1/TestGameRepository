﻿#region Includes
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
#endregion
namespace GameProject;

public class SkillButtonSlot
{

    public Animated2d slotIcon;

    public SkillButton skillButton;

    public SkillButtonSlot(Vector2 POS) 
    {
        slotIcon = new Animated2d("2d\\UI\\Icons\\SlotImage", POS, new Vector2(50, 50), new Vector2(1, 1), Color.White);
        skillButton = null;
    
    }

    public virtual void Update(Vector2 OFFSET)
    {
        slotIcon.Update(OFFSET);

        if(skillButton != null)
        {
            skillButton.Update(OFFSET + slotIcon.pos);
        }
    }

    public virtual void Draw(Vector2 OFFSET)
    {
        if(slotIcon != null)
        {
            Globals.normalEffect.Parameters["xSize"].SetValue(1.0f);
            Globals.normalEffect.Parameters["ySize"].SetValue(1.0f);
            Globals.normalEffect.Parameters["xDraw"].SetValue(1.0f);
            Globals.normalEffect.Parameters["yDraw"].SetValue(1.0f);
            Globals.normalEffect.Parameters["filterColor"].SetValue(Color.White.ToVector4());
            Globals.normalEffect.CurrentTechnique.Passes[0].Apply();

            slotIcon.Draw(OFFSET);
        }

        if (skillButton != null)
        {
            skillButton.Draw(OFFSET + slotIcon.pos);
        }

    }


}
