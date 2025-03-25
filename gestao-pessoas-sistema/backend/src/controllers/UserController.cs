public class UserController
{
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    [Route("api/users")]
    public IActionResult CreateUser([FromBody] User user)
    {
        if (user == null)
        {
            return BadRequest("Usuário não pode ser nulo.");
        }

        _userService.AddUser(user);
        return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
    }

    [HttpGet]
    [Route("api/users")]
    public IActionResult GetUsers()
    {
        var users = _userService.GetAllUsers();
        return Ok(users);
    }

    [HttpDelete]
    [Route("api/users/{id}")]
    public IActionResult DeleteUser(int id)
    {
        var user = _userService.GetUserById(id);
        if (user == null)
        {
            return NotFound("Usuário não encontrado.");
        }

        _userService.RemoveUser(id);
        return NoContent();
    }
}