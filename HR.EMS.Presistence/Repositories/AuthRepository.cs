using HR.EMS.Application.JWT;

namespace HR.EMS.Presistence.Repositories;

// Author: ALI RAZA MUSHTAQ
// Email: alisaivi786@gmail.com
public class AuthRepository : GenericRepository<Users>, IAuthRepository
{
    private readonly ApplicationSettings applicationSettings;
    public AuthRepository(HrDatabaseContext context, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, ApplicationSettings applicationSettings) : base(context, configuration, httpContextAccessor, applicationSettings)
    {
        this.applicationSettings = applicationSettings;
    }

    /// <summary>
    /// Authenticates a user using the provided credentials.
    /// </summary>
    /// <param name="authRequest">Authentication request containing user credentials.</param>
    /// <returns>An APIResponse containing the authentication result and token.</returns>
    public async Task<APIResponse<AuthResponseDTO>> AuthenticateAsync(AuthRequestDTO authRequest)
    {
        try
        {
            var user = await Table.Include(u => u.Role).FirstOrDefaultAsync(u => u.UserName == authRequest.UserName);
            //await _context.Entry(user).Reference(u => u.Role).LoadAsync();
            if (user == null || !Encryption.VerifyPasswordHash(authRequest.Password, user.Password))
            {
                return new APIResponse<AuthResponseDTO>
                {
                    Success = false,
                    Message = Constants.InvalidUsernamePassword
                };
            }

            // Generate JWT token
            var token = JWTTokenAuthincation.GenerateJwtToken(user, applicationSettings);

            var authResponse = new AuthResponseDTO()
            {
                Token = token,
            };
            return new APIResponse<AuthResponseDTO>
            {
                Message = Constants.AuthenticationSuccessful,
                Data = authResponse
            };
        }
        catch (DbException dbEx)
        {
            // Handle database connection exceptions
            return new APIResponse<AuthResponseDTO>
            {
                Success = false,
                Message = Constants.ErrorDuringAuthentication,
                Error = new List<Error>
                {
                    new Error
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "Database connection error: " + dbEx.Message
                    }
                }
            };
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            return new APIResponse<AuthResponseDTO>
            {
                Success = false,
                Message = Constants.ErrorDuringAuthentication,
                Error = new List<Error>
                {
                    new Error
                    {
                        Id = Guid.NewGuid().ToString(),
                        Message = "An error occurred during authentication: " + ex.Message
                    }
                }
            };
        }
    }


    /// <summary>
    /// Registers a new user with the provided registration information.
    /// </summary>
    /// <param name="registerRequest">Registration request containing user details.</param>
    /// <returns>An APIResponse containing the registration result.</returns>
    public async Task<APIResponse<RegisterResponseDTO>> RegisterAsync(RegisterRequestDTO registerRequest)
    {
        try
        {
            if (await Table.AnyAsync(u => u.UserName == registerRequest.UserName || u.Email == registerRequest.Email))
            {
                return new APIResponse<RegisterResponseDTO>
                {
                    Success = false,
                    Message = Constants.UsernameEmailTaken
                };
            }

            var entity = new Users
            {
                // Initialize user properties
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName,
                Email = registerRequest.Email,
                UserName = registerRequest.UserName,
                Password = Encryption.GeneratePasswordHash(password: registerRequest.Password), // Generate HashPassword and Store
                RoleId = registerRequest.RoleId
            };

            var addedEntity = await AddAsync(entity);

            if (addedEntity.Success)
            {
                // TODO: Populate RegisterResponseDTO
                var registerResponse = new RegisterResponseDTO();
                return new APIResponse<RegisterResponseDTO>
                {
                    Success = true,
                    Message = Constants.RegistrationSuccessful,
                    Data = registerResponse
                };
            }
            else
            {
                return new APIResponse<RegisterResponseDTO>
                {
                    Success = false,
                    Message = Constants.ErrorDuringRegistration
                };
            }
        }
        catch (DbException dbEx)
        {
            // Handle database connection exceptions
            return new APIResponse<RegisterResponseDTO>
            {
                Success = false,
                Message = Constants.ErrorDuringRegistration,
                Error = new List<Error>
            {
                new Error
                {
                    Id = Guid.NewGuid().ToString(),
                    Message = "Database connection error: " + dbEx.Message
                }
            }
            };
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            return new APIResponse<RegisterResponseDTO>
            {
                Success = false,
                Message = Constants.ErrorDuringRegistration,
                Error = new List<Error>
            {
                new Error
                {
                    Id = Guid.NewGuid().ToString(),
                    Message = "An error occurred during registration: " + ex.Message
                }
            }
            };
        }
    }


    


   

}

