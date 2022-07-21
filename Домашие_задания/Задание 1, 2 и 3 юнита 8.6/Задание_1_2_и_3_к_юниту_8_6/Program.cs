using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание 1 юнита 8.6
            #region

            // задаем путь к каталогу, который надо очистить
            string CleanDirectory = @"C:\folder";

            // устанавливаем время "старости" файла или папки в минутах от текущего момента
            double delMinutes = 30;

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(CleanDirectory);
                if (dirInfo.Exists)
                {
                    DeleteFilesAndDirectories(CleanDirectory, delMinutes);
                    Console.WriteLine($"Очистка папки {CleanDirectory} завершена.");
                }
            }
            //Начинаем перехватывать ошибки

            //DirectoryNotFoundException - директория не найдена
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Директория не найдена. Ошибка: " + e.Message);
            }

            //UnauthorizedAccessException - отсутствует доступ к файлу или папке
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Отсутствует доступ. Ошибка: " + e.Message);
            }

            //Во всех остальных случаях
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка. Обратитесь к администратору. Ошибка: " + e.Message);
            }

            // процедура удаление файлов и папок старше _delMinutes минут 
            static void DeleteFilesAndDirectories(string _CleanDirectory, double _delMinutes)
            {
                // получаем все файлы из указанного каталога
                string[] files = Directory.GetFiles(_CleanDirectory);

                // удаление старых файлов в цикле
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);

                    // если дата создания/изменения файла меньше (сегодня - delMinutes), то удаляем файл
                    if (fi.LastWriteTime < DateTime.Now.AddDays(-_delMinutes))
                    {
                        fi.Delete();
                    }
                }

                // получаем все папки из указанного каталога
                string[] dirs = Directory.GetDirectories(_CleanDirectory);

                // удаление старых папок в цикле
                foreach (string dir in dirs)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);

                    // если время создания/изменения меньше (сегодня - _delMinutes), то удаляем папку
                    if (di.LastWriteTime < DateTime.Now.AddDays(-_delMinutes))
                    {
                        // если в папке есть подпапки, то делаем рекурсию данного метода на них
                        DeleteFilesAndDirectories(di.FullName, _delMinutes);

                        di.Delete();
                    }
                }
            }

            #endregion


            // -----------------------


            // Задание 2 юнита 8.6
            #region

            string pathToDirectory = @"D:\\Catalog";
            double catalogSize = 0;

            if (catalogSize != 0)
            {
                sizeOfFolder(pathToDirectory, ref catalogSize);
                Console.WriteLine("Размер каталога {0} составляет {1} байт.", pathToDirectory, catalogSize);
            }
            else
            {
                Console.WriteLine("Каталог {0} пуст.", pathToDirectory);
            }
            Console.ReadLine();

            static void sizeOfFolder(string folder, ref double catalogSize)
            {
                try
                {
                    //В переменную catalogSize будем записывать размеры всех файлов, с каждым
                    //новым файлом перезаписывая данную переменную
                    DirectoryInfo di = new DirectoryInfo(folder);

                    FileInfo[] fi = di.GetFiles();
                    //В цикле пробегаемся по всем файлам директории di и складываем их размеры
                    foreach (FileInfo f in fi)
                    {
                        //Записываем размер файла в байтах
                        catalogSize += f.Length;
                    }

                    DirectoryInfo[] diA = di.GetDirectories();
                    //В цикле пробегаемся по всем вложенным директориям директории di 
                    foreach (DirectoryInfo df in diA)
                    {
                        //рекурсивно вызываем наш метод
                        sizeOfFolder(df.FullName, ref catalogSize);
                    }

                }
                //Начинаем перехватывать ошибки

                //DirectoryNotFoundException - директория не найдена
                catch (DirectoryNotFoundException e)
                {
                    Console.WriteLine("Директория не найдена. Ошибка: " + e.Message);
                }

                //UnauthorizedAccessException - отсутствует доступ к файлу или папке
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine("Отсутствует доступ. Ошибка: " + e.Message);
                }

                //Во всех остальных случаях
                catch (Exception e)
                {
                    Console.WriteLine("Произошла ошибка. Обратитесь к администратору. Ошибка: " + e.Message);
                }
            }

            #endregion


            // -----------------------


            // Задание 3 юнита 8.6 
            #region

            // задаем путь к каталогу, который надо очистить
            string CleanDirectory3 = @"C:\folder";

            // устанавливаем время "старости" файла или папки в минутах от текущего момента
            double delMinutes3 = 30;

            double catalogSize3 = 0;

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(CleanDirectory3);
                if (dirInfo.Exists)
                {
                    //определяем размер папки до очистки
                    sizeOfFolder3(CleanDirectory3, ref catalogSize3);
                    double oldSize = catalogSize3;
                    Console.WriteLine($"Исходный размер папки: {catalogSize3} байт.");

                    //очищаем папку
                    DeleteFilesAndDirectories3(CleanDirectory3, delMinutes3);

                    //определяем размер папки после очистки
                    sizeOfFolder3(CleanDirectory3, ref catalogSize3);

                    // определяем сколько байт было удалено из папки
                    double deleteSize = oldSize - catalogSize3;

                    Console.WriteLine($"Освобождено: {deleteSize} байт.");
                    Console.WriteLine($"Текущий размер папки: {catalogSize3} байт.");
                }
            }
            //Начинаем перехватывать ошибки

            //DirectoryNotFoundException - директория не найдена
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Директория не найдена. Ошибка: " + e.Message);
            }

            //UnauthorizedAccessException - отсутствует доступ к файлу или папке
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Отсутствует доступ. Ошибка: " + e.Message);
            }

            //Во всех остальных случаях
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка. Обратитесь к администратору. Ошибка: " + e.Message);
            }

            // процедура удаление файлов и папок старше _delMinutes минут 
            static void DeleteFilesAndDirectories3(string _CleanDirectory, double _delMinutes)
            {
                // получаем все файлы из указанного каталога
                string[] files = Directory.GetFiles(_CleanDirectory);

                // удаление старых файлов в цикле
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);

                    // если дата создания/изменения файла меньше (сегодня - delMinutes), то удаляем файл
                    if (fi.LastWriteTime < DateTime.Now.AddDays(-_delMinutes))
                    {
                        fi.Delete();
                    }
                }

                // получаем все папки из указанного каталога
                string[] dirs = Directory.GetDirectories(_CleanDirectory);

                // удаление старых папок в цикле
                foreach (string dir in dirs)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);

                    // если время создания/изменения меньше (сегодня - _delMinutes), то удаляем папку
                    if (di.LastWriteTime < DateTime.Now.AddDays(-_delMinutes))
                    {
                        // если в папке есть подпапки, то делаем рекурсию данного метода на них
                        DeleteFilesAndDirectories3(di.FullName, _delMinutes);

                        di.Delete();
                    }
                }
            }

            static void sizeOfFolder3(string folder3, ref double catalogSize3)
            {

                //В переменную catalogSize3 будем записывать размеры всех файлов, с каждым
                //новым файлом перезаписывая данную переменную
                DirectoryInfo di = new DirectoryInfo(folder3);

                FileInfo[] fi = di.GetFiles();
                //В цикле пробегаемся по всем файлам директории di и складываем их размеры
                foreach (FileInfo f in fi)
                {
                    //Записываем размер файла в байтах
                    catalogSize3 += f.Length;
                }

                DirectoryInfo[] diA = di.GetDirectories();
                //В цикле пробегаемся по всем вложенным директориям директории di 
                foreach (DirectoryInfo df in diA)
                {
                    //рекурсивно вызываем наш метод
                    sizeOfFolder3(df.FullName, ref catalogSize3);
                }

            }
        }
    }
}

            #endregion
