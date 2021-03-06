﻿//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Graphics;
using osu.Game.Graphics;

namespace osu.Game.Overlays.Options.General
{
    public class GeneralSection : OptionsSection
    {
        public override string Header => "General";
        public override FontAwesome Icon => FontAwesome.fa_gear;

        public GeneralSection()
        {
            Children = new Drawable[]
            {
                new LoginOptions(),
                new LanguageOptions(),
                new UpdateOptions(),
            };
        }
    }
}

