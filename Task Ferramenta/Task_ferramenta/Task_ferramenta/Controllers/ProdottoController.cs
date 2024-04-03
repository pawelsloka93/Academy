﻿using Microsoft.AspNetCore.Mvc;
using Task_ferramenta.Models;
using Task_ferramenta.Repositories;

namespace Task_ferramenta.Controllers
{
    
public class ProdottoController
    {
        [ApiController]
        [Route("api/prodotti")]
        public class LibroController : Controller
        {
            [HttpGet]
            public IActionResult ElencoProdotti()          //https://localhost:7071/api/prodotti
            {
                return Ok(ProdottoRepo.getInstance().GetAll());
            }

            [HttpGet("{valCodice}")]
            public IActionResult DettaglioProdotto(string valCodice)
            {
                Prodotto? prod = ProdottoRepo.getInstance().GetByCod(valCodice);
                if (prod is not null)
                    return Ok(prod);

                return NotFound();
            }

            [HttpPost]
            public IActionResult InserisciProdotto(Prodotto objProd)
            {
                if (ProdottoRepo.getInstance().insert(objProd))
                    return Ok();

                return BadRequest();
            }

            //[HttpDelete("{varId}")]                           //Pericolosa ;(
            private IActionResult EliminaProdotto(int varId)
            {
                if (ProdottoRepo.getInstance().delete(varId))
                    return Ok();

                return BadRequest();
            }

            //TODO: Elimina per codice

            [HttpDelete("codice/{varCodice}"), HttpPost("codice/{varCodice}")]
            public IActionResult EliminaPerCodiceProdotto(string varCodice)
            {
                Prodotto? prod = ProdottoRepo.getInstance().GetByCod(varCodice);
                if (prod is null)
                    return BadRequest();

                return EliminaProdotto(prod.ProdottoId);
            }

            [HttpPut]
            public IActionResult ModificaProdotto(Prodotto objProd)
            {
                if (ProdottoRepo.getInstance().update(objProd))
                    return Ok();

                return BadRequest();
            }

        }

    }