using Ejercicio_02;
using System.Globalization;

namespace Ejercicio_02_Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class FileManagerTests
    {
        [TestCase()]
        public void GetPathFile_Failed()
        {
            var fm = new Ejercicio_02.FileManager();
            var path = "C:\\";
            var targetFile = "ServiceConfiguration";

            Assert.Throws<ExceptionFileNotFound>(()=> fm.GetPathFile(targetFile, path));
        }
        [TestCase()]
        public void GetPathFile_Success()
        {
            var fm = new Ejercicio_02.FileManager();
            var path = "C:\\Users\\santi\\Desktop\\TP4\\Ejercicio02"; //Cambiar dependiendo de quien tenga el archivo
            var validPath = "C:\\Users\\santi\\Desktop\\TP4\\Ejercicio02\\ServiceConfiguration.json";//Cambiar dependiendo de quien tenga el archivo
            var targetFile = "ServiceConfiguration";
            var pathFile = fm.GetPathFile(targetFile, path);
            Assert.AreEqual(validPath,pathFile);
        }
        [TestCase()]
        public void GetConfigFromFile_Success()
        {
            var fm = new Ejercicio_02.FileManager();
            var path = "C:\\Users\\santi\\Desktop\\TP4\\Ejercicio02\\ServiceConfiguration.json"; //Cambiar dependiendo de quien tenga el archivo
            var config = fm.GetConfigFromFile(path);
            Assert.AreEqual(config.GetType().ToString(), "Ejercicio_02.ServiceConfiguration");
        }
    }
}
