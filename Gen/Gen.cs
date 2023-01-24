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




        this.CreateBitmap();



        this.GetImageData();






        return 0;
    }




    private bool GetImageData()
    {
        Bitmap bitmap;

        bitmap = this.Bitmap;



        Rectangle rect;

        rect = new Rectangle(Point.Empty, bitmap.Size);



        BitmapData bitmapData;
        
        bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, bitmap.PixelFormat);



        IntPtr ptr;
        
        ptr = bitmapData.Scan0;



        Constant constant;

        constant = Constant.This;



        Convert convert;

        convert = Convert.This;




        ulong k;

        k = constant.IntByteCount * 2;




        int headSize;

        headSize = convert.SInt32(k);




        int pixelDataSize;
        
        pixelDataSize = bitmapData.Stride * bitmap.Height;

        


        int size;

        size = headSize + pixelDataSize;



        byte[] imageData;
        
        imageData = new byte[size];




        this.ImageData = imageData;



        
        this.Index = 0;





        ulong width;

        width = convert.ULong(bitmap.Width);



        ulong height;

        height = convert.ULong(bitmap.Height);



        this.Int(width);


        this.Int(height);





        Marshal.Copy(ptr, imageData, headSize, pixelDataSize);



        
        bitmap.UnlockBits(bitmapData);
        




        return true;
    }






    private bool CreateBitmap()
    {
        this.Bitmap = new Bitmap(this.FileName);



        return true;
    }





    private byte[] ImageData { get; set; }



    private Bitmap Bitmap { get; set; }





    private bool Int(ulong o)
    {
        Constant constant;

        constant = Constant.This;



        Convert convert;

        convert = Convert.This;




        ulong uu;

        uu = constant.ByteBitCount;



        ulong shiftCount;



        int ou;




        byte ob;



        ulong k;
        


        ulong count;

        count = constant.IntByteCount;



        ulong i;

        i = 0;


        while (i < count)
        {
            shiftCount = i * uu;


            ou = convert.SInt32(shiftCount);


            k = o >> ou;



            ob = convert.Byte(k);




            this.Byte(ob);
            



            i = i + 1;
        }



        return true;
    }







    private bool Byte(byte ob)
    {
        byte[] o;


        o = this.ImageData;


        

        ulong k;


        k = this.Index;




        o[k] = ob;





        k = k + 1;



        this.Index = k;




        return true;
    }







    private ulong Index { get; set; }






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