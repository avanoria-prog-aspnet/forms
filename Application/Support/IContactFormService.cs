
using Application.Support.Inputs;

namespace Application.Support;

public interface IContactFormService
{
    Task RegisterContactRequestAsync(RegisterContactRequestInput input, CancellationToken ct = default);
}
