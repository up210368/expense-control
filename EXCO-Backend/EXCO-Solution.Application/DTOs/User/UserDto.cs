namespace EXCO_Solution.Application.DTOs.User;
// Dto used to GET HTTP Method. It is what frontend shows.
public class UserDto
{
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
}