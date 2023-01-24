namespace Gen;




class Gen : Object
{
    public string[] Arg { get; set; }



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



        this.WriteFile();




        this.Bitmap.Dispose();




        return 0;
    }




    private bool GetImageData()
    {
        Bitmap bitmap;

        bitmap = this.Bitmap;



        Rectangle rect;

        rect = new Rectangle(Point.Empty, bitmap.Size);



        BitmapData bitmapData;
        
        bitmapData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);



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
        
        pixelDataSize = bitmap.Width * bitmap.Height * this.PixelByteCount;



        

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





        global::System.Console.Write("Gen GetImageData width: " + bitmap.Width + ", " + "height: " + bitmap.Height + ", " + "stride: " + bitmapData.Stride + "\n");




        this.Copy(ptr, this.ImageData, headSize, bitmap.Width, bitmap.Height, bitmapData.Stride);



        
        bitmap.UnlockBits(bitmapData);
        




        return true;
    }




    private bool Copy(IntPtr ptr, byte[] data, int index, int width, int height, int stride)
    {
        int pixelByteCount;
        
        pixelByteCount = this.PixelByteCount;




        unsafe
        {
            byte* pp;

            pp = (byte*)ptr;



            fixed (byte* po = data)
            {
                byte* pu;

                pu = po + index;



                int i;

                i = 0;

                while (i < height)
                {
                    int j;

                    j = 0;


                    while (j < width)
                    {
                        int a;

                        a = stride * i + j * pixelByteCount;

                        
                        int b;

                        b = (width * i + j) * pixelByteCount;



                        byte* pa;

                        pa = pp + a;



                        byte* pb;

                        pb = pu + b;



                        uint* na;

                        na = (uint*)pa;


                        uint* nb;

                        nb = (uint*)pb;



                        *nb = *na;



                        j = j + 1;
                    }



                    i = i + 1;
                }
            }
        }



        return true;
    }




    private int PixelByteCount { get { return 4; } }





    private bool WriteFile()
    {
        File.WriteAllBytes("image.img", this.ImageData);



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
        this.FileName = this.Arg[0];


        return true;
    }
}