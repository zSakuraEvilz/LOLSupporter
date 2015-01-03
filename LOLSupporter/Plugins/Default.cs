﻿#region LICENSE

// Copyright 2014 - 2014 Support
// Braum.cs is part of Support.
// Support is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// Support is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with Support. If not, see <http://www.gnu.org/licenses/>.

#endregion

#region

using System;
using LeagueSharp;
using LeagueSharp.Common;
using LOLSupporter.Util;

#endregion

namespace LOLSupporter.Plugins
{
    public class Default : PluginBase
    {
        public Default()
        {
            Q = new Spell(SpellSlot.Q, AttackRange);
            W = new Spell(SpellSlot.W, AttackRange);
            E = new Spell(SpellSlot.E, AttackRange);
            R = new Spell(SpellSlot.R, AttackRange);
        }




        public override void OnUpdate(EventArgs args)
        {
            if (ComboMode)
            {
                if (Q.CastCheck(Target, "ComboQ"))
                {
                    Q.Cast(Target, false);
                }
                if (W.CastCheck(Target, "ComboW"))
                {
                    W.Cast(Target, false);
                }
                if (E.CastCheck(Target, "ComboE"))
                {
                    E.Cast(Target, false);
                }

                if (R.CastCheck(Target, "ComboR"))
                {
                    R.Cast(Target, false);
                }
            }
        }

        public override void ComboMenu(Menu config)
        {
            config.AddBool("ComboQ", "Use Q", true);
            config.AddBool("ComboW", "Use W", true);
            config.AddBool("ComboE", "Use E", true);
            config.AddBool("ComboR", "Use R", true);
        }
    }
}