using Ardalis.Result;
using Ardalis.SharedKernel;

namespace DeviantPasswordManager.UseCases.Projects.List;

public record ListProjectsQuery(int? ParentId) : IQuery<Result<List<ProjectDto>>>;
