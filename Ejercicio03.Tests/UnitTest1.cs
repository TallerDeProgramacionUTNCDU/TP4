namespace Ejercicio03.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebasGenerales()
        {
            var repositorioUsuario = new RepositorioUsuarioMemoria();
            //Creación de usuarios 
            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario();
            //Asignación de valores
            usuario1.Codigo = "codigo1";
            usuario1.NombreCompleto = "nombre1";
            usuario1.CorreoElectronico = "correo1@example.com";

            usuario2.Codigo = "codigo2";
            usuario2.NombreCompleto = "nombre2";
            usuario2.CorreoElectronico = "correo2@example.com";
            //Agregar Usuarios
            repositorioUsuario.Agregar(usuario1);
            repositorioUsuario.Agregar(usuario2);
            var arrayUsuarios = repositorioUsuario.ObtenerTodos();
            Assert.AreEqual(arrayUsuarios.Count, 2);
            Assert.AreEqual(arrayUsuarios.Contains(usuario1), true);
            Assert.AreEqual(arrayUsuarios.Contains(usuario2), true);

            Assert.AreEqual(arrayUsuarios[0].Codigo, "codigo1");
            Assert.AreEqual(arrayUsuarios[1].Codigo, "codigo2");

            Assert.AreEqual(arrayUsuarios[0].NombreCompleto, "nombre1");
            Assert.AreEqual(arrayUsuarios[1].NombreCompleto, "nombre2");

            Assert.AreEqual(arrayUsuarios[0].CorreoElectronico, "correo1@example.com");
            Assert.AreEqual(arrayUsuarios[1].CorreoElectronico, "correo2@example.com");
        }
    }
}