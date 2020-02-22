using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

namespace ImageEditor
{
    public partial class bValue : Form
    {
        public bValue()
        {
            InitializeComponent();
            m_Bitmap = new Bitmap(2, 2);
        }

        /// <summary>
        /// Metoda za pomocą której nastąpi utworzenia miejsca na komputerze żeby otworzyć zdjęcie
        /// </summary>
        void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        }

        /// <summary>
        /// Metoda dla filtrów wykorzystywanych przy zmianach zdjęcia, jest wykorzystywana w każdym w filtrów
        /// </summary>
        public void reload()
        {
            if (!opened)
            {
                MessageBox.Show("Otworz zdjęcie, potem zastosuj zmiany");
            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    opened = true;
                }
            }
        }

        /// <summary>
        /// Metoda dla przycisku filtru "Kraków" opisująca działanie filtru i wykorzystanie zmiany koloru oryginalnego zdjęcia
        /// </summary>
        void krakow()
        {
            if (!opened)
            {
                MessageBox.Show("Otworz zdjęcie, potem zastosuj zmiany");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInv = new Bitmap(img.Width, img.Height);

                ImageAttributes iAttributes = new ImageAttributes();
                ColorMatrix cmPic = new ColorMatrix(new float[][]
                {
                new float[]{.393f, .349f+0.5f, .272f, 0, 0},
                new float[]{.769f+0.3f, .686f, .534f, 0, 0},
                new float[]{.189f, .168f, .131f+0.5f, 0, 0},
                new float[]{0, 0, 0, 1, 0},
                new float[]{0, 0, 0, 0, 1}
                });
                iAttributes.SetColorMatrix(cmPic);
                Graphics graph = Graphics.FromImage(bmpInv);

                graph.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, iAttributes);


                graph.Dispose();
                pictureBox1.Image = bmpInv;

            }
        }

        /// <summary>
        /// Metoda dla przycisku filtru "Warszawa" opisująca działanie filtru i wykorzystanie zmiany koloru oryginalnego zdjęcia
        /// </summary>
        void warszawa()
        {
            if (!opened)
            {
                MessageBox.Show("Otworz zdjęcie, potem zastosuj zmiany");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInv = new Bitmap(img.Width, img.Height);

                ImageAttributes iAttributes = new ImageAttributes();
                ColorMatrix cmPic = new ColorMatrix(new float[][]
                {
                 new float[]{.53f, .39f, 0, 0, 0},
                 new float[]{.769f+0.3f, .986f, .534f, 0, 0},
                 new float[]{.189f, .168f, .131f+0.5f, 0, 0},
                 new float[]{0, 0, 0, 1, 0},
                 new float[]{0, 0, 0, 0, 1}
                });
                iAttributes.SetColorMatrix(cmPic);
                Graphics graph = Graphics.FromImage(bmpInv);

                graph.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, iAttributes);


                graph.Dispose();
                pictureBox1.Image = bmpInv;

            }
        }
        /// <summary>
        /// Metoda dla przycisku filtru "Opole" opisująca działanie filtru i wykorzystanie zmiany koloru oryginalnego zdjęcia
        /// </summary>
        void opole()
        {
            if (!opened)
            {
                MessageBox.Show("Otworz zdjęcie, potem zastosuj zmiany");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInv = new Bitmap(img.Width, img.Height);

                ImageAttributes iAttributes = new ImageAttributes();
                ColorMatrix cmPic = new ColorMatrix(new float[][]
                {
                 new float[]{1+0.299f, 0, 0, 0, 0},
                 new float[]{0, 1+0.001f, 0, 0, 0},
                 new float[]{0, 0, 1+3f, 0, 0},
                 new float[]{0, 0.2f, 0, 1, 0},
                 new float[]{0, 0, 0, 0, 1}
                });
                iAttributes.SetColorMatrix(cmPic);
                Graphics graph = Graphics.FromImage(bmpInv);

                graph.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, iAttributes);


                graph.Dispose();
                pictureBox1.Image = bmpInv;

            }
        }
        /// <summary>
        /// Metoda dla przycisku filtru "Katowice" opisująca działanie filtru i wykorzystanie zmiany koloru oryginalnego zdjęcia
        /// </summary>
        void katowice()
        {
            if (!opened)
            {
                MessageBox.Show("Otworz zdjęcie, potem zastosuj zmiany");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInv = new Bitmap(img.Width, img.Height);

                ImageAttributes iAttributes = new ImageAttributes();
                ColorMatrix cmPic = new ColorMatrix(new float[][]
                {
                 new float[]{1+0.345f, 0, 0, 0, 0},
                 new float[]{0, 1+0.780f, 0, 0, 0},
                 new float[]{0, 0, 1+1.120f, 0, 0},
                 new float[]{0, 0.2f, 0, 1, 0},
                 new float[]{0, 0, 0, 0, 1}
                });
                iAttributes.SetColorMatrix(cmPic);
                Graphics graph = Graphics.FromImage(bmpInv);

                graph.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, iAttributes);

                graph.Dispose();
                pictureBox1.Image = bmpInv;

            }
        }
        /// <summary>
        /// Metoda dla przycisku filtru "Wroclaw" opisująca działanie filtru i wykorzystanie zmiany koloru oryginalnego zdjęcia
        /// </summary>
        void wroclaw()
        {
            if (!opened)
            {
                MessageBox.Show("Otworz zdjęcie, potem zastosuj zmiany");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInv = new Bitmap(img.Width, img.Height);

                ImageAttributes iAttributes = new ImageAttributes();
                ColorMatrix cmPic = new ColorMatrix(new float[][]
                {
                 new float[]{1+0.933f, 0, 0, 0, 0},
                 new float[]{0, 1+0.199f, 0, 0, 0},
                 new float[]{0, 0, 1+1.299f, 0, 0},
                 new float[]{0, 0.2f, 0, 1, 0},
                 new float[]{0, 0, 0, 0, 1}
                });
                iAttributes.SetColorMatrix(cmPic);
                Graphics graph = Graphics.FromImage(bmpInv);

                graph.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, iAttributes);


                graph.Dispose();
                pictureBox1.Image = bmpInv;

            }
        }
        /// <summary>
        /// Metoda dla przycisku filtru "Lublin" opisująca działanie filtru i wykorzystanie zmiany koloru oryginalnego zdjęcia
        /// </summary>
        void lublin()
        {
            if (!opened)
            {
                MessageBox.Show("Otworz zdjęcie, potem zastosuj zmiany");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInv = new Bitmap(img.Width, img.Height);

                ImageAttributes iAttributes = new ImageAttributes();
                ColorMatrix cmPic = new ColorMatrix(new float[][]
                {
                 new float[]{.393f, .350f, .280f, 0, 0},
                 new float[]{.772f, .671f, .532f, 0, 0},
                 new float[]{.187f, .165f, .127f, 0, 0},
                 new float[]{0, 0.2f, 0, 1, 0},
                 new float[]{0, 0, 0, 0, 1}
                });
                iAttributes.SetColorMatrix(cmPic);
                Graphics graph = Graphics.FromImage(bmpInv);

                graph.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, iAttributes);


                graph.Dispose();
                pictureBox1.Image = bmpInv;

            }
        }
        /// <summary>
        /// Metoda dla przycisku filtru "Tarnów" opisująca działanie filtru i wykorzystanie zmiany koloru oryginalnego zdjęcia
        /// </summary>
        void tarnow()
        {
            if (!opened)
            {
                MessageBox.Show("Otworz zdjęcie, potem zastosuj zmiany");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInv = new Bitmap(img.Width, img.Height);

                ImageAttributes iAttributes = new ImageAttributes();
                ColorMatrix cmPic = new ColorMatrix(new float[][]
                {
                 new float[]{0.3f, 0.3f, 0.3f, 0.3f, 0.3f},
                 new float[]{0.59f, 0.59f, 0.59f, 0.59f, 0.59f},
                 new float[]{0.11f, 0.11f, 0.11f, 0.11f, 0.11f},
                 new float[]{0, 0, 0, 1, 0},
                 new float[]{0, 0, 0, 0, 1}
                });
                iAttributes.SetColorMatrix(cmPic);
                Graphics graph = Graphics.FromImage(bmpInv);

                graph.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, iAttributes);


                graph.Dispose();
                pictureBox1.Image = bmpInv;

            }
        }
        /// <summary>
        /// Metoda dla slidera RGB opisująca działanie slidera i zmianę ilośći koloru red, green i blue na zdjęciu
        /// </summary>
        void rgbSlide()
        {
            float changeToRed = redbar.Value * 0.1f;
            float changeToGreen = greenbar.Value * 0.1f;
            float changeToBlue = bluebar.Value * 0.1f;

            //redvalue.Text = changered.ToString();
            //greenvalue.Text = changeblue.ToString();
            //bluevalue.Text = changegreen.ToString();

            reload();
            if (!opened)
            {
            }
            else
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInv = new Bitmap(img.Width, img.Height);

                ImageAttributes iAttributes = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+changeToRed, 0, 0, 0, 0},
                    new float[]{0, 1+changeToGreen, 0, 0, 0},
                    new float[]{0, 0, 1+changeToBlue, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                iAttributes.SetColorMatrix(cmPicture);
                Graphics graph = Graphics.FromImage(bmpInv);

                graph.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, iAttributes);


                graph.Dispose();
                pictureBox1.Image = bmpInv;
            }
        }
        /// <summary>
        /// Metoda za pomocą której można zapisać zmodyfikowane zdjęcie na komputer
        /// </summary>
        void saveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog(); // stworzenia nowego pliku dialog
                sfd.Filter = "Images|*.jpg; *png; *bmp; ";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Najpierw wybierz zdjęcie");
            }
        }


        Image file;
        bool opened = false; // sprawdzenie czy zdjecie jest otwarte w picture box czy nie

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Przycisk dla otwierania zdjęcia
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void openButton_Click(object sender, EventArgs e)
        {
            openImage();
        }
        /// <summary>
        /// Przycisk dla zapisanie zdjęcia
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        /// <summary>
        /// Przycisk który obsługuje filtr jaki można zastosować żeby zostawić oryginalne zdjęcia
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btNon_Click(object sender, EventArgs e)
        {
            redbar.Value = 0;
            greenbar.Value = 0;
            bluebar.Value = 0;
            reload();
        }

        /// <summary>
        /// Przycisk który obsługuje filtr o nazwie "Kraków"
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btKrakow_Click(object sender, EventArgs e)
        {
            reload();
            krakow();
        }
        /// <summary>
        /// Przycisk który obsługuje filtr o nazwie "Warszawa"
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btWarszawa_Click(object sender, EventArgs e)
        {
            reload();
            warszawa();
        }
        /// <summary>
        /// Przycisk który obsługuje filtr o nazwie "Opole
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btOpole_Click(object sender, EventArgs e)
        {
            reload();
            opole();
        }
        /// <summary>
        /// Przycisk który obsługuje filtr o nazwie "Katowice"
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btKatowice_Click(object sender, EventArgs e)
        {
            reload();
            katowice();
        }
        /// <summary>
        /// Przycisk który obsługuje filtr o nazwie "Wrocław"
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btWroclaw_Click(object sender, EventArgs e)
        {
            reload();
            wroclaw();
        }
        /// <summary>
        /// Przycisk który obsługuje filtr o nazwie "Tarnów"
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btTarnow_Click(object sender, EventArgs e)
        {
            reload();
            tarnow();
        }
        /// <summary>
        /// Trackbar jaki zawiera zmieniania kolóru czerwonego
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            rgbSlide();
        }
        /// <summary>
        /// Trackbar jaki zawiera zmieniania kolóru zielonego
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void greenbar_ValueChanged(object sender, EventArgs e)
        {
            rgbSlide();
        }
        /// <summary>
        /// Trackbar jaki zawiera zmieniania kolóru niebieskiego
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void bluebar_ValueChanged(object sender, EventArgs e)
        {
            rgbSlide();
        }
        /// <summary>
        /// Przycisk dla zamykania aplikacji
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Przycisk który obsługuje filtr o nazwie "Lublin"
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btLublin_Click(object sender, EventArgs e)
        {
            reload();
            lublin();
        }
        /// <summary>
        /// Przycisk dla zmieniania rotacji zdjęcia 90 stopni wlewo
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btRotateLeft_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }
        /// <summary>
        /// Przycisk dla zmieniania rotacji zdjęcia 90 stopni wprawo
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>

        private void btRotateRight_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Refresh();
        }
        /// <summary>
        /// Przycisk dla zmieniania rotacji zdjęcia 180 stopni poziomo
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btRotateVertical_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }
        /// <summary>
        /// Przycisk dla zmieniania rotacji zdjęcia 180 stopni pionowo
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btRotateHorizontal_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }
        /// <summary>
        /// Przycisk dla umożliwiania obcinania zdjęcia 
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btMakeSelection_Click(object sender, EventArgs e)
        {
            pictureBox1.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            Controls.Add(pictureBox1);
        }
        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;

        public Pen cropPen;
        public DashStyle cropDashStyle = DashStyle.DashDot;

        /// <summary>
        /// Pomaga zmienić kursor w dół na zdjęciu
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                cropX = e.X;
                cropY = e.Y;
                cropPen = new Pen(Color.Black, 1);
                cropPen.DashStyle = DashStyle.DashDotDot;
            }
            pictureBox1.Refresh();
        }
        /// <summary>
        /// Pomaga wymusić kursor przenieść się na zdjęciu
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox1.Refresh();
                cropWidth = e.X - cropX;
                cropHeight = e.Y - cropY;
                pictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
            }
        }
        /// <summary>
        /// Przycisk dla zastosowania zmian przy obcinaniu
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void btCrop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (cropWidth < 1)
            {
                return;
            }
            Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
            Bitmap OriginalImage = new Bitmap(pictureBox1.Image, pictureBox1.Width, pictureBox1.Height);
            Bitmap _img = new Bitmap(cropWidth, cropHeight);
            Graphics g = Graphics.FromImage(_img);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            pictureBox1.Image = _img;
            pictureBox1.Width = _img.Width;
            pictureBox1.Height = _img.Height;

            btCrop.Enabled = false;
        }
        /// <summary>
        /// Pozwala 
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Color c = bmp.GetPixel(e.X, e.Y);
                pictureBox2.BackColor = c;

                aValue.Text = c.A.ToString();
                rValue.Text = c.R.ToString();
                gValue.Text = c.G.ToString();
                blueValue.Text = c.B.ToString();

            }
            catch (Exception ex)
            {

            }
        }
        private Bitmap m_Bitmap;
        /// <summary>
        /// Przycisk menu dla otworzenia zdjęcia
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openImage();
        }
        /// <summary>
        /// Przycisk menu dla zapisanie zdjęcia
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage();
        }
        /// <summary>
        /// Przycisk dla zamykanie aplikacji
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Przycisk dla otworzenia dodatkowej Windows Formy
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void MoreColors_Click(object sender, EventArgs e)
        {
            ColorPicker colorPicker = new ColorPicker();
            colorPicker.Show();
        }

        
    }
}
    



