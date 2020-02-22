using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class ColorPicker : Form
    {
        
        public ColorPicker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start aplikacji
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void ColorPicker_Load(object sender, EventArgs e)
        {
            setTextBoxes();
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar4.Value, trackBar6.Value);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                
            }
        }

        /// <summary>
        /// Przycisk dla otworzenia colorDialog
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = panel1.BackColor;
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// Przy wcisnięciu na pole koloru pozwala skopiować kolor w RGB
        /// </summary>
        /// <param name="c">Opisuje color</param>
        /// <returns>Zwraca kolor w postaci RGB</returns>
        private static string ToRGB(Color c)
        {
            return $"{c.R.ToString()},{c.G.ToString()},{c.B.ToString()}";
        }

        /// <summary>
        /// Przy wcisnięciu na pole koloru pozwala skopiować kolor w HEX
        /// </summary>
        /// <param name="c">Opisuje kolor</param>
        /// <returns>Zwraca kolor w postaci HEX</returns>
        private static string ToHex(Color c)
        {
            return $"#{c.R.ToString("X2")}{c.G.ToString("X2")}{c.B.ToString("X2")}";
        }

        /// <summary>
        /// Przycisk dla kopiowanie koloru w HEX
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void copyToHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Clipboard.SetText(ToHex(panel1.BackColor));
        }

        /// <summary>
        /// Przycisk dla kopiowanie koloru w RGB
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void copyToRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ToRGB(panel1.BackColor));
        }

        /// <summary>
        /// Trackbar dla zmieniania koloru w RGB
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            setTextBoxes();
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar4.Value, trackBar6.Value);
        }
        /// <summary>
        /// Metoda dla opisu znaczenia dla koloru zielonego
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try { trackBar4.Value = int.Parse(textBox4.Text); }
            catch(Exception)
            {
                
            }
        }
        /// <summary>
        /// Metoda dla opisu znaczenia dla koloru niebieskiego
        /// </summary>
        /// <param name="sender">parametr o nazwie Sender, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.</param>
        /// <param name="e">parametr o nazwie e, który zawiera dane zdarzeń, aby uzyskać więcej informacji</param>
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar6.Value = int.Parse(textBox6.Text);
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Metoda która zwraca znaczenia w textbox
        /// </summary>
        private void setTextBoxes()
        {
            textBox1.Text = trackBar1.Value.ToString();
            textBox4.Text = trackBar4.Value.ToString();
            textBox6.Text = trackBar6.Value.ToString();
        }

        
    }
}
