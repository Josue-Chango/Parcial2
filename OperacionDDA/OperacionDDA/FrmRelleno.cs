using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionDDA
{
    public partial class FrmRelleno : Form
    {
        private Bitmap _canvasBitmap;
        private Graphics _graphics;
        private Point _lastPoint;
        private bool _isDrawing = false;

        private enum Mode { Drawing, Filling }
        private Mode _currentMode = Mode.Drawing;

        private enum AlgorithmType { FloodFill, BoundaryFill, ScanlineFloodFill }
        private AlgorithmType _selectedAlgorithm;

        private FloodFillStepper _floodFill;
        private BoundaryFillStepper _boundaryFill;
        private ScanlineFloodFillStepper _scanlineFill;

        public FrmRelleno()
        {
            InitializeComponent();
            InitializeCanvas();
        }

        private void InitializeCanvas()
        {
            _canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            _graphics = Graphics.FromImage(_canvasBitmap);
            _graphics.Clear(Color.White);
            picCanvas.Image = _canvasBitmap;

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            _currentMode = Mode.Drawing;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            _currentMode = Mode.Filling;
            _selectedAlgorithm = AlgorithmType.FloodFill;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fillTimer.Stop();
            _graphics.Clear(Color.White);
            picCanvas.Refresh();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentMode == Mode.Drawing)
            {
                _isDrawing = true;
                _lastPoint = e.Location;
            }
            else if (_currentMode == Mode.Filling && e.Button == MouseButtons.Left)
            {
                _floodFill = null;
                _boundaryFill = null;
                _scanlineFill = null;

                switch (_selectedAlgorithm)
                {
                    case AlgorithmType.FloodFill:
                        _floodFill = new FloodFillStepper(_canvasBitmap);
                        _floodFill.StartAlgorithm(e.Location, Color.Red);
                        break;

                    case AlgorithmType.BoundaryFill:
                        _boundaryFill = new BoundaryFillStepper(_canvasBitmap);
                        _boundaryFill.StartAlgorithm(e.Location, Color.Blue);
                        break;

                    case AlgorithmType.ScanlineFloodFill:
                        _scanlineFill = new ScanlineFloodFillStepper(_canvasBitmap);
                        _scanlineFill.StartAlgorithm(e.Location, Color.Green);
                        break;
                }

                fillTimer.Interval = 15; 
                fillTimer.Start();
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_currentMode == Mode.Drawing && _isDrawing)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    _graphics.DrawLine(pen, _lastPoint, e.Location);
                }
                _lastPoint = e.Location;
                picCanvas.Refresh();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;
        }

        private void fillTimer_Tick(object sender, EventArgs e)
        {
            if (_floodFill != null && !_floodFill.IsFinished)
            {
                _floodFill.ProcessStep(10);
                picCanvas.Refresh();
            }
            else if (_boundaryFill != null && !_boundaryFill.IsFinished)
            {
                _boundaryFill.ProcessStep(10);
                picCanvas.Refresh();
            }
            else if (_scanlineFill != null && !_scanlineFill.IsFinished)
            {
                _scanlineFill.ProcessStep(5); 
                picCanvas.Refresh();
            }
            else
            {
                fillTimer.Stop();
            }
        }

        private void btnFill2_Click(object sender, EventArgs e)
        {
            _currentMode = Mode.Filling;
            _selectedAlgorithm = AlgorithmType.BoundaryFill;
        }

        private void btnFill3_Click(object sender, EventArgs e)
        {
            _currentMode = Mode.Filling;
            _selectedAlgorithm = AlgorithmType.ScanlineFloodFill;
        }
    }
}
