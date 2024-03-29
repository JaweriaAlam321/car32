﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDesktop
{
    class Animation : Control
    {
        private Timer timer = new Timer();
        private bool slide;
        private int a;
        private bool art = false;
        public Animation()
        {
            base.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint, true);
            this.AutoSize = false;
            base.Width = 30;
            base.Height = 15;
            this.a = 0;
            this.timer.Tick += new EventHandler(this.timer_Tick);
            this.slide = false;
            this.timer.Enabled = false;
        }
        protected override void Dispose(bool disposing)
        {
            this.timer.Stop();
            base.Dispose(disposing);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.Invalidate();
            base.OnBackColorChanged(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.Invalidate();
            base.OnForeColorChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush;
            using (brush = (Brush)new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(brush, base.ClientRectangle);
            }
            Size size = TextRenderer.MeasureText(this.Text, this.Font);
            int num = (base.Height / 2) - (size.Height / 2);
            using (brush = (Brush)new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, brush, (float)this.a, (float)num);
            }
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            this.timer.Enabled = true;
            base.OnResize(e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(this.Text, this.Font);
            if (size.Width <= base.Width)
            {
                this.timer.Stop();
                this.a = 1;
                base.Invalidate();
            }
            else
            {
                int num = (size.Width >= base.Width) ? (size.Width - base.Width) : 0;
                if (this.a >= 1)
                {
                    this.art = false;
                }
                if (-this.a >= (num + this.Font.Height))
                {
                    this.art = true;
                }
                this.a = this.art ? (this.a + 1) : (this.a - 1);
                base.Invalidate();
            }
        }
        public int SlideTime
        {
            get =>
                this.timer.Interval;
            set
            {
                this.timer.Interval = value;
                base.Invalidate();
            }
        }

        public bool Slide
        {
            get =>
                this.slide;
            set
            {
                this.slide = true;
                this.timer.Enabled = this.slide;
                if (!this.slide)
                {
                    this.a = 0;
                    base.Invalidate();
                }
            }
        }

        public override string Text
        {
            get =>
                base.Text;
            set
            {
                base.Text = value;
                this.timer.Start();
            }
        }
    }
}
