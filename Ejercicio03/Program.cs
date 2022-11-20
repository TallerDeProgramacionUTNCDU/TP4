using System;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var repositorioUsuarioMemoria = new RepositorioUsuarioMemoria();
            while (!exit)
            {
                Console.WriteLine("1- Agregar Usuario \n2- Modificar usuario \n3- Eliminar Usuario\n4- Listado Usuarios \n5- Listado ordenado por codigo \n6- Listado ordenado por nombre \n7- Listado ordenado por Correo Electronico \n0- Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Usuario usuario = new Usuario();
                        Console.WriteLine("Ingrese el codigo del usuario");
                        usuario.Codigo = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre completo del usuario");
                        usuario.NombreCompleto = Console.ReadLine();
                        Console.WriteLine("Ingrese el email del usuario");
                        usuario.CorreoElectronico = Console.ReadLine();
                        repositorioUsuarioMemoria.Agregar(usuario);
                        Console.Clear();
                        break;

                    case 2:
                        Usuario usuarioModificar = new Usuario();
                        Console.Clear();
                        Console.WriteLine("Ingrese el codigo del usuario");
                        usuarioModificar.Codigo = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre completo del usuario");
                        usuarioModificar.NombreCompleto = Console.ReadLine();
                        Console.WriteLine("Ingrese el email del usuario");
                        usuarioModificar.CorreoElectronico = Console.ReadLine();
                        repositorioUsuarioMemoria.Actualizar(usuarioModificar);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el codigo del usuario a eliminar:");
                        string CodigoEliminacion = Console.ReadLine();
                        repositorioUsuarioMemoria.Eliminar(CodigoEliminacion);
                        Console.WriteLine("El usuario con el codigo " + CodigoEliminacion + " fue eliminado correctamente");
                        break;

                    case 4:
                        var arrayUsuarios = repositorioUsuarioMemoria.ObtenerTodos();
                        for (int i=0; i<arrayUsuarios.Count;i++)
                        {
                            Console.WriteLine("Usuario numero: " + (i+1));
                            Console.WriteLine(arrayUsuarios[i].Codigo);
                            Console.WriteLine(arrayUsuarios[i].NombreCompleto);
                            Console.WriteLine(arrayUsuarios[i].CorreoElectronico);
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;
                    case 5:
                        var arrayUsuariosPorCodigo = repositorioUsuarioMemoria.ObtenerOrdenadosPorCodigo();
                        for (int i = 0; i < arrayUsuariosPorCodigo.Count; i++)
                        {
                            Console.WriteLine("Usuario numero: " + (i + 1));
                            Console.WriteLine(arrayUsuariosPorCodigo[i].Codigo);
                            Console.WriteLine(arrayUsuariosPorCodigo[i].NombreCompleto);
                            Console.WriteLine(arrayUsuariosPorCodigo[i].CorreoElectronico);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        var arrayUsuariosPorNombre = repositorioUsuarioMemoria.ObtenerOrdenadosPorNombreCompleto();
                        for (int i = 0; i < arrayUsuariosPorNombre.Count; i++)
                        {
                            Console.WriteLine("Usuario numero: " + (i + 1));
                            Console.WriteLine(arrayUsuariosPorNombre[i].Codigo);
                            Console.WriteLine(arrayUsuariosPorNombre[i].NombreCompleto);
                            Console.WriteLine(arrayUsuariosPorNombre[i].CorreoElectronico);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.ReadKey();
                        break;
                    case 7:
                        var arrayUsuariosPorCorreo = repositorioUsuarioMemoria.ObtenerOrdenadosPorCorreo();
                        for (int i=0; i < arrayUsuariosPorCorreo.Count; i++)
                        {
                            Console.WriteLine("Usuario numero: " + i + 1);
                            Console.WriteLine(arrayUsuariosPorCorreo[i].Codigo);
                            Console.WriteLine(arrayUsuariosPorCorreo[i].NombreCompleto);
                            Console.WriteLine(arrayUsuariosPorCorreo[i].CorreoElectronico);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo de la aplicación");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion valida");
                        break;
                }
            }
        }
    }
}
