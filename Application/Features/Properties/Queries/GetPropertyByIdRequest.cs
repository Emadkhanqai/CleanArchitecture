﻿using Application.Models;
using Application.Repositories;
using AutoMapper;
using Domain;
using MediatR;

namespace Application.Features.Properties.Queries
{
    public class GetPropertyByIdRequest: IRequest<PropertyDto>
    {
        public GetPropertyByIdRequest(int propertyId)
        {
            PropertyId = propertyId;
        }

        public int PropertyId { get; set; }
    }

    public class GetPropertyByIdRequestHandler: IRequestHandler<GetPropertyByIdRequest, PropertyDto>
    {
        private readonly IPropertyRepo _propertyRepo;
        private readonly IMapper _mapper;

        public GetPropertyByIdRequestHandler(IPropertyRepo propertyRepo, IMapper mapper)
        {
            _propertyRepo = propertyRepo;
            _mapper = mapper;
        }


        public async Task<PropertyDto> Handle(GetPropertyByIdRequest request, CancellationToken cancellationToken)
        {
            Property property = await _propertyRepo.GetByIdAsync(request.PropertyId);
            if (property != null)
            {
                PropertyDto propertyDto = _mapper.Map<PropertyDto>(property);
                return propertyDto;
            }

            return null;
        }
    }
}
