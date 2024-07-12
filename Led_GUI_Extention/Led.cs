using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Led_GUI_Extention
{
    
    public class Led : CheckBox
    {
        public enum LedType
        {
            Green,
            Blue,
            Red
        }
               
        private LedType ledType = LedType.Red;

        [Category("LedParams")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public LedType Color
        {
            get
            {
                return ledType;
            }
            set
            {
                ledType = value;
                switch (ledType)
                {
                    case LedType.Red:
                        LedOff = ColorTranslator.FromHtml("#CD2626");
                        LedOn = ColorTranslator.FromHtml("#FF0000");
                        break;
                    case LedType.Green:
                        LedOff = ColorTranslator.FromHtml("#009000");
                        LedOn = ColorTranslator.FromHtml("#00EF00");
                        break;
                    case LedType.Blue:
                        LedOff = ColorTranslator.FromHtml("#104E8E");
                        LedOn = ColorTranslator.FromHtml("#00BFFF");
                        break;
                }
            }
        }

        [Category("LedParams")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        public bool DisplayStatus { get; set; }

        private Color LedOn { get; set; } = ColorTranslator.FromHtml("#FF0000");
        private Color LedOff { get; set; } = ColorTranslator.FromHtml("#CD2626");

        // Constructor
        public Led() 
        {
            this.MinimumSize = new Size(10, 10);
            this.MinimumSize = new Size(30, 30);
            this.Size = new Size(30, 30);
        }

        private const string statusOn = "On";
        private const string statusOff = "Off";
        // Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            int arcInerSize = (int)((this.Height - 1)* 3);
            int arcIner2Size = (int)((this.Height - 1) * 2 / 3);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddEllipse(new Rectangle(0, 0, arcSize, arcSize));
            path.AddEllipse(new Rectangle(arcInerSize, arcInerSize, arcIner2Size, arcIner2Size));
            PointF stringLocation = new PointF(3, Size.Height / 2 + 5);
            if (DisplayStatus && this.Size.Height > 10)
            {
                var format = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                if (this.Checked)
                {
                    path.AddString(statusOn, new FontFamily("Arial"), (int)FontStyle.Regular, (int)(Size.Height / 3), new Point(Size.Height / 4 + 3, Size.Height / 2), format);
                }
                else
                {
                    path.AddString(statusOff, new FontFamily("Arial"), (int)FontStyle.Regular, (int)(Size.Height / 3), new Point(Size.Height / 4 + 3, Size.Height / 2), format);
                } 
            }
            
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) // On
            {
                // draw control surface
                pevent.Graphics.FillPath(new SolidBrush(LedOn), GetFigurePath());
            }
            else // Off
            {
                // draw control surface
                pevent.Graphics.FillPath(new SolidBrush(LedOff), GetFigurePath());
            }
        }
    }
}
