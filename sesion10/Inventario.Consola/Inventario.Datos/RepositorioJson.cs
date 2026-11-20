using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Inventario.Dominio;

namespace Inventario.Datos
{
    public class RepositorioJson : IRepositorioProductos
    {
        private static readonly JsonSerializerOptions Opciones = new() { WriteIndented = true };

        private readonly string _ruta;

        public RepositorioJson(string ruta)
        {
            _ruta = ruta;
        }

        public List<Producto> Cargar()
        {
            // 1. Sin archivo: empieza vacío.
            if (!File.Exists(_ruta))
                return new List<Producto>();

            try
            {
                string json = File.ReadAllText(_ruta);
                var productos = JsonSerializer.Deserialize<List<Producto>>(json);

                // Un archivo vacío o con "null" también cuenta como dañado.
                if (productos is null)
                    throw new JsonException("El archivo no contiene una lista de productos.");

                return productos;
            }
            catch (JsonException)
            {
                // 2. Archivo dañado: guarda copia .danado y empieza vacío.
                GuardarCopiaDanada();
                return new List<Producto>();
            }
        }

        public void Guardar(List<Producto> productos)
        {
            string? carpeta = Path.GetDirectoryName(_ruta);
            if (!string.IsNullOrEmpty(carpeta))
                Directory.CreateDirectory(carpeta);

            string json = JsonSerializer.Serialize(productos, Opciones);
            File.WriteAllText(_ruta, json);
        }

        private void GuardarCopiaDanada()
        {
            try
            {
                File.Copy(_ruta, _ruta + ".danado", overwrite: true);
            }
            catch (IOException)
            {
                // Si ni la copia se puede hacer, no tumbamos el programa.
            }
        }
    }
    }
