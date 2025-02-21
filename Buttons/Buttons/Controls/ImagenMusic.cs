using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Buttons.Properties;

public class ImagenMusic : PictureBox
{
    Image img = Resources.MusicIcon;

    public ImagenMusic()
    {
        this.Image = RedimensionarImagen(img, 200, 200);
    }

    private Image RedimensionarImagen(Image imagen, int ancho, int alto)
    {
        Bitmap nuevaImagen = new Bitmap(ancho, alto);
        using (Graphics g = Graphics.FromImage(nuevaImagen))
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(imagen, 0, 0, ancho, alto);
        }
        return nuevaImagen;
    }
    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
        base.SetBoundsCore(x, y, 200, 200, specified); // Siempre 280x200
    }
}
