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
                Nome ="Heineken 700ml",
                Localizacao = "Carrefour Via Norte",
                Preco = "R$2,50"
            }) ;

            zabala.Add(new Pessoa()
            {
                Nome = "Brahma 700ml",
                Localizacao = "Savegnago Otto Junqueira",
                Preco = "R$2,20"
            });

            zabala.Add(new Pessoa()
            {
                Nome = "Sub-zero 750ml",
                Localizacao = "Carrefour Ribeirão Shopping",
                Preco = "R$1,89"
            });
        }
    }

    
}
