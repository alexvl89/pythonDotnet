# Тестирование запуска python в коде C#

Данное приложение можно запускать как в среде Windows, так и Linux

##### Не забыть установить и настроить:

1. Установить python и найти файл библиотеки например

``` bash
@"/usr/lib/x86_64-linux-gnu/libpython3.13.so.1";
```

1. Указать путь к нужной библиотеке python, в примере файл лежит вместе с исполняемым файлом

``` Csharp
        string path = AppDomain.CurrentDomain.BaseDirectory;
        sys.path.append(path); 
```