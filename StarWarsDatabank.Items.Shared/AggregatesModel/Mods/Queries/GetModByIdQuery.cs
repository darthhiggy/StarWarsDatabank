using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods.Queries
{
    public class GetModByIdQuery : IRequest<Mod>
    {
        public int ModId { get; set; }
    }
}
