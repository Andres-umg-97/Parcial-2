using System;
using MinecraftManager.Services;

namespace MinecraftManager.UI
{
    public class MenuManager
    {
        private readonly JugadorService _jugadorService;
        private readonly BloqueService _bloqueService;
        private readonly InventarioService _inventarioService;

        public MenuManager(JugadorService jugadorService, BloqueService bloqueService, InventarioService inventarioService)
        {
            _jugadorService = jugadorService;
            _bloqueService = bloqueService;
            _inventarioService = inventarioService;
        }

        public void MostrarMenuPrincipal()
        {
            
        }
    }
}

