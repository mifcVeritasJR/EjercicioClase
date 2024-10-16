namespace EjercicioClase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SuperHeroe superheroe1 = new SuperHeroe
            {
                Nombre = "Wonder Woman",
                IdentidadSecreta = "Diana Prince",
                Ciudad = "Themyscira",
                PuedeVolar = true,
                SuperPoder = new SuperPoder
                {
                    Nombre = "Flash",
                    Descripcion = "Puede correr a super velocidad",
                    Nivel = 9
                }
            };

            SuperHeroe superheroe2 = new SuperHeroe
            {
                Nombre = "Batman",
                IdentidadSecreta = "Bruce Wayne",
                Ciudad = "Gotham",
                PuedeVolar = false,
                SuperPoder = new SuperPoder
                {
                    Nombre = "Inteligencia".
                    Descripcion = "Es un experto investigando",
                    Nivel = 8
                }
            };

            SuperHeroe superheroe3 = new SuperHeroe
            {
                Nombre = "Superman",
                IdentidadSecreta = "Clark Kent",
                Ciudad = "Metropolis",
                PuedeVolar = true,
                SuperPoder = new SuperPoder
                {
                    Nombre = "Super fuerza",
                    Descripcion = "Puede levantar objetos pesados",
                    Nivel = 10
                }
            };

            Console.WriteLine("Superheroes:");
            Console.WriteLine($"Nombre: {superheroe1.Nombre}, Identidad Secreta: {superheroe1.IdentidadSecreta}, Ciudad: {superheroe1.Ciudad}, Puede Volar: {superheroe1.PuedeVolar}, Superpoder: {superheroe1.SuperPoder.Nombre} ({superheroe1.Superpoder.Descripcion}, Nivel: {superheroe1.SuperPoder.Nivel})");
            Console.WriteLine($"Nombre: {superheroe2.Nombre}, Identidad Secreta: {superheroe2.IdentidadSecreta}, Ciudad: {superheroe2.Ciudad}, Puede Volar: {superheroe2.PuedeVolar}, Superpoder: {superheroe2.SuperPoder.Nombre} ({superheroe2.Superpoder.Descripcion}, Nivel: {superheroe2.SuperPoder.Nivel})");
            Console.WriteLine($"Nombre: {superheroe3.Nombre}, Identidad Secreta: {superheroe3.IdentidadSecreta}, Ciudad: {superheroe3.Ciudad}, Puede Volar: {superheroe3.PuedeVolar}, Superpoder: {superheroe3.SuperPoder.Nombre} ({superheroe3.Superpoder.Descripcion}, Nivel: {superheroe3.SuperPoder.Nivel})");
        }
    }
}