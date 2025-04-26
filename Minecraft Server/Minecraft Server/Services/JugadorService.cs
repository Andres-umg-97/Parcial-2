using System;
using System.Collections.Generic;

namespace MinecraftManager.Services
{
    public class JugadorService
    {
        private readonly List<string> _jugadores;

        public JugadorService()
        {
            _jugadores = new List<string>();
        }

        public void AgregarJugador(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del jugador no puede estar vacío.", nameof(nombre));

            _jugadores.Add(nombre);
        }

        public void EliminarJugador(string nombre)
        {
            if (!_jugadores.Remove(nombre))
                throw new InvalidOperationException("El jugador no existe en la lista.");
        }

        public IEnumerable<string> ObtenerJugadores()
        {
            return _jugadores.AsReadOnly();
        }
    }
}
