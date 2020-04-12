using System;
using System.Collections.Generic;
using Core;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModel;

namespace Domain.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class usuariosController : ControllerBase
    {
        private readonly IBusinessUsuario business;
        public usuariosController(IBusinessUsuario business)
        {
            this.business = business;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<UsuarioViewModel> listUsuarioViewModel = business.GetAll();
            return Ok(listUsuarioViewModel);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            try
            {
            return Ok(business.GetByIdUsuario(Id));
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult Post(UsuarioViewModel usuario)
        {
            business.AddUsuario(usuario);
            return Ok();
        }

        [HttpPut("{Id}")]
        public IActionResult Put(UsuarioViewModel usuarioViewModel)
        {
            try
            {
            business.UpdateUsuario(usuarioViewModel);
            return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
            business.DeleteUsuario(Id);
            return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}