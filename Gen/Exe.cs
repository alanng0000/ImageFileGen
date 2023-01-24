namespace Gen;




class Exe : ExeExe
{
    static int Main()
    {
        Exe exe;

        exe = new Exe();

        exe.Init();



        int o;

        o = exe.Execute();


        return o;
    }
    




    protected override int ExecuteWork()
    {
        Gen gen;


        gen = new Gen();


        gen.Init();



        int o;

        o = gen.Execute();


        return o;
    }
}