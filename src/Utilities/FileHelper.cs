using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;
using System.Windows.Forms;
using RussoBarberisPriotti_GestorArchivos.src.Models;

namespace RussoBarberisPriotti_GestorArchivos.src.Utilities
{
    public static class FileHelper
    {
        public static List<Alumno> ReadFile(string filePath)
        {
            List<Alumno> alumnoList = new List<Alumno>();

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("El archivo no existe.");
            }

            string extension = Path.GetExtension(filePath).ToLower();

            try
            {
                if (extension == ".txt")
                {
                    string[] lineas = File.ReadAllLines(filePath);
                    foreach (string linea in lineas)
                    {
                        if (string.IsNullOrEmpty(linea)) continue;
                        Alumno? alumno = Alumno.FromTxtToObj(linea);
                        if (alumno != null)
                        {
                            alumnoList.Add(alumno);
                        }
                    }
                }
                else if (extension == ".csv")
                {
                    string[] lineas = File.ReadAllLines(filePath);
                    foreach (string linea in lineas.Skip(1)) // Skip header
                    {
                        if (string.IsNullOrEmpty(linea)) continue;
                        Alumno? alumno = Alumno.FromCsvToObj(linea);
                        if (alumno != null)
                        {
                            alumnoList.Add(alumno);
                        }
                    }
                }
                else if (extension == ".json")
                {
                    string json = File.ReadAllText(filePath);
                    alumnoList = JsonSerializer.Deserialize<List<Alumno>>(json) ?? new List<Alumno>();
                }
                else if (extension == ".xml")
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Alumno>));
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        List<Alumno>? result = (List<Alumno>?)serializer.Deserialize(reader);
                        if (result != null)
                        {
                            alumnoList = result;
                        }
                    }
                }
                else
                {
                    throw new Exception("Formato no soportado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo: {ex.Message}");
            }

            return alumnoList;
        }
    }
}
