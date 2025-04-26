using System;
using System.Collections.Generic;

namespace MinecraftManager.Services
{
    public class BloqueService
    {
        private readonly List<string> _bloques;

        public BloqueService()
        {
            _bloques = new List<string>();
        }

        public void AgregarBloque(string tipoBloque)
        {
            if (string.IsNullOrWhiteSpace(tipoBloque))
                throw new ArgumentException("El tipo de bloque no puede estar vacío.", nameof(tipoBloque));

            _bloques.Add(tipoBloque);
        }

        public void EliminarBloque(string tipoBloque)
        {
            if (!_bloques.Remove(tipoBloque))
                throw new InvalidOperationException("El bloque no existe en la lista.");
        }

        public IEnumerable<string> ObtenerBloques()
        {
            return _bloques.AsReadOnly();
        }
    }
}
