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
    public class GetAllModsQueryHandler : IRequestHandler<GetAllModsQuery, List<Mod>>
    {
        private readonly IModRepository _modRepository;

        public GetAllModsQueryHandler(IModRepository modRepository)
        {
            _modRepository = modRepository;
        }

        public Task<List<Mod>> Handle(GetAllModsQuery request, CancellationToken cancellationToken) =>
            new Task<List<Mod>>(() =>
            {
                return _modRepository.GetAll();
            });
    }
}
