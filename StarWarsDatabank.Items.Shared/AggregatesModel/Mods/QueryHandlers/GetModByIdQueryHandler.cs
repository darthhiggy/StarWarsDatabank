using MediatR;
using StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StarWarsDatabank.Items.FFG.Domain.AggregatesModel.Mods.QueryHandlers
{
    public class GetModByIdQueryHandler : IRequestHandler<GetModByIdQuery, Mod>
    {
        private readonly IModRepository _modRepository;

        public GetModByIdQueryHandler(IModRepository modRepository)
        {
            _modRepository = modRepository;
        }

        public Task<Mod> Handle(GetModByIdQuery request, CancellationToken cancellationToken) =>
            new Task<Mod>(() =>
            {
                return _modRepository.GetById(request.ModId);
            });
    }
}
