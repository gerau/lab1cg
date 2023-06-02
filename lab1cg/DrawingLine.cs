using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1cg
{
    public partial class DrawingLine : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;
        public DrawingLine()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // це для красоти
            InitializeComponent();

            ColorComboBox.MaxDropDownItems = 10;  
            ColorComboBox.IntegralHeight = false;
            ColorComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            ColorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ColorComboBox.DrawItem += ColorComboBox_DrawItem;

            bitmap = new Bitmap(DrawingZone.Width, DrawingZone.Height);
            graphics = Graphics.FromImage(bitmap);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, Color.Black); // заповнюємо все поле малювання чорним кольором
                }
            }
          
            DrawingZone.Image = bitmap;

            ColorComboBox.DataSource = typeof(Color).GetProperties().Where(x => x.PropertyType == typeof(Color)).Select(x => x.GetValue(null)).ToList(); // і це для красоти

        }

        private void ColorComboBox_DrawItem(object sender, DrawItemEventArgs e) // і це теж

        {

            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = ColorComboBox.GetItemText(ColorComboBox.Items[e.Index]);
                var color = (Color)ColorComboBox.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, ColorComboBox.Font, r2,
                    ColorComboBox.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createLineButton_Click(object sender, EventArgs e ) // метод коли ми клікаємо на кпопку
            
        {
            
            Color color = (Color)ColorComboBox.SelectedValue;
            int x = 0;
            int y = 0;
            int xx = 0;
            int yy = 0;
            if(!(int.TryParse(x0.Text, out x) && // перевірка правильності значень
               int.TryParse(y0.Text, out y) &&
               int.TryParse(x1.Text, out xx)&&
               int.TryParse(y1.Text, out yy)))
            {
                MessageBox.Show("Неправильні значення координат.", "Помилка значень");
                return;
            }
            try 
            {
                bitmap.drawLine(x, y, xx, yy, color);
            }
            catch // якщо ловимо помилку, то значить координати не відповідають умовам
            {
                MessageBox.Show($"Неправильні значення координат:поле розміром висотою {bitmap.Height/16 - 1}, та шириною {bitmap.Width/16 - 1} ", "Помилка розміру");
                return;
            }
            DrawingZone.Image = bitmap;
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}