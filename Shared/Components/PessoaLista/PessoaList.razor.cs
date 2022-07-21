using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Teste.Models;
using Blazorise;
using Blazorise.DataGrid;

namespace Teste.Shared.Components.PessoaLista
{
    public partial class PessoaList
    {
        public List<Pessoa> zabala { get; set; }

        public PessoaList()
        {
            zabala = new List<Pessoa>();
            zabala.Add(new Pessoa()
            {
                Id = 1,
                Nome ="jhon"
            }) ;

            zabala.Add(new Pessoa()
            {
                Id = 2,
                Nome = "doe"
            });
        }
    }

    
}
