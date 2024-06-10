using System;
using System.Drawing;
using System.Windows.Forms;
using Figures;

namespace Laba7
{
    public partial class Form1 : Form
    {
        private Graphics _panelGraphics;

        private FigureBuilder _figureBuilder;
        private DrawingModes _currentMode;

        public Form1()
        {
            InitializeComponent();
            ResizeBitmap();

            DoubleBuffered = true;
        }
        private void ResizeBitmap()
        {
            _panelGraphics = Graphics.FromHwnd(panel.Handle);

            _figureBuilder = new FigureBuilder(_panelGraphics, panel.Size, GetColor());
        }
        private Color GetColor()
        {
            return Color.FromArgb((int)redUpDown.Value, (int)greenUpDown.Value, (int)blueUpDown.Value); ;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResizeBitmap();
            Invalidate();
        }

        private void OnPanelMouseClicked(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            _figureBuilder.AddPoint(point);

            _figureBuilder.Draw(_currentMode);
            Invalidate();
        }

        private void OnLineModeCheckedChanged(object sender, EventArgs e) => OnModeChanged(DrawingModes.Line);
        private void OnPentagonModeCheckedChanged(object sender, EventArgs e) => OnModeChanged(DrawingModes.Pentagon);
        private void OnEllipseModeCheckedChanged(object sender, EventArgs e) => OnModeChanged(DrawingModes.Ellipse);
        private void OnModeChanged(DrawingModes mode)
        {
            _figureBuilder.ClearPoints();
            _currentMode = mode;
        }

        private void OnFillButtonClicked(object sender, EventArgs e) => _figureBuilder.FillFigure();
        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            _panelGraphics.Clear(panel.BackColor);
            _figureBuilder.ClearFigure(panel.BackColor);
        }

        private void OnUpDownValueChanged(object sender, EventArgs e) => _figureBuilder.color = GetColor();
    }
}