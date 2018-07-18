﻿/*
ImageGlass Project - Image viewer for Windows
Copyright (C) 2018 DUONG DIEU PHAP
Project homepage: http://imageglass.org

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageGlass.Theme
{
    public class ModernMenuRenderer : ToolStripProfessionalRenderer
    {
        public Color ThemeBackgroundColor { get; set; } = Color.White;
        public Color ThemeTextColor { get; set; } = Color.White;

        public ModernMenuRenderer(Color backgroundColor, Color textColor) : base(new ModernColors())
        {
            this.ThemeBackgroundColor = backgroundColor;
            this.ThemeTextColor = textColor;

            
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = this.ThemeTextColor;

            base.OnRenderItemText(e);
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDown dropdown)
            {
                e.Graphics.FillRectangle(new SolidBrush(this.ThemeBackgroundColor), e.AffectedBounds);
            }
            
            base.OnRenderToolStripBackground(e);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            Pen pen = new Pen(this.ThemeTextColor, 1);

            e.Graphics.DrawLine(pen,
                e.Item.Width - (5*e.Item.Height / 8),
                3 * e.Item.Height / 8,
                e.Item.Width - (4 * e.Item.Height / 8),
                e.Item.Height / 2);

            e.Graphics.DrawLine(pen,
                e.Item.Width - (4 * e.Item.Height / 8),
                e.Item.Height / 2,
                e.Item.Width - (5*e.Item.Height / 8),
                5 * e.Item.Height / 8);
        }

        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            Pen pen = new Pen(this.ThemeTextColor, 2);

            e.Graphics.DrawLine(pen,
                2* e.Item.Height / 10 + 1,
                e.Item.Height / 2,
                4 * e.Item.Height / 10 + 1,
                7 * e.Item.Height / 10);

            e.Graphics.DrawLine(pen,
                4 * e.Item.Height / 10,
                7 * e.Item.Height / 10,
                8 * e.Item.Height / 10,
                3 * e.Item.Height / 10);
        }
    }



    public class ModernColors : ProfessionalColorTable
    {

        public override Color MenuItemSelected
        {
            get
            {
                return Color.FromArgb(35, 0, 0, 0);
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return Color.FromArgb(35, 0, 0, 0);
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return Color.Transparent;
            }
        }
        
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.Transparent;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.Transparent;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.Transparent;
            }
        }
        public override Color SeparatorDark
        {
            get
            {
                return Color.FromArgb(35, 0, 0, 0);
            }
        }
        public override Color SeparatorLight
        {
            get
            {
                return Color.FromArgb(0, 0, 0, 0);
            }
        }
        public override Color CheckBackground
        {
            get
            {
                return Color.Transparent;
            }
        }
        public override Color CheckPressedBackground
        {
            get
            {
                return Color.Transparent;
            }
        }
        public override Color CheckSelectedBackground
        {
            get
            {
                return Color.Transparent;
            }
        }
        public override Color ButtonSelectedBorder
        {
            get
            {
                return Color.Transparent;
            }
        }

        public override Color ToolStripDropDownBackground => base.ToolStripDropDownBackground;
    }
}
