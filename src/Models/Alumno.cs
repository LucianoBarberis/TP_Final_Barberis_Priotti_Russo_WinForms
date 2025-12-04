using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RussoBarberisPriotti_GestorArchivos.src.Models
{
    public class Alumno
    {
        public string Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public Alumno() { }

        public Alumno(string legajo, string apellido, string nombre, string dni, string email, string telefono)
        {
            Legajo = legajo;
            Apellido = apellido;
            Nombre = nombre;
            Dni = dni;
            Email = email;
            Telefono = telefono;
        }
        public override string ToString()
        {
            return $"{Legajo} | {Apellido} | {Nombre} | {Dni} | {Email} | {Telefono}";
        }
        public string ToCsvString()
        {
            return $"{Legajo},{Apellido},{Nombre},{Dni},{Email},{Telefono}";
        }
        public static Alumno? FromTxtToObj(string linea)
        {
            string[] datos = linea.Split('|');
            if (datos.Length == 6)
            {
                return new Alumno(datos[0].Trim(), datos[1].Trim(), datos[2].Trim(), datos[3].Trim(), datos[4].Trim(), datos[5].Trim());
            }
            return null;
        }

        public static Alumno? FromCsvToObj(string linea)
        {
            string[] datos = linea.Split(',');
            if (datos.Length == 6)
            {
                return new Alumno(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5]);
            }
            return null;
        }
        public static bool ValidarAlumno(string? legajo, string? apellido, string? nombre, string? doc, string? email, string? tel)
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(legajo))
            {
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(doc))
            {
                esValido = false;
            }
            else if (!long.TryParse(doc, out _))
            {
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                esValido = false;
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                esValido = false;
            }
            if (string.IsNullOrWhiteSpace(tel))
            {
                esValido = false;
            }

            return esValido;
        }
    }
}
