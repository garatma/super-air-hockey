using System;
using UnityEngine.SceneManagement;

public class EstadoFin : Estado
{
    public ControladorJuego juego;

    public EstadoFin(ControladorJuego ctrlJuego)
    {
        // Constructor
        this.juego = ctrlJuego;
    }

    public override void Ejecutar()
    {
        // Realiza la acción correspondiente
        
        juego.disco.desactivar();

        if (juego.golesJugador1 == 10)
            juego.managerGUI.setearMensajeControl("Ganó el jugador 1! Esperando que el host apriete algún botón para reiniciar.");
        else
            juego.managerGUI.setearMensajeControl("Ganó el jugador 2! Esperando que el host apriete algún botón para reiniciar.");

        juego.cambiarEstado(new EstadoEsperandoReinicio(juego));
    }
}
