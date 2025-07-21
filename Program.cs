using Python.Runtime;

Console.WriteLine("Hello, Python!");

//привязываем библиотеку Python
// Runtime.PythonDLL = @"C:\Users\Aleksandr\AppData\Local\Programs\Python\Python310\python310.dll";

Runtime.PythonDLL = @"/usr/lib/x86_64-linux-gnu/libpython3.10.so";

PythonEngine.Initialize();

using (Py.GIL())
{
    RepExample();

    UserExample();

    Console.ReadKey();
}

void RepExample()
{
    //пример с репозитория
    dynamic np = Py.Import("numpy");
    Console.WriteLine(np.cos(np.pi * 2));

    dynamic sin = np.sin;
    Console.WriteLine(sin(5));

    double c = (double)(np.cos(5) + sin(5));
    Console.WriteLine(c);

    dynamic a = np.array(new List<float> { 1, 2, 3 });
    Console.WriteLine(a.dtype);

    dynamic b = np.array(new List<float> { 6, 5, 4 }, dtype: np.int32);
    Console.WriteLine(b.dtype);

    Console.WriteLine(a * b);
}

void UserExample()
{
    try
    {
        dynamic example = Py.Import("example");

        example.hello_world();
        dynamic calc = example.calculator();
        float res = calc.Add(1, 2);
        Console.WriteLine($"Результат сложения: {res}");

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ошибка обработки {0}", ex.Message);
    }
}