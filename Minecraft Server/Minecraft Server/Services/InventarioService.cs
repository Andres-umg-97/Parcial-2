using System;
using System.Collections.Generic;

namespace MinecraftManager.Services
{
    public class InventarioService
    {
        private readonly Dictionary<string, List<string>> _inventarios;

        public InventarioService()
        {
            _inventarios = new Dictionary<string, List<string>>();
        }

        public void AgregarItem(string jugador, string item)
        {
            if (string.IsNullOrWhiteSpace(jugador))
                throw new ArgumentException("El nombre del jugador no puede estar vacío.", nameof(jugador));

            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("El nombre del item no puede estar vacío.", nameof(item));

            if (!_inventarios.ContainsKey(jugador))
            {
                _inventarios[jugador] = new List<string>();
            }

            _inventarios[jugador].Add(item);
        }

        public void EliminarItem(string jugador, string item)
        {
            if (!_inventarios.ContainsKey(jugador) || !_inventarios[jugador].Remove(item))
                throw new InvalidOperationException("El jugador o el item no existen en el inventario.");
        }

        public IEnumerable<string> ObtenerInventario(string jugador)
        {
            if (!_inventarios.ContainsKey(jugador))
                throw new KeyNotFoundException("El jugador no tiene un inventario registrado.");

            return _inventarios[jugador].AsReadOnly();
        }
    }
}

