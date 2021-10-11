using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSVentas.Models;
using WSVentas.Models.Response;
using WSVentas.Models.Viewmodels;

namespace WSVentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClienteController : ControllerBase
    {

        
        //ENVIAR DATOS DESDE LA API, A TRAVES DE UN JSON

        [HttpGet]
        public IActionResult Get()
        {
            Respuesta ORespuesta = new Respuesta();
            ORespuesta.Exito = 0;
            try
            {
                using (VentasRealContext db = new VentasRealContext())
                {
                    var lst = db.ClienteOrdens.OrderByDescending(d => d.IdCliente).ToList();
                    ORespuesta.Exito = 1;
                    ORespuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                ORespuesta.Mensaje = ex.Message;
            }

            return Ok(ORespuesta);


        }


        //IMPLEMENTACION DE CRUD 

        //INSERTAR DATOS EN UNA BBDD SQLSERVER

        [HttpPost]

        public IActionResult add(ClienteViewModels OModel)
        {
            Respuesta ORespuesta = new Respuesta();
            ORespuesta.Exito = 0;

            try
            {
                using (VentasRealContext db = new VentasRealContext())
                {
                    ClienteOrden OCliente = new ClienteOrden();
                    OCliente.Nombre = OModel.Nombre;
                    db.ClienteOrdens.Add(OCliente);
                    db.SaveChanges();
                    ORespuesta.Exito = 1;

                }


            }
            catch (Exception Ex)
            {
                ORespuesta.Mensaje = Ex.Message;
            }

            return Ok(ORespuesta);
        }


        // EDITAR DATOS EN UNA BBDD SQLSERVER

        [HttpPut]

        public IActionResult Edit(ClienteViewModels OModel)
        {
            Respuesta ORespuesta = new Respuesta();
            ORespuesta.Exito = 0;

            try
            {
                using (VentasRealContext db = new VentasRealContext())
                {
                    ClienteOrden OCliente = db.ClienteOrdens.Find(OModel.idCliente);
                    OCliente.Nombre = OModel.Nombre;
                    db.Entry(OCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    ORespuesta.Exito = 1;

                }


            }
            catch (Exception Ex)
            {
                ORespuesta.Mensaje = Ex.Message;
            }

            return Ok(ORespuesta);
        }


        //BORRAR DATOS DE BBDD SQLSERVER

        [HttpDelete("{id}")]

        public IActionResult Delete(long id)
        {
            Respuesta ORespuesta = new Respuesta();
            ORespuesta.Exito = 0;

            try
            {
                using (VentasRealContext db = new VentasRealContext())
                {
                    ClienteOrden OCliente = db.ClienteOrdens.Find(id);
                    db.Remove(OCliente);
                    db.SaveChanges();
                    ORespuesta.Exito = 1;
                }
            }
            catch (Exception Ex)
            {
                ORespuesta.Mensaje = Ex.Message;
            }

            return Ok(ORespuesta);
        }
    }
}
