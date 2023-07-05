﻿using AutoMapper;
using Nexus.ProjectAPI.Entities;
using Nexus.ProjectAPI.Models;
using Nexus.SharedKernel.Contracts.Project;

namespace Nexus.ProjectAPI.Mapping;

[ExcludeFromCodeCoverage]
public class ProjectProfile : Profile
{
    public ProjectProfile()
    {
        CreateMap<Project, ProjectRequestModel>();
        CreateMap<ProjectRequestModel, Project>();
        CreateMap<TodoItemRequestModel, TodoItem>();

        CreateMap<Project, ProjectResponseModel>();
        CreateMap<ProjectResponseModel, Project>();
        CreateMap<TodoItem, TodoItemResponseModel>();
    }
}