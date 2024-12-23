﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrabajoFinal.Model;

namespace TrabajoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TPFinalController : ControllerBase
    {
        [HttpGet]
        [Route("api/CrearSuperHeroe")]
        public IActionResult CrearSuperHeroe([FromQuery] string nombre, [FromQuery] string tipo)
        {
            ISuperHero superheroe = SuperHeroFactory.CrearSuperHeroe(nombre, tipo);
            return Ok(superheroe);
        }

        [HttpGet]
        [Route("api/VisitarEnfermeria")]
        public IActionResult VisitarEnfermeria([FromQuery] string tipo, [FromQuery] int salud, [FromQuery] int cantidadDeVisitas)
        {
            Enfermeria enfermeria = Enfermeria.Instance;

            tipo = tipo.ToLower();

            if (tipo != "caballero" && tipo != "espadachin" && tipo != "guerrero")
            {
                return BadRequest("Tipo de héroe inválido");
            }

            if (salud == 5)
            {
                return BadRequest("La salud del superhéroe está al MÁXIMO");
            }

            if (salud > 5)
            {
                return BadRequest("La salud no puede ser mayor a 5");
            }

            if (cantidadDeVisitas <= 0)
            {
                return BadRequest("La cantidad de visitas a la enfermería debe ser mayor a 0");
            }

            for (int i = 0; i < cantidadDeVisitas; i++)
            {
                if (!enfermeria.CurarSuperHeroe(ref salud))
                {
                    return BadRequest("El Héroe no puede visitar mas la enfermería, límite de visitas alcanzado");
                }
            }

            return Ok($"La salud actual del {tipo} es {salud}");
        }
    }
}