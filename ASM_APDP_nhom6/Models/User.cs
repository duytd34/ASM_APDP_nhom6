namespace ASM_APDP_nhom6.Models
{
	public class User
	{
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }  // Non-nullable property
        public string Email { get; set; }  // Non-nullable property

        // Constructor để gán giá trị cho các thuộc tính không nullable
        public User(string username, string password, string email)
        {
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }
    }
}
