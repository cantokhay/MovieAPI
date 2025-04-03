﻿using MediatR;
using MovieAPI.Domain.Entities.Enum;

namespace MovieAPI.Application.Features.Mediator.Commands.TagCommands
{
    public class CreateTagCommand : IRequest
    {
        public DataStatus DataStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public string TagTitle { get; set; }
    }
}
