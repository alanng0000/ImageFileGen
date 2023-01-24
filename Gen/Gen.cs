namespace Gen;




class Gen : Object
{
    public int Execute()
    {
        bool b;

        b = this.GetFileName();


        if (!b)
        {
            return 1;
        }









        return 0;
    }




    private byte[] GetPixelData()
    {
        Rectangle rect;

        rect = new Rectangle(Point.Empty, this.Bitmap.Size);


        BitmapData data;
        
        data = this.Bitmap.LockBits(
            rect, ImageLockMode.ReadWrite, this.Bitmap.PixelFormat
            );


var pixelSize = data.PixelFormat == PixelFormat.Format32bppArgb ? 4 : 3; // only works with 32 or 24 pixel-size bitmap!
var padding = data.Stride - (data.Width * pixelSize);
var bytes = new byte[data.Height * data.Stride];

// copy the bytes from bitmap to array
Marshal.Copy(data.Scan0, bytes, 0, bytes.Length);

    }




    private bool CreateBitmap()
    {
        this.Bitmap = new Bitmap(this.FileName);



        return true;
    }




    private Bitmap Bitmap { get; set; }




    private string FileName { get; set; }



    private bool GetFileName()
    {
        string s;

        s = Console.ReadLine();


        if (s == null)
        {
            return false;
        }


        this.FileName = s;


        return true;
    }
}