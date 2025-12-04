using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using RussoBarberisPriotti_GestorArchivos.src.Models;

namespace RussoBarberisPriotti_GestorArchivos.src.Utilities
{
    public static class SaveFile
    {
        public static void saveInTxt(List<Alumno> Alumnos, string FileName)
        {
            try
            {
                List<string> AlumnosAGuardar = new List<string>();
                foreach (var alumno in Alumnos)
                {
                    AlumnosAGuardar.Add(alumno.ToString());
                }
                File.WriteAllLines($"{FileName}.txt", AlumnosAGuardar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo: " + ex.ToString());
            }
        }
        public static void saveInCsv(List<Alumno> Alumnos, string FileName)
        {
            try
            {
                List<string> AlumnosAGuardar = new List<string>();

                AlumnosAGuardar.Add("Legajo,Apellido,Nombre,Nro. Doc.,Email,Teléfono");
                foreach (var alumno in Alumnos)
                {
                    AlumnosAGuardar.Add(alumno.ToCsvString());
                }

                File.WriteAllLines($"{FileName}.csv", AlumnosAGuardar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo: " + ex.ToString());
            }
        }
        public static void saveInJson(List<Alumno> Alumnos, string FileName)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText($"{FileName}.json", JsonSerializer.Serialize(Alumnos, options));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo: " + ex.ToString());
            }
        }

        public static void saveInXml(List<Alumno> Alumnos, string FileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Alumno>));
                using (StreamWriter writer = new StreamWriter(FileName + ".xml"))
                {
                    serializer.Serialize(writer, Alumnos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el archivo XML: " + ex.ToString());
            }
        }
    }
}
