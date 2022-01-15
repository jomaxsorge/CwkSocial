﻿namespace CwkSocial.Api.MappingProfiles;

public class IdentitMappings : Profile
{
    public IdentitMappings()
    {
        CreateMap<UserRegistration, RegisterIdentity>();
        CreateMap<Login, LoginCommand>();
    }
}