using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods.Queries
{
    public class SearchModByNameQuery : IRequest<List<Mod>>
    {
        public string SearchString { get; set; }
    }
}
