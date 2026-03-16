namespace Application.Support.Inputs;

public sealed record RegisterContactRequestInput
(
    string FirstName,
    string LastName,
    string Email,
    string? Phone,
    string Message
);
