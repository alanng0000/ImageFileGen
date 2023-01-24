namespace Gen;




class Exe : Object
{
    static int Main(string[] arg)
    {
        Gen gen;


        gen = new Gen();


        gen.Init();


        gen.Arg = arg;



        int o;

        o = gen.Execute();


        return o;
    }
}