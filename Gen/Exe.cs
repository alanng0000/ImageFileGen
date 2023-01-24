namespace Demo;




class Exe : ExeExe
{
    static int Main()
    {
        Exe exe;

        exe = new Exe();

        exe.Init();



        // ulong draw;

        // draw = System.Intern.DrawExtern.Draw_Draw_New();


        // System.Intern.DrawExtern.Draw_Draw_Delete(draw);



        // string s;

        // s = "DEMO NOW Extern\n";



        // ulong length;

        // length = (ulong)s.Length;



        // ulong data;

        // data = InfraExtern.New(length);



        // Intern oo;

        // oo = Intern.This;


        // oo.CopyString(s, data);





        // ulong ss;
        

        // ss = InfraExtern.String_New();


        // InfraExtern.String_Init(ss);



        // InfraExtern.String_SetLength(ss, length);


        // InfraExtern.String_SetData(ss, data);




        // ulong console;

        // console = InfraExtern.Console_New();



        // InfraExtern.Console_Init(console);



        // InfraExtern.Console_Write(console, ss);



        // InfraExtern.Console_Final(console);



        // InfraExtern.Console_Delete(console);





        // InfraExtern.String_Final(ss);


        // InfraExtern.String_Delete(ss);




        // InfraExtern.Delete(data);




        int o;

        o = exe.Execute();


        return o;
    }
    




    protected override int ExecuteWork()
    {
        Demo demo;


        demo = new Demo();


        demo.Init();



        int o;

        o = demo.Execute();


        return o;
    }






    // protected override int ExecuteWork()
    // {
    //     string title;

    //     title = "DEMO System Frame Infra";



    //     ulong length;

    //     length = (ulong)title.Length;




    //     ulong oss;

    //     oss = InfraExtern.New(length);




    //     Intern ooo;

    //     ooo = Intern.This;


    //     ooo.CopyString(title, oss);




    //     ulong ss;


    //     ss = InfraExtern.String_New();


    //     InfraExtern.String_Init(ss);



    //     InfraExtern.String_SetLength(ss, length);


    //     InfraExtern.String_SetData(ss, oss);





    //     Delegate dda;

    //     dda = new FrameControlHandleMethod(this.KeyHandle);




    //     Delegate ddb;

    //     ddb = new FrameDrawHandleMethod(DrawExtern.Draw_FrameDrawHandle);




    //     ulong keyHandle;

    //     keyHandle = ooo.MethodPointer(dda);




    //     ulong drawHandle;

    //     drawHandle = ooo.MethodPointer(ddb);








    //     ulong frame;


    //     frame = InfraExtern.Frame_New();



    //     InfraExtern.Frame_SetTitle(frame, ss);




    //     InfraExtern.Frame_Init(frame);










    //     ulong handle;

    //     handle = InfraExtern.Frame_GetHandle(frame);



    //     ulong size;

    //     size = InfraExtern.Frame_GetSize(frame);




    //     ulong draw;


    //     draw = DrawExtern.Draw_Draw_New();




    //     DrawExtern.Draw_Draw_SetHandle(draw, handle);



    //     DrawExtern.Draw_Draw_SetSize(draw, size);




    //     DrawExtern.Draw_Draw_Init(draw);





    //     DrawDrawMethod del;

    //     del = new DrawDrawMethod(this.DrawExecute);



    //     Delegate ddc;

    //     ddc = del;



    //     ulong drawMethod;


    //     drawMethod = ooo.MethodPointer(ddc);




    //     DrawExtern.Draw_Draw_SetMethod(draw, drawMethod);






    //     ulong brush;


    //     brush = DrawExtern.Draw_Brush_New();



    //     DrawExtern.Draw_Brush_Init(brush);




    //     ulong brushU;

    //     brushU = DrawExtern.Draw_ColorBrush_Create();



    //     ulong gg;


    //     gg = DrawExtern.Draw_Global();



    //     ulong constant;

    //     constant = DrawExtern.Draw_Global_Constant(gg);



    //     ulong typeU;

    //     typeU = DrawExtern.Draw_Constant_ColorBrushType(constant);




    //     DrawExtern.Draw_Brush_SetType(brush, typeU);



    //     DrawExtern.Draw_Brush_SetValue(brush, brushU);




    //     this.Brush = brush;





    //     InfraExtern.Frame_SetControlHandle(frame, keyHandle);




    //     InfraExtern.Frame_SetDrawHandle(frame, drawHandle);



    //     InfraExtern.Frame_SetDrawHandleArg(frame, draw);





    //     InfraExtern.Frame_Execute(frame);







    //     DrawExtern.Draw_Brush_Final(this.Brush);



    //     DrawExtern.Draw_Brush_Delete(this.Brush);





    //     DrawExtern.Draw_Draw_Final(draw);




    //     DrawExtern.Draw_Draw_Delete(draw);







    //     InfraExtern.Frame_Final(frame);



    //     InfraExtern.Frame_Delete(frame);





    //     InfraExtern.String_Final(ss);



    //     InfraExtern.String_Delete(ss);




    //     InfraExtern.Delete(oss);



    //     return 0;
    // }




    // private ulong Brush { get; set; }







    // private long Left { get; set; }



    // private long Up { get; set; }



    // private byte Comp { get; set; }



    // private ulong KeyHandle(ulong frame, ulong key, ulong value)
    // {
    //     if (value == 0)
    //     {
    //         return 0;
    //     }



    //     if (key == 'H')
    //     {
    //         InfraExtern.Frame_Close(frame);
    //     }


    //     if (key == 'B')
    //     {
    //         int a;


    //         a = this.Comp;


    //         a = a + 10;


    //         this.Comp = (byte)a;



    //         InfraExtern.Frame_Update(frame);
    //     }



    //     if (key == 'A')
    //     {
    //         this.Left = this.Left - 10;


    //         InfraExtern.Frame_Update(frame);
    //     }


    //     if (key == 'D')
    //     {
    //         this.Left = this.Left + 10;


    //         InfraExtern.Frame_Update(frame);
    //     }


    //     if (key == 'W')
    //     {
    //         this.Up = this.Up - 10;


    //         InfraExtern.Frame_Update(frame);
    //     }


    //     if (key == 'S')
    //     {
    //         this.Up = this.Up + 10;


    //         InfraExtern.Frame_Update(frame);
    //     }



    //     return 0;
    // }





    // private ulong DrawExecute(ulong draw)
    // {
    //     ulong color;

    //     color = 0x80000000 | this.Comp;
        


    //     DrawExtern.Draw_ColorBrush_SetColor(this.Brush, color);



    //     DrawExtern.Draw_Draw_Rect(draw, this.Left + 200, this.Up + 200, 400, 400, this.Brush);



    //     return 0;
    // }
}