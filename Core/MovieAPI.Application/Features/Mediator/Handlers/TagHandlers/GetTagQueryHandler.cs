﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieAPI.Application.Features.Mediator.Queries.TagQueries;
using MovieAPI.Application.Features.Mediator.Results.TagResults;
using MovieAPI.Persistance.Context;

namespace MovieAPI.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly MovieContext _context;

        public GetTagQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.ToListAsync();
            return values.Select(x => new GetTagQueryResult
            {
                CreatedDate = x.CreatedDate,
                DataStatus = x.DataStatus,
                DeletedDate = x.DeletedDate,
                Id = x.Id,
                ModifiedDate = x.ModifiedDate,
                TagTitle = x.TagTitle
            }).ToList();
        }
    }
}
