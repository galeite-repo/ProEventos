using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new (){
                    EventoId = 1,
                    Tema = "Angular 11",
                    Local = "Remoto",
                    Lote = "1",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "photo.png"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular 11",
                    Local = "Remoto 1",
                    Lote = "2",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "photo.png"
                },
        };

        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
